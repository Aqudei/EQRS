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

namespace EQRSWin.TabPages
{
    public partial class ETransponderPage : MetroFramework.Controls.MetroUserControl
    {
        SMSRouter smsRouter;
        private delegate void SetTextCallback(string text);
        private GsmComm.GsmCommunication.GsmCommMain commMain;
        public ETransponderPage()
        {
            InitializeComponent();


            if (DesignMode == false)
            {
                LoadSettings();
                FindForm().FormClosing += ETransponderPage_FormClosing;
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

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

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
                    commMain.MessageReceived -= Phone_MessageReceived;
                    commMain.Close();
                }
                commMain = null;
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Modem Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SwitchMetroButton_Click(object sender, EventArgs e)
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

                    commMain = new GsmCommMain(setting.PortName, setting.BaudRate, 6000);
                    commMain.Open();
                    commMain.EnableMessageNotifications();
                    commMain.MessageReceived += Phone_MessageReceived;
                }

                MetroFramework.MetroMessageBox.Show(this, "Phone successfully connected.");
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }

        }

        private void Phone_MessageReceived(object sender, GsmComm.GsmCommunication.MessageReceivedEventArgs e)
        {
            try
            {
                IMessageIndicationObject obj = e.IndicationObject;
                //if (obj is MemoryLocation)
                //{
                //    MemoryLocation loc = (MemoryLocation)obj;
                //    Output(string.Format("New message received in storage \"{0}\", index {1}.",
                //        loc.Storage, loc.Index));
                //    Output("");
                //    return;
                //}
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
            if (this.LogMetroTextBox.InvokeRequired)
            {
                SetTextCallback stc = new SetTextCallback(Output);
                this.Invoke(stc, new object[] { text });
            }
            else
            {
                LogMetroTextBox.AppendText(text);
                LogMetroTextBox.AppendText("\r\n");
            }
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
    }
}
