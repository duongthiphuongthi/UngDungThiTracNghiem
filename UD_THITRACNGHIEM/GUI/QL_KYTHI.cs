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
    public partial class QL_KYTHI : Form
    {
        public QL_KYTHI()
        {
            InitializeComponent();
        }

        private void QL_KYTHI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM1.KyThi' table. You can move, or remove it, as needed.
            this.kyThiTableAdapter.Fill(this.uD_THITRACNGHIEM1.KyThi);
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM.KyThi' table. You can move, or remove it, as needed.
            this.kyThiTableAdapter.Fill(this.uD_THITRACNGHIEM.KyThi);

        }

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    kyThiBindingSource.EndEdit();
                    kyThiTableAdapter.Update(this.uD_THITRACNGHIEM.KyThi);
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
            this.kyThiTableAdapter.Fill(this.uD_THITRACNGHIEM.KyThi);
        }
    }
}
