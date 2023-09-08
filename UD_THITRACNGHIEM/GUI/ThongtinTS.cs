using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UD_THITRACNGHIEM.BLL;
using UD_THITRACNGHIEM.DTO;
using UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters;

namespace UD_THITRACNGHIEM.GUI
{
    public partial class ThongtinTS : Form
    {
        public ThongtinTS()
        {
            InitializeComponent();
        }
        ThiSinhTableAdapter ts = new ThiSinhTableAdapter();
        ThiSinh_DTO a;
        MonThi_DTO b;
        KyThi_DTO c;
        
        private void ThongtinTS_Load(object sender, EventArgs e)
        {
           
            //lb_ht.Text = ts.ThongTin(a.TenDN).TenTSColumn.ToString();
            //lb_ml.Text = a.MaLop;
            //lb_ns.Text =  a.NgaySinh.ToString();
            //lb_tglm.Text = b.TgLamBai.ToString();
            //lb_kt.Text = c.TenKyThi;
        }

        private void btn_bd_Click(object sender, EventArgs e)
        {
            this.Hide();
            LamBaiTTN frm = new LamBaiTTN(comboBox1.SelectedValue.ToString());
            frm.Show();
        }
    }
}
