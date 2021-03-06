﻿namespace EQRSWin
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.respondersPage1 = new EQRSWin.TabPages.RespondersPage();
            this.settingsPage1 = new EQRSWin.TabPages.ETransponderPage();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(656, 394);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.respondersPage1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(648, 352);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Responders";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.settingsPage1);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(648, 352);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Emergency Transponder";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // respondersPage1
            // 
            this.respondersPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.respondersPage1.Location = new System.Drawing.Point(0, 0);
            this.respondersPage1.Name = "respondersPage1";
            this.respondersPage1.Padding = new System.Windows.Forms.Padding(10);
            this.respondersPage1.Size = new System.Drawing.Size(648, 352);
            this.respondersPage1.TabIndex = 2;
            this.respondersPage1.UseSelectable = true;
            // 
            // settingsPage1
            // 
            this.settingsPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPage1.Location = new System.Drawing.Point(0, 0);
            this.settingsPage1.Name = "settingsPage1";
            this.settingsPage1.Padding = new System.Windows.Forms.Padding(10);
            this.settingsPage1.Size = new System.Drawing.Size(648, 352);
            this.settingsPage1.TabIndex = 2;
            this.settingsPage1.UseSelectable = true;
            this.settingsPage1.Load += new System.EventHandler(this.settingsPage1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 474);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "EQRS";
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private TabPages.RespondersPage respondersPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private TabPages.ETransponderPage settingsPage1;
    }
}

