﻿namespace QLNHANVIENNET
{
    partial class frmmain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnudanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqlhs = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpKhaiBáoHồSơNhânSựToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuqtht = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudanhmuc,
            this.mnuqlhs,
            this.mnuqtht});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnudanhmuc
            // 
            this.mnudanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcVụToolStripMenuItem,
            this.phòngBanToolStripMenuItem});
            this.mnudanhmuc.Name = "mnudanhmuc";
            this.mnudanhmuc.Size = new System.Drawing.Size(90, 24);
            this.mnudanhmuc.Text = "Danh Mục";
            // 
            // chứcVụToolStripMenuItem
            // 
            this.chứcVụToolStripMenuItem.Name = "chứcVụToolStripMenuItem";
            this.chứcVụToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.chứcVụToolStripMenuItem.Text = "Chức Vụ";
            this.chứcVụToolStripMenuItem.Click += new System.EventHandler(this.chứcVụToolStripMenuItem_Click);
            // 
            // phòngBanToolStripMenuItem
            // 
            this.phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            this.phòngBanToolStripMenuItem.Size = new System.Drawing.Size(163, 26);
            this.phòngBanToolStripMenuItem.Text = "Phòng Ban";
            // 
            // mnuqlhs
            // 
            this.mnuqlhs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpKhaiBáoHồSơNhânSựToolStripMenuItem});
            this.mnuqlhs.Name = "mnuqlhs";
            this.mnuqlhs.Size = new System.Drawing.Size(120, 24);
            this.mnuqlhs.Text = "Quản Lý Hồ Sơ";
            // 
            // nhậpKhaiBáoHồSơNhânSựToolStripMenuItem
            // 
            this.nhậpKhaiBáoHồSơNhânSựToolStripMenuItem.Name = "nhậpKhaiBáoHồSơNhânSựToolStripMenuItem";
            this.nhậpKhaiBáoHồSơNhânSựToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.nhậpKhaiBáoHồSơNhânSựToolStripMenuItem.Text = "Nhập Khai Báo Hồ Sơ Nhân Sự";
            // 
            // mnuqtht
            // 
            this.mnuqtht.Name = "mnuqtht";
            this.mnuqtht.Size = new System.Drawing.Size(147, 24);
            this.mnuqtht.Text = "Quản Trị Hệ Thống";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmuc;
        private System.Windows.Forms.ToolStripMenuItem chứcVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuqlhs;
        private System.Windows.Forms.ToolStripMenuItem nhậpKhaiBáoHồSơNhânSựToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuqtht;
    }
}