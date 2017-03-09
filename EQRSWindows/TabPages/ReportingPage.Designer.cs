namespace EQRSWindows.TabPages
{
    partial class ReportingPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.eQRSContextDataSet = new EQRSWindows.EQRSContextDataSet();
            this.newEmergencyEventArgsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newEmergencyEventArgsTableAdapter = new EQRSWindows.EQRSContextDataSetTableAdapters.NewEmergencyEventArgsTableAdapter();
            this.requestEmergencyDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestLatitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestLongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestResponderCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requestMobileNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerDataFetcher = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eQRSContextDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmergencyEventArgsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.requestEmergencyDetailDataGridViewTextBoxColumn,
            this.requestLatitudeDataGridViewTextBoxColumn,
            this.requestLongitudeDataGridViewTextBoxColumn,
            this.requestResponderCodeDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.requestMobileNumberDataGridViewTextBoxColumn});
            this.metroGrid1.DataSource = this.newEmergencyEventArgsBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(10, 43);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(596, 291);
            this.metroGrid1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.metroLink1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(596, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // metroLink1
            // 
            this.metroLink1.Location = new System.Drawing.Point(3, 3);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(108, 23);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "Print Report";
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // eQRSContextDataSet
            // 
            this.eQRSContextDataSet.DataSetName = "EQRSContextDataSet";
            this.eQRSContextDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newEmergencyEventArgsBindingSource
            // 
            this.newEmergencyEventArgsBindingSource.DataMember = "NewEmergencyEventArgs";
            this.newEmergencyEventArgsBindingSource.DataSource = this.eQRSContextDataSet;
            // 
            // newEmergencyEventArgsTableAdapter
            // 
            this.newEmergencyEventArgsTableAdapter.ClearBeforeFill = true;
            // 
            // requestEmergencyDetailDataGridViewTextBoxColumn
            // 
            this.requestEmergencyDetailDataGridViewTextBoxColumn.DataPropertyName = "Request_EmergencyDetail";
            this.requestEmergencyDetailDataGridViewTextBoxColumn.HeaderText = "Emergency Detail";
            this.requestEmergencyDetailDataGridViewTextBoxColumn.Name = "requestEmergencyDetailDataGridViewTextBoxColumn";
            this.requestEmergencyDetailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestLatitudeDataGridViewTextBoxColumn
            // 
            this.requestLatitudeDataGridViewTextBoxColumn.DataPropertyName = "Request_Latitude";
            this.requestLatitudeDataGridViewTextBoxColumn.HeaderText = "Latitude";
            this.requestLatitudeDataGridViewTextBoxColumn.Name = "requestLatitudeDataGridViewTextBoxColumn";
            this.requestLatitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestLongitudeDataGridViewTextBoxColumn
            // 
            this.requestLongitudeDataGridViewTextBoxColumn.DataPropertyName = "Request_Longitude";
            this.requestLongitudeDataGridViewTextBoxColumn.HeaderText = "Longitude";
            this.requestLongitudeDataGridViewTextBoxColumn.Name = "requestLongitudeDataGridViewTextBoxColumn";
            this.requestLongitudeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestResponderCodeDataGridViewTextBoxColumn
            // 
            this.requestResponderCodeDataGridViewTextBoxColumn.DataPropertyName = "Request_ResponderCode";
            this.requestResponderCodeDataGridViewTextBoxColumn.HeaderText = "Responder Code";
            this.requestResponderCodeDataGridViewTextBoxColumn.Name = "requestResponderCodeDataGridViewTextBoxColumn";
            this.requestResponderCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // requestMobileNumberDataGridViewTextBoxColumn
            // 
            this.requestMobileNumberDataGridViewTextBoxColumn.DataPropertyName = "Request_MobileNumber";
            this.requestMobileNumberDataGridViewTextBoxColumn.HeaderText = "Mobile Number";
            this.requestMobileNumberDataGridViewTextBoxColumn.Name = "requestMobileNumberDataGridViewTextBoxColumn";
            this.requestMobileNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timerDataFetcher
            // 
            this.timerDataFetcher.Interval = 1000;
            this.timerDataFetcher.Tick += new System.EventHandler(this.timerDataFetcher_Tick);
            // 
            // ReportingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "ReportingPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(616, 344);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eQRSContextDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newEmergencyEventArgsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.BindingSource newEmergencyEventArgsBindingSource;
        private EQRSContextDataSet eQRSContextDataSet;
        private EQRSContextDataSetTableAdapters.NewEmergencyEventArgsTableAdapter newEmergencyEventArgsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestEmergencyDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestLatitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestLongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestResponderCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn requestMobileNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timerDataFetcher;
    }
}
