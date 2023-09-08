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
    public partial class QL_TS : Form
    {
        public QL_TS()
        {
            InitializeComponent();
        }

        private void QL_TS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM.ThiSinh' table. You can move, or remove it, as needed.
            this.thiSinhTableAdapter.Fill(this.uD_THITRACNGHIEM.ThiSinh);

        }
        ThiSinh_BLL ts;
        ThiSinh_DTO gandulieu()
        {
            ThiSinh_DTO a = new ThiSinh_DTO();
            a.MaTS = random();
            a.MaLop = txt_malop.Text;
            a.TenTS = txt_tents.Text;
            a.TenDN = txt_tendn.Text;
            a.NgaySinh = DateTime.Parse(mtxt_NgaySinh.Text);
            return a;
        }
        string random()
        {
            string ma = "TS";
            Random autoRand = new Random();
            for (int x = 0; x < 2; x++)
            {
                ma += autoRand.Next(1, 99).ToString();
            }
            return ma;
        }
        
        private void btn_them_Click(object sender, EventArgs e)
        {
            ts = new ThiSinh_BLL();
            bool kq = ts.Insert(gandulieu());
            if (kq)
            {
                
                MessageBox.Show("Thêm thành công", "Thông Báo");

            }
            else
            {
                MessageBox.Show("Thí sinh đã tồn tại hoặc bạn chưa điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            ThemTaiKhoan new_form = new ThemTaiKhoan();
            new_form.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            ts = new ThiSinh_BLL();
            bool kq = ts.Delete(gandulieu());
            if (kq)
            {

                MessageBox.Show("Xóa thành công", "Thông Báo");

            }
            else
            {
                MessageBox.Show("Xóa không thành công! Vui lòng kiểm tra lại", "Thông Báo");
            }
        }
    }
}
