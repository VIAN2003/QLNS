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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }


        public static string ConnectionString = "Data Source=ACERNITRO5;Initial Catalog=_QL_NhanSu;Integrated Security=True";
        public static string Loai_TaiKhoan = "-1";
        private void bnt_DN_Click(object sender, EventArgs e)
        {
            try
            {
                lb_ERR.Text = "";
                if (txt_TenTK.Text != null && txt_TenTK.Text.Trim() != "")
                {

                }
                else
                {
                    MessageBox.Show("Chưa nhập thông tin tài khoản", "Thông báo");
                    txt_TenTK.Focus();
                    return;
                }

                if (txt_MatKhau.Text != null && txt_MatKhau.Text.Trim() != "")
                {

                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu", "Thông báo");
                    txt_MatKhau.Focus();
                    return;
                }

                SqlConnection Connect = new SqlConnection(ConnectionString);
                if (Connect.State == ConnectionState.Closed)
                {
                    Connect.Open();
                }

                string TenTaiKoan = txt_TenTK.Text.Trim();
                string MatKhau = txt_MatKhau.Text.Trim();
                string Query = "select * from tbl_TaiKhoan where Ten_TaiKhoan = '" + TenTaiKoan + "'AND Mat_Khau = '" + MatKhau + "'";

                SqlCommand cmd = new SqlCommand(Query, Connect);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();
                adapter.Fill(ds);

                if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    Loai_TaiKhoan = ds.Tables[0].Rows[0]["Loai_TaiKhoan"].ToString();
                    FrmMain frm = new FrmMain(Loai_TaiKhoan);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    lb_ERR.Text = "Thông tin tài khoản hoặc mật khẩu chưa chính xác";
                }
            }
            catch (Exception ex)
            {
                lb_ERR.Text = ex.Message;
            }
        }
    }
}