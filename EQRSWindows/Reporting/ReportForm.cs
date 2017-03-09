using CrystalDecisions.Shared;
using EQRSWin;
using EQRSWindows.Reporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EQRSWindows
{
    public partial class ReportForm : MetroFramework.Forms.MetroForm
    {

        EQRSContextDataSet ReportDS;
        public ReportForm()
        {
            InitializeComponent();

            ReportDS = new EQRSContextDataSet();
            
            using (var adptr = new EQRSContextDataSetTableAdapters.NewEmergencyEventArgsTableAdapter())
            {
                adptr.Fill(ReportDS.NewEmergencyEventArgs);
            }

            var rptSource = new EmergencyReport();
            rptSource.SetDataSource(ReportDS);
            crystalReportViewer1.ReportSource = rptSource;
            crystalReportViewer1.Refresh();
        }
    }
}
