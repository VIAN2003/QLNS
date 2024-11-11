using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhanSu
{
    partial class frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            imageList1 = new ImageList(components);
            pic_Logo = new PictureBox();
            lb_Ten = new Label();
            lb_TenTK = new Label();
            lb_MatKhau = new Label();
            txt_TenTK = new TextBox();
            txt_MatKhau = new TextBox();
            bnt_DN = new Button();
            lb_ERR = new Label();
            ((ISupportInitialize)pic_Logo).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pic_Logo
            // 
            pic_Logo.Image = Properties.Resources.th;
            pic_Logo.Location = new Point(294, 12);
            pic_Logo.Name = "pic_Logo";
            pic_Logo.Size = new Size(165, 165);
            pic_Logo.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Logo.TabIndex = 0;
            pic_Logo.TabStop = false;
            // 
            // lb_Ten
            // 
            lb_Ten.AutoSize = true;
            lb_Ten.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Ten.Location = new Point(157, 180);
            lb_Ten.Name = "lb_Ten";
            lb_Ten.Size = new Size(468, 35);
            lb_Ten.TabIndex = 1;
            lb_Ten.Text = "HỆ THỐNG QUẢN LÝ NHÂN SỰ";
            // 
            // lb_TenTK
            // 
            lb_TenTK.AutoSize = true;
            lb_TenTK.Location = new Point(157, 262);
            lb_TenTK.Name = "lb_TenTK";
            lb_TenTK.Size = new Size(97, 20);
            lb_TenTK.TabIndex = 2;
            lb_TenTK.Text = "Tên tài khoản";
            // 
            // lb_MatKhau
            // 
            lb_MatKhau.AutoSize = true;
            lb_MatKhau.Location = new Point(157, 305);
            lb_MatKhau.Name = "lb_MatKhau";
            lb_MatKhau.Size = new Size(70, 20);
            lb_MatKhau.TabIndex = 3;
            lb_MatKhau.Text = "Mật khẩu";
            // 
            // txt_TenTK
            // 
            txt_TenTK.Location = new Point(294, 259);
            txt_TenTK.Name = "txt_TenTK";
            txt_TenTK.Size = new Size(165, 27);
            txt_TenTK.TabIndex = 4;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(294, 305);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.PasswordChar = '*';
            txt_MatKhau.Size = new Size(165, 27);
            txt_MatKhau.TabIndex = 5;
            // 
            // bnt_DN
            // 
            bnt_DN.Location = new Point(327, 338);
            bnt_DN.Name = "bnt_DN";
            bnt_DN.Size = new Size(94, 29);
            bnt_DN.TabIndex = 6;
            bnt_DN.Text = "Đăng nhập";
            bnt_DN.UseVisualStyleBackColor = true;
            bnt_DN.Click += bnt_DN_Click;
            // 
            // lb_ERR
            // 
            lb_ERR.AutoSize = true;
            lb_ERR.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ERR.ForeColor = Color.Red;
            lb_ERR.Location = new Point(157, 376);
            lb_ERR.Name = "lb_ERR";
            lb_ERR.Size = new Size(35, 17);
            lb_ERR.TabIndex = 7;
            lb_ERR.Text = "Lỗi:";
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_ERR);
            Controls.Add(bnt_DN);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_TenTK);
            Controls.Add(lb_MatKhau);
            Controls.Add(lb_TenTK);
            Controls.Add(lb_Ten);
            Controls.Add(pic_Logo);
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ Thống Đăng Nhập";
            ((ISupportInitialize)pic_Logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pic_Logo;
        private Label lb_Ten;
        private Label lb_TenTK;
        private Label lb_MatKhau;
        private TextBox txt_TenTK;
        private TextBox txt_MatKhau;
        private Button bnt_DN;
        private Label lb_ERR;
    }
}