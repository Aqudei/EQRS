namespace EQRSWin.TabPages
{
    partial class SettingsPage
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SaveMetroButton = new MetroFramework.Controls.MetroButton();
            this.SwitchMetroButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.PortNameMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.BaudRateMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 97);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(91, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Port Number:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 135);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Baud Rate:";
            // 
            // SaveMetroButton
            // 
            this.SaveMetroButton.Location = new System.Drawing.Point(355, 186);
            this.SaveMetroButton.Name = "SaveMetroButton";
            this.SaveMetroButton.Size = new System.Drawing.Size(95, 23);
            this.SaveMetroButton.TabIndex = 5;
            this.SaveMetroButton.Text = "Save Settings";
            this.SaveMetroButton.UseSelectable = true;
            this.SaveMetroButton.Click += new System.EventHandler(this.SaveMetroButton_Click);
            // 
            // SwitchMetroButton
            // 
            this.SwitchMetroButton.Location = new System.Drawing.Point(254, 186);
            this.SwitchMetroButton.Name = "SwitchMetroButton";
            this.SwitchMetroButton.Size = new System.Drawing.Size(95, 23);
            this.SwitchMetroButton.TabIndex = 6;
            this.SwitchMetroButton.Text = "Connect";
            this.SwitchMetroButton.UseSelectable = true;
            this.SwitchMetroButton.Click += new System.EventHandler(this.SwitchMetroButton_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(22, 52);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(105, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Modem Settings";
            // 
            // PortNameMetroComboBox
            // 
            this.PortNameMetroComboBox.FormattingEnabled = true;
            this.PortNameMetroComboBox.ItemHeight = 23;
            this.PortNameMetroComboBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15"});
            this.PortNameMetroComboBox.Location = new System.Drawing.Point(142, 97);
            this.PortNameMetroComboBox.Name = "PortNameMetroComboBox";
            this.PortNameMetroComboBox.Size = new System.Drawing.Size(308, 29);
            this.PortNameMetroComboBox.TabIndex = 8;
            this.PortNameMetroComboBox.UseSelectable = true;
            // 
            // BaudRateMetroComboBox
            // 
            this.BaudRateMetroComboBox.FormattingEnabled = true;
            this.BaudRateMetroComboBox.ItemHeight = 23;
            this.BaudRateMetroComboBox.Items.AddRange(new object[] {
            "9800",
            "115200"});
            this.BaudRateMetroComboBox.Location = new System.Drawing.Point(142, 132);
            this.BaudRateMetroComboBox.Name = "BaudRateMetroComboBox";
            this.BaudRateMetroComboBox.Size = new System.Drawing.Size(308, 29);
            this.BaudRateMetroComboBox.TabIndex = 9;
            this.BaudRateMetroComboBox.UseSelectable = true;
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BaudRateMetroComboBox);
            this.Controls.Add(this.PortNameMetroComboBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.SwitchMetroButton);
            this.Controls.Add(this.SaveMetroButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "SettingsPage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(472, 305);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton SaveMetroButton;
        private MetroFramework.Controls.MetroButton SwitchMetroButton;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox PortNameMetroComboBox;
        private MetroFramework.Controls.MetroComboBox BaudRateMetroComboBox;
    }
}
