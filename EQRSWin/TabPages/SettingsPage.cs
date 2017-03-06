using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EQRSWin.TabPages
{
    public partial class SettingsPage : MetroFramework.Controls.MetroUserControl
    {

        GsmComm.GsmCommunication.GsmPhone phone;
        public SettingsPage()
        {
            InitializeComponent();

            if (DesignMode == false)
            {
                LoadSettings();
            }
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
        }

        private void SwitchMetroButton_Click(object sender, EventArgs e)
        {
            if (phone != null && phone.IsConnected())
            {
                MetroFramework.MetroMessageBox.Show(this, "Phone already connected.");
                return;
            }

            try
            {
                using (var ctx = new EQRSContext())
                {
                    var setting = ctx.Settings.FirstOrDefault();

                    phone = new GsmComm.GsmCommunication.GsmPhone(setting.PortName, setting.BaudRate, 6000);
                    phone.Open();
                    phone.MessageReceived += Phone_MessageReceived;
                }
            }
            catch (Exception ex)
            {

                MetroFramework.MetroMessageBox.Show(this, ex.Message, "Modem Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Phone_MessageReceived(object sender, GsmComm.GsmCommunication.MessageReceivedEventArgs e)
        {

        }
    }
}
