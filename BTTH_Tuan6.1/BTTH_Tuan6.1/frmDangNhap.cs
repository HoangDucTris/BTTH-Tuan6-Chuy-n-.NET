using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTTH_Tuan6._1.Modules;
namespace BTTH_Tuan6._1
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        XLNHANVIEN tblNhanvien;

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            tblNhanvien = new XLNHANVIEN();
            var r = tblNhanvien.Select("Username='" + txtName.Text + "' and Password'" + txtPass.Text + "'");
            if(r.Count()>0)
            {
                frmChinh f = (frmChinh)this.MdiParent;
                f.Text = "Quản lý nhà sách - chào" + r[0]["TenNV"].ToString();
                f.maNv = r[0]["MaNV"].ToString();
                f.enableControl((int)r[0]["MaLTK"]);
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!!");
            }
        }


        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (int)Keys.Enter)
            {
                btndangnhap_Click(sender, e);
            }    
        }
        private void frmDangNhap_Enter(object sender, EventArgs e)
        {
            btndangnhap_Click(sender, e);
        }
    }
}
