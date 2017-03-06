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
    public partial class RespondersPage : MetroFramework.Controls.MetroUserControl
    {
        public RespondersPage()
        {
            InitializeComponent();

            if (DesignMode == false)
            {
                LoadResponders();
            }
        }

        private void LoadResponders()
        {
            using (var ctx = new EQRSContext())
            {
                responderBindingSource.DataSource = ctx.Responders.ToList();
            }
        }

        private void SaveAllMetroLink_Click(object sender, EventArgs e)
        {
            using (var ctx = new EQRSContext())
            {
                foreach (Responder resp in responderBindingSource.List)
                {
                    if (resp.ResponderId <= 0)
                    {
                        ctx.Responders.Add(resp);
                    }
                    else
                    {
                        var r = ctx.Responders.Attach(resp);
                        ctx.Entry(r).State = System.Data.Entity.EntityState.Modified;
                    }
                }

                ctx.SaveChanges();
            }
        }

        private void respondersMetroGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            RepondersGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RepondersGrid.Rows[e.RowIndex].Cells[e.ColumnIndex]
                .Value.ToString().ToUpper();
        }
    }
}
