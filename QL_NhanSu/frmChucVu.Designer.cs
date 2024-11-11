namespace QL_NhanSu
{
    partial class frmChucVu
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            dataMain = new DataGridView();
            lb_TongSo = new Label();
            lb_Loi = new Label();
            lb_TC = new Label();
            lb_IDCV = new Label();
            txt_IDCV = new TextBox();
            txt_TenCV = new TextBox();
            txt_MaCV = new TextBox();
            lb_MaCV = new Label();
            lb_TenCV = new Label();
            lb_GhiChu = new Label();
            txt_GhiChu = new TextBox();
            bnt_Them = new Button();
            bnt_Sua = new Button();
            bnt_Xoa = new Button();
            bnt_Ghi = new Button();
            bnt_Huy = new Button();
            lb_TuKhoa = new Label();
            txt_Tim = new TextBox();
            bnt_Tim = new Button();
            ((System.ComponentModel.ISupportInitialize)dataMain).BeginInit();
            SuspendLayout();
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // dataMain
            // 
            dataMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataMain.Location = new Point(6, 91);
            dataMain.Name = "dataMain";
            dataMain.RowHeadersWidth = 51;
            dataMain.RowTemplate.Height = 29;
            dataMain.Size = new Size(683, 188);
            dataMain.TabIndex = 0;
            dataMain.CellClick += dataMain_CellClick;
            // 
            // lb_TongSo
            // 
            lb_TongSo.AutoSize = true;
            lb_TongSo.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_TongSo.Location = new Point(6, 56);
            lb_TongSo.Name = "lb_TongSo";
            lb_TongSo.Size = new Size(156, 22);
            lb_TongSo.TabIndex = 1;
            lb_TongSo.Text = "Tổng số: 0 bản ghi";
            // 
            // lb_Loi
            // 
            lb_Loi.AutoSize = true;
            lb_Loi.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Loi.ForeColor = Color.Red;
            lb_Loi.Location = new Point(226, 56);
            lb_Loi.Name = "lb_Loi";
            lb_Loi.Size = new Size(43, 22);
            lb_Loi.TabIndex = 2;
            lb_Loi.Text = "Lỗi:";
            // 
            // lb_TC
            // 
            lb_TC.AutoSize = true;
            lb_TC.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_TC.ForeColor = Color.FromArgb(0, 0, 192);
            lb_TC.Location = new Point(320, 56);
            lb_TC.Name = "lb_TC";
            lb_TC.Size = new Size(100, 22);
            lb_TC.TabIndex = 3;
            lb_TC.Text = "Thành công";
            // 
            // lb_IDCV
            // 
            lb_IDCV.AutoSize = true;
            lb_IDCV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_IDCV.Location = new Point(11, 304);
            lb_IDCV.Name = "lb_IDCV";
            lb_IDCV.Size = new Size(97, 22);
            lb_IDCV.TabIndex = 4;
            lb_IDCV.Text = "ID chức vụ";
            // 
            // txt_IDCV
            // 
            txt_IDCV.Location = new Point(124, 302);
            txt_IDCV.Name = "txt_IDCV";
            txt_IDCV.Size = new Size(178, 27);
            txt_IDCV.TabIndex = 5;
            // 
            // txt_TenCV
            // 
            txt_TenCV.Location = new Point(124, 350);
            txt_TenCV.Name = "txt_TenCV";
            txt_TenCV.Size = new Size(562, 27);
            txt_TenCV.TabIndex = 7;
            // 
            // txt_MaCV
            // 
            txt_MaCV.Location = new Point(508, 302);
            txt_MaCV.Name = "txt_MaCV";
            txt_MaCV.Size = new Size(178, 27);
            txt_MaCV.TabIndex = 9;
            // 
            // lb_MaCV
            // 
            lb_MaCV.AutoSize = true;
            lb_MaCV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_MaCV.Location = new Point(389, 304);
            lb_MaCV.Name = "lb_MaCV";
            lb_MaCV.Size = new Size(103, 22);
            lb_MaCV.TabIndex = 8;
            lb_MaCV.Text = "Mã chức vụ";
            // 
            // lb_TenCV
            // 
            lb_TenCV.AutoSize = true;
            lb_TenCV.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_TenCV.Location = new Point(11, 352);
            lb_TenCV.Name = "lb_TenCV";
            lb_TenCV.Size = new Size(107, 22);
            lb_TenCV.TabIndex = 6;
            lb_TenCV.Text = "Tên chức vụ";
            // 
            // lb_GhiChu
            // 
            lb_GhiChu.AutoSize = true;
            lb_GhiChu.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_GhiChu.Location = new Point(11, 396);
            lb_GhiChu.Name = "lb_GhiChu";
            lb_GhiChu.Size = new Size(72, 22);
            lb_GhiChu.TabIndex = 10;
            lb_GhiChu.Text = "Ghi chú";
            // 
            // txt_GhiChu
            // 
            txt_GhiChu.Location = new Point(124, 394);
            txt_GhiChu.Multiline = true;
            txt_GhiChu.Name = "txt_GhiChu";
            txt_GhiChu.Size = new Size(562, 79);
            txt_GhiChu.TabIndex = 11;
            // 
            // bnt_Them
            // 
            bnt_Them.Location = new Point(132, 479);
            bnt_Them.Name = "bnt_Them";
            bnt_Them.Size = new Size(94, 29);
            bnt_Them.TabIndex = 12;
            bnt_Them.Text = "Thêm";
            bnt_Them.UseVisualStyleBackColor = true;
            bnt_Them.Click += bnt_Them_Click;
            // 
            // bnt_Sua
            // 
            bnt_Sua.Location = new Point(226, 479);
            bnt_Sua.Name = "bnt_Sua";
            bnt_Sua.Size = new Size(94, 29);
            bnt_Sua.TabIndex = 13;
            bnt_Sua.Text = "Sửa";
            bnt_Sua.UseVisualStyleBackColor = true;
            bnt_Sua.Click += bnt_Sua_Click;
            // 
            // bnt_Xoa
            // 
            bnt_Xoa.Location = new Point(320, 479);
            bnt_Xoa.Name = "bnt_Xoa";
            bnt_Xoa.Size = new Size(94, 29);
            bnt_Xoa.TabIndex = 14;
            bnt_Xoa.Text = "Xóa";
            bnt_Xoa.UseVisualStyleBackColor = true;
            bnt_Xoa.Click += bnt_Xoa_Click;
            // 
            // bnt_Ghi
            // 
            bnt_Ghi.Location = new Point(414, 479);
            bnt_Ghi.Name = "bnt_Ghi";
            bnt_Ghi.Size = new Size(94, 29);
            bnt_Ghi.TabIndex = 15;
            bnt_Ghi.Text = "Ghi dữ liệu";
            bnt_Ghi.UseVisualStyleBackColor = true;
            bnt_Ghi.Click += bnt_Ghi_Click;
            // 
            // bnt_Huy
            // 
            bnt_Huy.Location = new Point(508, 479);
            bnt_Huy.Name = "bnt_Huy";
            bnt_Huy.Size = new Size(94, 29);
            bnt_Huy.TabIndex = 16;
            bnt_Huy.Text = "Hủy bỏ";
            bnt_Huy.UseVisualStyleBackColor = true;
            bnt_Huy.Click += bnt_Huy_Click;
            // 
            // lb_TuKhoa
            // 
            lb_TuKhoa.AutoSize = true;
            lb_TuKhoa.Location = new Point(11, 9);
            lb_TuKhoa.Name = "lb_TuKhoa";
            lb_TuKhoa.Size = new Size(65, 20);
            lb_TuKhoa.TabIndex = 17;
            lb_TuKhoa.Text = "Từ khóa:";
            // 
            // txt_Tim
            // 
            txt_Tim.Location = new Point(82, 6);
            txt_Tim.Name = "txt_Tim";
            txt_Tim.Size = new Size(387, 27);
            txt_Tim.TabIndex = 18;
            // 
            // bnt_Tim
            // 
            bnt_Tim.Location = new Point(475, 5);
            bnt_Tim.Name = "bnt_Tim";
            bnt_Tim.Size = new Size(94, 29);
            bnt_Tim.TabIndex = 19;
            bnt_Tim.Text = "Tìm kiếm";
            bnt_Tim.UseVisualStyleBackColor = true;
            bnt_Tim.Click += bnt_Tim_Click;
            // 
            // frmChucVu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 534);
            Controls.Add(bnt_Tim);
            Controls.Add(txt_Tim);
            Controls.Add(lb_TuKhoa);
            Controls.Add(bnt_Huy);
            Controls.Add(bnt_Ghi);
            Controls.Add(bnt_Xoa);
            Controls.Add(bnt_Sua);
            Controls.Add(bnt_Them);
            Controls.Add(txt_GhiChu);
            Controls.Add(lb_GhiChu);
            Controls.Add(txt_MaCV);
            Controls.Add(lb_MaCV);
            Controls.Add(txt_TenCV);
            Controls.Add(lb_TenCV);
            Controls.Add(txt_IDCV);
            Controls.Add(lb_IDCV);
            Controls.Add(lb_TC);
            Controls.Add(lb_Loi);
            Controls.Add(lb_TongSo);
            Controls.Add(dataMain);
            Name = "frmChucVu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmChucVu";
            ((System.ComponentModel.ISupportInitialize)dataMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataMain;
        private Label lb_TongSo;
        private Label lb_Loi;
        private Label lb_TC;
        private Label lb_IDCV;
        private TextBox txt_IDCV;
        private TextBox txt_TenCV;
        private TextBox txt_MaCV;
        private Label lb_MaCV;
        private Label lb_TenCV;
        private Label lb_GhiChu;
        private TextBox txt_GhiChu;
        private Button bnt_Them;
        private Button bnt_Sua;
        private Button bnt_Xoa;
        private Button bnt_Ghi;
        private Button bnt_Huy;
        private Label lb_TuKhoa;
        private TextBox txt_Tim;
        private Button bnt_Tim;
    }
}