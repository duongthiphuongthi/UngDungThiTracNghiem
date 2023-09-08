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
    public partial class QL_GIANGVIEN : Form
    {
        public QL_GIANGVIEN()
        {
            InitializeComponent();
        }

        private void QL_GIANGVIEN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM.GiangVien' table. You can move, or remove it, as needed.
            this.giangVienTableAdapter.Fill(this.uD_THITRACNGHIEM.GiangVien);

        }

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    giangVienBindingSource.EndEdit();
                    giangVienTableAdapter.Update(this.uD_THITRACNGHIEM.GiangVien);
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
            this.giangVienTableAdapter.Fill(this.uD_THITRACNGHIEM.GiangVien);
        }

        private void In_toolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
