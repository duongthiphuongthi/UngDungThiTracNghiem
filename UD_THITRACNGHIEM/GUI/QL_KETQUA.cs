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
    public partial class QL_KETQUA : Form
    {
        public QL_KETQUA()
        {
            InitializeComponent();
        }

        private void QL_KETQUA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM.KetQua' table. You can move, or remove it, as needed.
            this.ketQuaTableAdapter.Fill(this.uD_THITRACNGHIEM.KetQua);

        }

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    ketQuaBindingSource.EndEdit();
                    ketQuaTableAdapter.Update(this.uD_THITRACNGHIEM.KetQua);
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
            this.ketQuaTableAdapter.Fill(this.uD_THITRACNGHIEM.KetQua);
        }
    }
}
