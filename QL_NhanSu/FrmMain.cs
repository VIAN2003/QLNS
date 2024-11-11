using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NhanSu
{
    public partial class FrmMain : Form
    {
        public FrmMain(string Loai_TaiKhoan)
        {
            InitializeComponent();
            if (Loai_TaiKhoan == "0")
            {
                mn_DM.Enabled = true;
                mn_QL.Enabled = true;
                mn_QT.Enabled = true;
            }
            else
            {
                mn_DM.Enabled = false;
                mn_QL.Enabled = true;
                mn_QT.Enabled = false;
            }
        }

        private void mn_CV_Click(object sender, EventArgs e)
        {
            frmChucVu _frmchucVu = new frmChucVu();
            //_frmchucVu.MdiParent = this;
            _frmchucVu.Show();
            
        }
    }
}
