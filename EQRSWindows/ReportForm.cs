using CrystalDecisions.Shared;
using EQRSWin;
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
        public ReportForm()
        {
            InitializeComponent();

            crystalReportViewer1.ReportSource = new EmergencyReport() ;
            crystalReportViewer1.Refresh();
        }
    }
}
