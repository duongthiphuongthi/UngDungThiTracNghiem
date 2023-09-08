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
    public partial class QL_MONTHI : Form
    {
        public QL_MONTHI()
        {
            InitializeComponent();
        }

        private void QL_MONTHI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.uD_THITRACNGHIEM.MonHoc);

        }

        private void Luu_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Validate())
                {
                    monHocBindingSource.EndEdit();
                    monHocTableAdapter.Update(this.uD_THITRACNGHIEM.MonHoc);
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
            this.monHocTableAdapter.Fill(this.uD_THITRACNGHIEM.MonHoc);
        }
        //MonThi_BLL mt;
        ////MonThi_DTO gandulieu()
        ////{
        ////    MonThi_DTO a = new MonThi_DTO();
        ////    a.MaMH = txt_mamonthi.Text;
        ////    a.TenMH = txt_mamonthi.Text;
        ////    a.TgLamBai = int.Parse(txt_tglambai.Text);
        ////    a.TongSoCau = int.Parse(txt_socau.Text);
        ////    return a;
        ////}

        //private void pic_luu_Click(object sender, EventArgs e)
        //{
        //    bool kq = mt.Insert(gandulieu());
        //    if (kq)
        //    {
        //        MessageBox.Show("Thêm thành công", "Thông Báo");

        //    }
        //    else
        //    {
        //        MessageBox.Show("Khách hàng đã tồn tại hoặc bạn chưa điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
        //    }
        //}
    }
}
