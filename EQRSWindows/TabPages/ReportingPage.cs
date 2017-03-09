using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQRSWindows.TabPages
{
    public partial class ReportingPage : MetroFramework.Controls.MetroUserControl
    {
        public ReportingPage()
        {
            InitializeComponent();

            if (DesignMode == false)
                timerDataFetcher.Start();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            using (var frm = new ReportForm())
            {
                frm.ShowDialog();
            }
        }

        private void timerDataFetcher_Tick(object sender, EventArgs e)
        {
            using (var adptr = new EQRSContextDataSetTableAdapters.NewEmergencyEventArgsTableAdapter())
            {
                adptr.ClearBeforeFill = true;
                newEmergencyEventArgsBindingSource.DataSource = adptr.GetData();
            }
        }
    }
}
