using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UD_THITRACNGHIEM.GUI
{
    public partial class ThemTaiKhoan : Form
    {
        public ThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM.TaiKhoan' table. You can move, or remove it, as needed.
            this.taiKhoanTableAdapter.Fill(this.uD_THITRACNGHIEM.TaiKhoan);

        }

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    taiKhoanBindingSource.EndEdit();
                    taiKhoanTableAdapter.Update(this.uD_THITRACNGHIEM.TaiKhoan);
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tai_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.taiKhoanTableAdapter.Fill(this.uD_THITRACNGHIEM.TaiKhoan);
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
