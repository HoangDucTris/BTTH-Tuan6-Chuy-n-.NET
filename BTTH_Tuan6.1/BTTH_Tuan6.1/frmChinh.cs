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
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
        }
        public string maNv;
        frmDoiMatKhau fDoiMatKhau;
        public void enableControl(int maLTK)
        {
            switch(maLTK)
            {
                case 1: //admin
                    btndangxuat.Enabled = true;
                    btndoimk.Enabled = true;
                    btnnhanvien.Enabled = true;
                    btnchamcong.Enabled = true;
                    btnloaisp.Enabled = true;
                    btnsanpham.Enabled = true;
                    btndonhang.Enabled = true;
                    btnkhachhang.Enabled = true;
                    btntaodonhang.Enabled = true;
                    btnthongkedoanhthu.Enabled = true;
                    break;
                case 2: //nhan vien ban hang
                    btndangxuat.Enabled = true;
                    btndoimk.Enabled = true;
                    btnnhanvien.Enabled = false;
                    btnchamcong.Enabled = false;
                    btnloaisp.Enabled = false;
                    btnsanpham.Enabled = false;
                    btndonhang.Enabled = false;
                    btnkhachhang.Enabled = true;
                    btntaodonhang.Enabled = true;
                    btnthongkedoanhthu.Enabled = false;
                    break;
                case 3: //nhan vien quan ly kho
                    btndangxuat.Enabled = true;
                    btndoimk.Enabled = true;
                    btnnhanvien.Enabled = false;
                    btnchamcong.Enabled = false;
                    btnloaisp.Enabled = true;
                    btnsanpham.Enabled = true;
                    btndonhang.Enabled = false;
                    btnkhachhang.Enabled = false;
                    btntaodonhang.Enabled = false;
                    btnthongkedoanhthu.Enabled = false;
                    break;
                default:
                    btndangxuat.Enabled = false;
                    btndoimk.Enabled = false;
                    btnnhanvien.Enabled = false;
                    btnchamcong.Enabled = false;
                    btnloaisp.Enabled = false;
                    btnsanpham.Enabled = false;
                    btndonhang.Enabled = false;
                    btnkhachhang.Enabled = false;
                    btntaodonhang.Enabled = false;
                    btnthongkedoanhthu.Enabled = false;
                    break;
            }    
        }
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }
        private void ribbon1_Click(object sender, EventArgs e)
        {
            if (btndangxuat.CheckOnClick) 
            {
                foreach (Form f in this.MdiChildren)
                {
                    f.Close();
                }
                frmChinh_Load(sender, e);
            }
            if(btndoimk.CheckOnClick)
            {
                if(fDoiMatKhau == null)
                {
                    fDoiMatKhau = new frmDoiMatKhau();
                    fDoiMatKhau.MdiParent = this;
                    fDoiMatKhau.WindowState = FormWindowState.Maximized;
                    fDoiMatKhau.Show();
                }
                else
                {
                    fDoiMatKhau.Activate();
                    fDoiMatKhau.Show();
                }    
            }    
        }
    }
}
