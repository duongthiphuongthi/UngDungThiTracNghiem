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
    public partial class QL_CAUHOI : Form
    {
        public QL_CAUHOI()
        {
            InitializeComponent();
        }

        private void QL_CAUHOI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM.KyThi' table. You can move, or remove it, as needed.
            this.kyThiTableAdapter.Fill(this.uD_THITRACNGHIEM.KyThi);
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM1.CauHoi' table. You can move, or remove it, as needed.
            this.cauHoiTableAdapter.Fill(this.uD_THITRACNGHIEM1.CauHoi);
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM.DapAn' table. You can move, or remove it, as needed.
            this.dapAnTableAdapter.Fill(this.uD_THITRACNGHIEM.DapAn);
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM.CauHoi' table. You can move, or remove it, as needed.
            this.cauHoiTableAdapter.Fill(this.uD_THITRACNGHIEM.CauHoi);
            // TODO: This line of code loads data into the 'uD_THITRACNGHIEM.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.uD_THITRACNGHIEM.MonHoc);
            da_dlist = new List<DapAn_DTO>();

        }
        
        void KtraDung()
        {
            string maCH = da_d.MaCH;
            if(radioButton1.Checked)
            {
                da_d.MaDA = randomDA() + "1";
                da_d.NoiDung = textBox1.Text;
                da_d.DungSai = true;
                da_dlist.Add(da_d);
                da_d = new DapAn_DTO();
                da_d.MaCH = maCH;
                da_d.MaDA = randomDA() + "2";
                da_d.NoiDung = textBox2.Text;
                da_d.DungSai = false;
                da_dlist.Add(da_d);
                da_d = new DapAn_DTO();
                da_d.MaCH = maCH;
                da_d.MaDA = randomDA() + "3";
                da_d.NoiDung = textBox3.Text;
                da_d.DungSai = false;
                da_dlist.Add(da_d);
                da_d = new DapAn_DTO();
                da_d.MaCH = maCH;
                da_d.MaDA = randomDA() + "4";
                da_d.NoiDung = textBox4.Text;
                da_d.DungSai = false;
                da_dlist.Add(da_d);
            }
            else
            {
                if(radioButton2.Checked)
                {
                    da_d.MaDA = randomDA() + "1";
                    da_d.NoiDung = textBox1.Text;
                    da_d.DungSai = false;
                    da_dlist.Add(da_d);
                    da_d = new DapAn_DTO();
                    da_d.MaCH = maCH;
                    da_d.MaDA = randomDA() + "2";
                    da_d.NoiDung = textBox2.Text;
                    da_d.DungSai = true;
                    da_dlist.Add(da_d);
                    da_d = new DapAn_DTO();
                    da_d.MaCH = maCH;
                    da_d.MaDA = randomDA() + "3";
                    da_d.NoiDung = textBox3.Text;
                    da_d.DungSai = false;
                    da_dlist.Add(da_d);
                    da_d = new DapAn_DTO();
                    da_d.MaCH = maCH;
                    da_d.MaDA = randomDA() + "4";
                    da_d.NoiDung = textBox4.Text;
                    da_d.DungSai = false;
                    da_dlist.Add(da_d);
                }
                else
                {
                    if (radioButton3.Checked)
                    {
                        da_d.MaDA = randomDA() + "1";
                        da_d.NoiDung = textBox1.Text;
                        da_d.DungSai = false;
                        da_dlist.Add(da_d);
                        da_d = new DapAn_DTO();
                        da_d.MaCH = maCH;
                        da_d.MaDA = randomDA() + "2";
                        da_d.NoiDung = textBox2.Text;
                        da_d.DungSai = false;
                        da_dlist.Add(da_d);
                        da_d = new DapAn_DTO();
                        da_d.MaCH = maCH;
                        da_d.MaDA = randomDA() + "3";
                        da_d.NoiDung = textBox3.Text;
                        da_d.DungSai = true;
                        da_dlist.Add(da_d);
                        da_d = new DapAn_DTO();
                        da_d.MaCH = maCH;
                        da_d.MaDA = randomDA() + "4";
                        da_d.NoiDung = textBox4.Text;
                        da_d.DungSai = false;
                        da_dlist.Add(da_d);
                    }
                    else
                    {
                        da_d.MaDA = randomDA() + "1";
                        da_d.NoiDung = textBox1.Text;
                        da_d.DungSai = false;
                        da_dlist.Add(da_d);
                        da_d = new DapAn_DTO();
                        da_d.MaCH = maCH;
                        da_d.MaDA = randomDA() + "2";
                        da_d.NoiDung = textBox2.Text;
                        da_d.DungSai = false;
                        da_dlist.Add(da_d);
                        da_d = new DapAn_DTO();
                        da_d.MaCH = maCH;
                        da_d.MaDA = randomDA() + "3";
                        da_d.NoiDung = textBox3.Text;
                        da_d.DungSai = false;
                        da_dlist.Add(da_d);
                        da_d = new DapAn_DTO();
                        da_d.MaCH = maCH;
                        da_d.MaDA = randomDA() + "4";
                        da_d.NoiDung = textBox4.Text;
                        da_d.DungSai = true;
                        da_dlist.Add(da_d);
                    }
                }
            }
        }
        CauHoi_BLL ch;
        CauHoi_DTO ch_d;
        CauHoi_DTO gandulieu()
        {
            ch_d = new CauHoi_DTO();
            ch_d.MaCH = random();
            ch_d.MaMH = cb_mh.SelectedValue.ToString();
            ch_d.NoiDung = rtb_cauhoi.Text;
            gandulieu1();
            return ch_d;
        }
        DapAn_BLL da;
        List<DapAn_DTO> da_dlist;
        DapAn_DTO da_d;
        DapAn_DTO gandulieu1()
        {
            da_d = new DapAn_DTO();
            da_d.MaCH = ch_d.MaCH;
            KtraDung();
            return da_d;
        }
        string random()
        {
            string ma = "CH";
            Random autoRand = new Random();
            for (int x = 0; x < 2; x++)
            {
                ma += autoRand.Next(1, 99).ToString();
            }
            return ma;
        }
        string randomDA()
        {
            string ma = "DA";
            Random autoRand = new Random();
            for (int x = 0; x < 2; x++)
            {
                ma += autoRand.Next(1, 99).ToString();
            }
            return ma;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ch = new CauHoi_BLL();
            bool kq = ch.Insert(gandulieu());
            if (kq)
            {
                da = new DapAn_BLL();
                bool kq1 = da.Insert(da_dlist);
                if (kq1)
                {
                    MessageBox.Show("Thêm thành công", "Thông Báo");

                }
                else
                {
                    MessageBox.Show("Câu hỏi đã tồn tại hoặc bạn chưa điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
                }

            }
            else
            {
                MessageBox.Show("Câu hỏi đã tồn tại hoặc bạn chưa điền đủ thông tin! Vui lòng kiểm tra lại", "Thông Báo");
            }
        

        }

        private void button9_Click(object sender, EventArgs e)
        {
            ch = new CauHoi_BLL();
            bool kq = ch.Delete(gandulieu());
            if (kq)
            {
                da = new DapAn_BLL();
                bool kq1 = da.Delete(da_dlist);
                if (kq1)
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo");

                }
                else
                {
                    MessageBox.Show("Xóa không thành công! Vui lòng kiểm tra lại", "Thông Báo");
                }

            }
            else
            {
                MessageBox.Show("Xóa không thành công! Vui lòng kiểm tra lại", "Thông Báo");
            }
        }
     
        
    }
}
