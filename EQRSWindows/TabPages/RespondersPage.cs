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
                MetroFramework.MetroMessageBox.Show(this, "Changes were saved.");
            }
        }

        private void respondersMetroGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (RepondersGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                RepondersGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = RepondersGrid.Rows[e.RowIndex].Cells[e.ColumnIndex]
                .Value.ToString().ToUpper();
            }
        }

        private void DeleteResponderMetroLink_Click(object sender, EventArgs e)
        {
            DeleteSelected();
        }

        private void DeleteSelected()
        {
            if (responderBindingSource.Count > 0)

                using (var ctx = new EQRSContext())
                {
                    foreach (DataGridViewRow item in RepondersGrid.SelectedRows)
                    {
                        var repo = item.DataBoundItem as Responder;
                        var found = ctx.Responders.Find(repo.ResponderId);
                        if (null != found)
                        {
                            ctx.Responders.Remove(found);
                            responderBindingSource.Remove(item.DataBoundItem);
                        }
                    }
                    ctx.SaveChanges();
                }
        }
    }
}

