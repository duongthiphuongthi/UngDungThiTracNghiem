using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UD_THITRACNGHIEM.DTO;
using UD_THITRACNGHIEM.BLL;

namespace UD_THITRACNGHIEM.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        TaiKhoan_BLL tk;
        ThiSinh_BLL tsbll;

        private void txt_tdn_TextChanged(object sender, EventArgs e)
        {
            if (txt_tdn.Text != string.Empty && txt_mk.Text != string.Empty)
                btn_dn.Enabled = true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tk = new TaiKhoan_BLL();
            tsbll = new ThiSinh_BLL();
        }
        TaiKhoan_DTO a;
        TaiKhoan_DTO gandulieu()
        {
            a = new TaiKhoan_DTO();
            a.TenDN = txt_tdn.Text;
            a.MKDN = txt_mk.Text;
            return a;
        }

        private void btn_dn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_tdn.Text))
            {
                MessageBox.Show("Bạn chưa điền tên đăng nhập");
                return;
            }
            if (String.IsNullOrEmpty(txt_mk.Text))
            {
                MessageBox.Show("Bạn vui lòng điền mật khẩu");
                return;
            }
            int kq = tk.kiemTraDN(gandulieu());
            if (kq == 0 && rdb_gv.Checked)
            {
                this.Hide();
                QuanLy frm = new QuanLy();
                frm.Show();
            }
            else
            {
                if (kq == 1 && rdb_ts.Checked)
                {
                    this.Hide();
                    ThongtinTS frm = new ThongtinTS();
                    frm.Show();

                }
                else
                {
                    MessageBox.Show("Bạn nhập sai dữ liệu ", "Thông báo");
                }
            }
            
        }
    }
}
