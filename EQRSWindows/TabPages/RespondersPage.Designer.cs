namespace EQRSWin.TabPages
{
    partial class RespondersPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RepondersGrid = new MetroFramework.Controls.MetroGrid();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SaveAllMetroLink = new MetroFramework.Controls.MetroLink();
            this.DeleteResponderMetroLink = new MetroFramework.Controls.MetroLink();
            this.responderNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responderCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RepondersGrid)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RepondersGrid
            // 
            this.RepondersGrid.AllowUserToResizeRows = false;
            this.RepondersGrid.AutoGenerateColumns = false;
            this.RepondersGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RepondersGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RepondersGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RepondersGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RepondersGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RepondersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RepondersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.responderNameDataGridViewTextBoxColumn,
            this.responderCodeDataGridViewTextBoxColumn,
            this.mobileNumberDataGridViewTextBoxColumn});
            this.RepondersGrid.DataSource = this.responderBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RepondersGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.RepondersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RepondersGrid.EnableHeadersVisualStyles = false;
            this.RepondersGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RepondersGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RepondersGrid.Location = new System.Drawing.Point(10, 10);
            this.RepondersGrid.Name = "RepondersGrid";
            this.RepondersGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RepondersGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.RepondersGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RepondersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RepondersGrid.Size = new System.Drawing.Size(470, 241);
            this.RepondersGrid.TabIndex = 1;
            this.RepondersGrid.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.respondersMetroGrid_CellEndEdit);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.SaveAllMetroLink);
            this.flowLayoutPanel1.Controls.Add(this.DeleteResponderMetroLink);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 251);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 30);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // SaveAllMetroLink
            // 
            this.SaveAllMetroLink.Location = new System.Drawing.Point(3, 3);
            this.SaveAllMetroLink.Name = "SaveAllMetroLink";
            this.SaveAllMetroLink.Size = new System.Drawing.Size(75, 23);
            this.SaveAllMetroLink.TabIndex = 0;
            this.SaveAllMetroLink.Text = "Save All";
            this.SaveAllMetroLink.UseSelectable = true;
            this.SaveAllMetroLink.Click += new System.EventHandler(this.SaveAllMetroLink_Click);
            // 
            // DeleteResponderMetroLink
            // 
            this.DeleteResponderMetroLink.Location = new System.Drawing.Point(84, 3);
            this.DeleteResponderMetroLink.Name = "DeleteResponderMetroLink";
            this.DeleteResponderMetroLink.Size = new System.Drawing.Size(75, 23);
            this.DeleteResponderMetroLink.TabIndex = 1;
            this.DeleteResponderMetroLink.Text = "Delete";
            this.DeleteResponderMetroLink.UseSelectable = true;
            this.DeleteResponderMetroLink.Click += new System.EventHandler(this.DeleteResponderMetroLink_Click);
            // 
            // responderNameDataGridViewTextBoxColumn
            // 
            this.responderNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.responderNameDataGridViewTextBoxColumn.DataPropertyName = "ResponderName";
            this.responderNameDataGridViewTextBoxColumn.HeaderText = "Responder Name";
            this.responderNameDataGridViewTextBoxColumn.Name = "responderNameDataGridViewTextBoxColumn";
            // 
            // responderCodeDataGridViewTextBoxColumn
            // 
            this.responderCodeDataGridViewTextBoxColumn.DataPropertyName = "ResponderCode";
            this.responderCodeDataGridViewTextBoxColumn.HeaderText = "Responder Code";
            this.responderCodeDataGridViewTextBoxColumn.Name = "responderCodeDataGridViewTextBoxColumn";
            this.responderCodeDataGridViewTextBoxColumn.Width = 249;
            // 
            // mobileNumberDataGridViewTextBoxColumn
            // 
            this.mobileNumberDataGridViewTextBoxColumn.DataPropertyName = "MobileNumber";
            this.mobileNumberDataGridViewTextBoxColumn.HeaderText = "Mobile Number";
            this.mobileNumberDataGridViewTextBoxColumn.Name = "mobileNumberDataGridViewTextBoxColumn";
            // 
            // responderBindingSource
            // 
            this.responderBindingSource.DataSource = typeof(EQRSWin.Responder);
            // 
            // RespondersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RepondersGrid);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "RespondersPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(490, 291);
            ((System.ComponentModel.ISupportInitialize)(this.RepondersGrid)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.responderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid RepondersGrid;
        private System.Windows.Forms.BindingSource responderBindingSource;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLink SaveAllMetroLink;
        private MetroFramework.Controls.MetroLink DeleteResponderMetroLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn responderNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn responderCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNumberDataGridViewTextBoxColumn;
    }
}
