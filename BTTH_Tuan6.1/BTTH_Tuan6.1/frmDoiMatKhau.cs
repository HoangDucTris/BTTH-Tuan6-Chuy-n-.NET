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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            
        }

        private void btnkhong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            if(txtPassnew.Text.Length<8 || !txtPassnew.Text.Any(char.IsDigit)||
            !txtPassnew.Text.Any(char.IsLower)|| !txtPassnew.Text.Any(char.IsUpper))
            {
                MessageBox.Show(txtPassnew, "Mật khẩu mới bao gồm 8 kí tự, gồm chữ số, " + "in hoa, in thường.");
                return;
            }
            if(txtPassnew.Text!=txtConfirm.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }
            frmChinh f = (frmChinh)this.MdiParent;
            int c = XLBANG.Thuc_hien_lenh("Update Nhanvien set password='" + txtPassnew.Text + "' where MaNV = '" + f.maNv + "'");
            if (c > 0)
            {
                MessageBox.Show("Cập nhật thành công");
            }
            else
                MessageBox.Show("Mật khẩu không hợp lệ");
        }
    }
}
