using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhanSu
{
    public partial class frmChucVu : Form
    {

        public static string ConnectionString = "Data Source=ACERNITRO5;Initial Catalog=_QL_NhanSu;Integrated Security=True";
        public static string Loai_TaiKhoan = "-1";
        public static string State = "-1";
        public frmChucVu()
        {
            InitializeComponent();
            SetControl("Reset");
            GetData();
        }
        public void SetControl(string State)
        {
            switch (State)
            {
                case "Reset":
                    bnt_Them.Enabled = true;
                    bnt_Sua.Enabled = true;
                    bnt_Xoa.Enabled = true;
                    bnt_Ghi.Enabled = false;
                    bnt_Huy.Enabled = false;

                    lb_Loi.Text = "";
                    lb_TC.Text = "";
                    break;
                default: break;

            }
        }
        public void GetData()
        {
            try
            {

                SqlConnection Connect = new SqlConnection(ConnectionString);
                if (Connect.State == ConnectionState.Closed)
                {
                    Connect.Open();
                }

                string Query = "select * from tbl_ChucVu ORDER BY Ten_ChucVu";

                SqlCommand cmd = new SqlCommand(Query, Connect);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dataMain.DataSource = ds.Tables[0];
                    lb_TongSo.Text = "Tổng số: " + (dataMain.Rows.Count - 1) + " bản ghi";
                }
                else
                {
                    dataMain.DataSource = null;
                    lb_TongSo.Text = "Tổng số: 0 bản ghi";
                }
            }
            catch (Exception ex)
            {
                lb_Loi.Text = ex.Message;
            }
        }

        private void dataMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataMain.Rows[index];

            txt_IDCV.Text = row.Cells["ID_ChucVu"].Value.ToString();
            txt_MaCV.Text = row.Cells["Ma_ChucVu"].Value.ToString();
            txt_GhiChu.Text = row.Cells["Ghi_Chu"].Value.ToString();
        }

        private void bnt_Them_Click(object sender, EventArgs e)
        {
            bnt_Them.Enabled = false;
            bnt_Sua.Enabled = false;
            bnt_Xoa.Enabled = false;
            bnt_Ghi.Enabled = true;
            bnt_Huy.Enabled = true;

            txt_TenCV.Text = "";
            txt_IDCV.Text = "";
            txt_MaCV.Text = "";
            txt_GhiChu.Text = "";

            txt_IDCV.Enabled = false;
            txt_MaCV.Focus();
            State = "Insert";
        }

        private void bnt_Sua_Click(object sender, EventArgs e)
        {
            bnt_Them.Enabled = false;
            bnt_Sua.Enabled = false;
            bnt_Xoa.Enabled = false;
            bnt_Ghi.Enabled = true;
            bnt_Huy.Enabled = true;

            State = "Update";
            txt_MaCV.Focus();
        }

        private void bnt_Huy_Click(object sender, EventArgs e)
        {
            SetControl("Reset");
        }

        private void bnt_Ghi_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_MaCV.Text == "") { MessageBox.Show("Chưa nhập thông tin mã chức vụ", "Thông báo"); txt_MaCV.Focus(); return; }
                if (txt_TenCV.Text == "") { MessageBox.Show("Chưa nhập thông tin tên chức vụ", "Thông báo"); txt_TenCV.Focus(); return; }
                if (State == "Insert")
                {
                    SqlConnection Connect = new SqlConnection(ConnectionString);
                    if (Connect.State == ConnectionState.Closed)
                    {
                        Connect.Open();
                    }
                    int dem = dataMain.Rows.Count;
                    string Query = "INSERT INTO tbl_ChucVu /*(Ma_ChucVu, Ten_ChucVu, Ghi_Chu)*/ VALUES ('"+dem+ "','" + txt_MaCV.Text.Trim() + "',N'" + txt_TenCV.Text.Trim() + "',N'" + txt_GhiChu.Text.Trim() + "')";

                    SqlCommand cmd = new SqlCommand(Query, Connect);
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Thêm dữ liệu thành công", "Thông báo");
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi ghi dữ liệu", "Thông báo");
                    }
                }
                else if (State == "Update")
                {
                    SqlConnection Connect = new SqlConnection(ConnectionString);
                    if (Connect.State == ConnectionState.Closed)
                    {
                        Connect.Open();
                    }

                    string Query = "UPDATE tbl_ChucVu SET Ma_ChucVu='" + txt_MaCV.Text.Trim() + "',Ten_ChucVu=N'" + txt_TenCV.Text.Trim() + "',Ghi_Chu=N'" + txt_GhiChu.Text.Trim() + "' WHERE ID_ChucVu = '" + txt_IDCV.Text.Trim() + "'";

                    SqlCommand cmd = new SqlCommand(Query, Connect);
                    var result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo");
                        GetData();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi cập nhật dữ liệu", "Thông báo");
                    }
                }
            }
            catch (Exception ex)
            {
                lb_Loi.Text = ex.Message;
            }
        }

        private void bnt_Xoa_Click(object sender, EventArgs e)
        {
            SqlConnection Connect = new SqlConnection(ConnectionString);
            if (Connect.State == ConnectionState.Closed)
            {
                Connect.Open();
            }

            string Query = "DELETE FROM tbl_ChucVu WHERE ID_ChucVu='" + txt_IDCV.Text.Trim() + "'";

            SqlCommand cmd = new SqlCommand(Query, Connect);
            var result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Xoá dữ liệu thành công", "Thông báo");
                GetData();
            }
            else
            {
                MessageBox.Show("Lỗi xóa dữ liệu", "Thông báo");
            }
        }

        private void bnt_Tim_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection Connect = new SqlConnection(ConnectionString);
                if (Connect.State == ConnectionState.Closed)
                {
                    Connect.Open();
                }
                string Search = txt_Tim.Text.Trim();
                string Query = "select * from tbl_ChucVu WHERE Ten_ChucVu LIKE N'%" + Search + "%'";

                SqlCommand cmd = new SqlCommand(Query, Connect);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    dataMain.DataSource = ds.Tables[0];
                    lb_TongSo.Text = "Tổng số: " + (dataMain.Rows.Count - 1) + " bản ghi";
                }
                else
                {
                    dataMain.DataSource = null;
                    lb_TongSo.Text = "Tổng số: 0 bản ghi";
                }
            }
            catch (Exception ex)
            {
                lb_Loi.Text = ex.Message;
            }
        }
    }
}
