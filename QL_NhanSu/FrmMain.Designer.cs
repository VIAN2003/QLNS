namespace QL_NhanSu
{
    partial class FrmMain
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
            menuStrip1 = new MenuStrip();
            mn_DM = new ToolStripMenuItem();
            mn_CV = new ToolStripMenuItem();
            phòngBanToolStripMenuItem = new ToolStripMenuItem();
            mn_QL = new ToolStripMenuItem();
            khaiBáoHồSơToolStripMenuItem = new ToolStripMenuItem();
            mn_QT = new ToolStripMenuItem();
            cấuHìnhHệThốngToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mn_DM, mn_QL, mn_QT });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mn_DM
            // 
            mn_DM.DropDownItems.AddRange(new ToolStripItem[] { mn_CV, phòngBanToolStripMenuItem });
            mn_DM.Name = "mn_DM";
            mn_DM.Size = new Size(90, 24);
            mn_DM.Text = "Danh mục";
            // 
            // mn_CV
            // 
            mn_CV.Name = "mn_CV";
            mn_CV.Size = new Size(224, 26);
            mn_CV.Text = "Chức vụ";
            mn_CV.Click += mn_CV_Click;
            // 
            // phòngBanToolStripMenuItem
            // 
            phòngBanToolStripMenuItem.Name = "phòngBanToolStripMenuItem";
            phòngBanToolStripMenuItem.Size = new Size(224, 26);
            phòngBanToolStripMenuItem.Text = "Phòng ban";
            // 
            // mn_QL
            // 
            mn_QL.DropDownItems.AddRange(new ToolStripItem[] { khaiBáoHồSơToolStripMenuItem });
            mn_QL.Name = "mn_QL";
            mn_QL.Size = new Size(113, 24);
            mn_QL.Text = "Quản lý hồ sơ";
            // 
            // khaiBáoHồSơToolStripMenuItem
            // 
            khaiBáoHồSơToolStripMenuItem.Name = "khaiBáoHồSơToolStripMenuItem";
            khaiBáoHồSơToolStripMenuItem.Size = new Size(191, 26);
            khaiBáoHồSơToolStripMenuItem.Text = "Khai báo hồ sơ";
            // 
            // mn_QT
            // 
            mn_QT.DropDownItems.AddRange(new ToolStripItem[] { cấuHìnhHệThốngToolStripMenuItem });
            mn_QT.Name = "mn_QT";
            mn_QT.Size = new Size(139, 24);
            mn_QT.Text = "Quản trị hệ thông";
            // 
            // cấuHìnhHệThốngToolStripMenuItem
            // 
            cấuHìnhHệThốngToolStripMenuItem.Name = "cấuHìnhHệThốngToolStripMenuItem";
            cấuHìnhHệThốngToolStripMenuItem.Size = new Size(224, 26);
            cấuHìnhHệThốngToolStripMenuItem.Text = "Cấu hình hệ thống";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Quản lý hồ sơ ";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mn_DM;
        private ToolStripMenuItem mn_CV;
        private ToolStripMenuItem phòngBanToolStripMenuItem;
        private ToolStripMenuItem mn_QL;
        private ToolStripMenuItem khaiBáoHồSơToolStripMenuItem;
        private ToolStripMenuItem mn_QT;
        private ToolStripMenuItem cấuHìnhHệThốngToolStripMenuItem;
    }
}