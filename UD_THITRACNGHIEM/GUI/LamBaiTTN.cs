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
using UD_THITRACNGHIEM.DAL;
namespace UD_THITRACNGHIEM.GUI
{
    public partial class LamBaiTTN : Form
    {
        public LamBaiTTN()
        {
            InitializeComponent();
        }
        string mamh = "AV1";
        public LamBaiTTN( string ma)
        {
            InitializeComponent();
            mamh = "AV1";
        }
        List<CauHoi_DapAn> dschda;
        private void LamBaiTTN_Load(object sender, EventArgs e)
        {
            dschda = new List<CauHoi_DapAn>();
            CauHoi_DAL da = new CauHoi_DAL();
            List<CauHoi_DTO> dsch = da.getdata();
           DapAn_DAL ds= new DapAn_DAL();
            foreach(CauHoi_DTO item in dsch)
            {
                CauHoi_DapAn t = new CauHoi_DapAn();
                t.CauHoi = item;
                List<DapAn_DTO> p = ds.getdata_CH(t.CauHoi.MaCH);
                t.ND_DA = p;
                dschda.Add(t);
               
            }
             loadcauhoi();
        }
        void loadcauhoi()
        {
            //lbl_CauHoi.Text = dschda.Where(t=>t.CauHoi.MaMH == mamh).ToList()[0].CauHoi.NoiDung;
            //lblA.Text = dschda[0].ND_DA.Where(t => t.MaCH == dschda[0].CauHoi.MaCH).ToList()[0].NoiDung;
            //lbl_B.Text = dschda[0].ND_DA.Where(t => t.MaCH == dschda[0].CauHoi.MaCH).ToList()[1].NoiDung;
            //lbl_C.Text = dschda[0].ND_DA.Where(t => t.MaCH == dschda[0].CauHoi.MaCH).ToList()[2].NoiDung;
            //lbl_D.Text = dschda[0].ND_DA.Where(t => t.MaCH == dschda[0].CauHoi.MaCH).ToList()[3].NoiDung;
        }
    }
}
