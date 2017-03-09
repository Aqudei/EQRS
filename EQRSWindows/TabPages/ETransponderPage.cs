using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using EQRSWindows;
using System.Diagnostics;

namespace EQRSWin.TabPages
{
    public partial class ETransponderPage : MetroFramework.Controls.MetroUserControl
    {
        private SMSRouter smsRouter = null;
        private delegate void SetTextCallback(string text);
        private GsmCommMain commMain;

        public ETransponderPage()
        {
            InitializeComponent();


            if (DesignMode == false)
            {
                LoadSettings();
            }
        }

        private void ETransponderPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }

        private void LoadSettings()
        {
            using (var ctx = new EQRSContext())
            {
                var setting = ctx.Settings.FirstOrDefault();
                if (setting != null)
                {
                    PortNameMetroComboBox.Text = setting.PortName;
                    BaudRateMetroComboBox.Text = setting.BaudRate.ToString();
                }
            }
        }

        private void SaveMetroButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new EQRSContext())
                {
                    var setting = ctx.Settings.FirstOrDefault();
                    if (setting == null)
                    {
                        setting = new Entities.Setting();
                        ctx.Settings.Add(setting);
                    }

                    setting.PortName = PortNameMetroComboBox.Text;
                    setting.BaudRate = int.Parse(BaudRateMetroComboBox.Text);

                    ctx.SaveChanges();
                }

                var anser = MetroFramework.MetroMessageBox.Show(this, "Settings updated.\nYou need to restart the app for the settings to take effect.\n\nDo you want to restart now?", "Restart Required", MessageBoxButtons.YesNo);
                if (anser == DialogResult.Yes)
                {
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        public void Disconnect()
        {
            try
            {
                if (commMain != null && commMain.IsConnected())
                {
                    smsRouter.NewEmergencyEvent -= SmsRouter_NewEmergencyEvent;
                    commMain.MessageReceived -= Phone_MessageReceived;
                    commMain.Close();
                }

                smsRouter = null;
                commMain = null;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Modem Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Connect()
        {
            if (commMain != null && commMain.IsConnected())
            {
                MetroFramework.MetroMessageBox.Show(this, "Phone already connected.");
                return;
            }

            try
            {
                using (var ctx = new EQRSContext())
                {
                    var setting = ctx.Settings.FirstOrDefault();

                    commMain = new GsmCommMain(setting.PortName, setting.BaudRate, 500);
                    smsRouter = new SMSRouter(commMain);
                    commMain.Open();
                    commMain.EnableMessageNotifications();
                    commMain.MessageReceived += Phone_MessageReceived;
                    FindForm().FormClosing += ETransponderPage_FormClosing;
                    smsRouter.NewEmergencyEvent += SmsRouter_NewEmergencyEvent;
                }

                MetroFramework.MetroMessageBox.Show(this, "Phone successfully connected.");
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private void SwitchMetroButton_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void SmsRouter_NewEmergencyEvent(object sender, NewEmergencyEventArg e)
        {
            using (var ctx = new EQRSContext())
            {
                ctx.NewEmergencyEventArgs.Add(e);
                ctx.SaveChanges();
            }
        }

        private void Phone_MessageReceived(object sender, GsmComm.GsmCommunication.MessageReceivedEventArgs e)
        {
            try
            {
                IMessageIndicationObject obj = e.IndicationObject;
                if (obj is MemoryLocation)
                {
                    MemoryLocation loc = (MemoryLocation)obj;
                    Output(string.Format("New message received in storage \"{0}\", index {1}.",
                        loc.Storage, loc.Index));

                    var msg = commMain.ReadMessage(loc.Index, loc.Storage);
                    commMain.DeleteMessage(loc.Index, loc.Storage);
                    if (msg.Data is SmsDeliverPdu)
                    {
                        // Received message
                        SmsDeliverPdu data = (SmsDeliverPdu)msg.Data;
                        smsRouter.HandleReceived(data.OriginatingAddress, data.SCTimestamp.ToDateTime(), data.UserDataText);
                        ShowMessage(msg.Data);
                        return;
                    }
                }

                if (obj is ShortMessage)
                {
                    ShortMessage msg = (ShortMessage)obj;
                    SmsPdu pdu = commMain.DecodeReceivedMessage(msg);

                    if (pdu is SmsDeliverPdu)
                    {
                        // Received message
                        SmsDeliverPdu data = (SmsDeliverPdu)pdu;
                        Output("New message received:");
                        smsRouter.HandleReceived(data.OriginatingAddress, data.SCTimestamp.ToDateTime(), data.UserDataText);
                        ShowMessage(pdu);
                        return;
                    }
                }

                Output("Error: Unknown notification object!");
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private void ShowException(Exception ex)
        {
            MetroFramework.MetroMessageBox.Show(this, ex.Message, "Modem Error",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Output(string text)
        {
            Debug.WriteLine(DateTime.Now + " : " + text);
        }

        private void ShowMessage(SmsPdu pdu)
        {
            if (pdu is SmsSubmitPdu)
            {
                // Stored (sent/unsent) message
                SmsSubmitPdu data = (SmsSubmitPdu)pdu;
                Output("SENT/UNSENT MESSAGE");
                Output("Recipient: " + data.DestinationAddress);
                Output("Message text: " + data.UserDataText);
                Output("-------------------------------------------------------------------");
                return;
            }
            if (pdu is SmsDeliverPdu)
            {
                // Received message
                SmsDeliverPdu data = (SmsDeliverPdu)pdu;
                Output("RECEIVED MESSAGE");
                Output("Sender: " + data.OriginatingAddress);
                Output("Sent: " + data.SCTimestamp.ToString());
                Output("Message text: " + data.UserDataText);
                Output("-------------------------------------------------------------------");

                return;
            }
            if (pdu is SmsStatusReportPdu)
            {
                // Status report
                SmsStatusReportPdu data = (SmsStatusReportPdu)pdu;
                Output("STATUS REPORT");
                Output("Recipient: " + data.RecipientAddress);
                Output("Status: " + data.Status.ToString());
                Output("Timestamp: " + data.DischargeTime.ToString());
                Output("Message ref: " + data.MessageReference.ToString());
                Output("-------------------------------------------------------------------");
                return;
            }
            Output("Unknown message type: " + pdu.GetType().ToString());
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            using (var rptForm = new ReportForm())
            {
                rptForm.ShowDialog();
            }
        }
    }
}
