using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UD_THITRACNGHIEM.DAL;

namespace UD_THITRACNGHIEM.GUI
{
    public partial class QuanLy : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public QuanLy()
        {
            InitializeComponent();
            random = new Random();
        }
        private Color SelectThemeColor()
        {
            int index = random.Next(Colorcs.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Colorcs.ColorList.Count);
            }
            tempIndex = index;
            string color = Colorcs.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    pnl_menu.BackColor = color;
                    Colorcs.PrimaryColor = color;
                    Colorcs.SecondaryColor = Colorcs.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pnl_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void btn_cauhoi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_monthi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_ts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_ql_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_kq_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_cathi_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private Form mauFormCon;
        private void openformCon(Form formcon)
        {
            if (mauFormCon != null)
            {
                mauFormCon.Close();
            }
            mauFormCon = formcon;
            formcon.TopLevel = false;
            formcon.FormBorderStyle = FormBorderStyle.None;
            formcon.Dock = DockStyle.Fill;
            pnl_body.Controls.Add(formcon);
            pnl_body.Tag = formcon;
            formcon.BringToFront();
            formcon.Show();
        }

        private void btn_ts_Click_1(object sender, EventArgs e)
        {
            openformCon(new QL_TS());
            lb_tieude.Text = btn_ts.Text;
        }

        private void btn_monthi_Click_1(object sender, EventArgs e)
        {
            openformCon(new QL_MONTHI());
            lb_tieude.Text = btn_monthi.Text;
        }

  

        private void btn_kythi_Click(object sender, EventArgs e)
        {
            openformCon(new QL_KYTHI());
            lb_tieude.Text = btn_kythi.Text;
        }

        private void btn_ch_Click(object sender, EventArgs e)
        {
            openformCon(new QL_CAUHOI());
            lb_tieude.Text = btn_ch.Text;
        }

        private void btn_ql_Click_1(object sender, EventArgs e)
        {
            openformCon(new QL_GIANGVIEN());
            lb_tieude.Text = btn_ql.Text;
        }

        private void btn_kq_Click_1(object sender, EventArgs e)
        {
            openformCon(new QL_KETQUA());
            lb_tieude.Text = btn_kq.Text;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lb_time.Text = "";
            lb_time.Text = now.ToString("HH:mm:ss tt");
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            

        }

        private void lb_time_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show("Bạn có chắc muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo);
            if (h == DialogResult.Yes)
                Application.Exit();
        }

        private void btn_tk_Click(object sender, EventArgs e)
        {
            openformCon(new ThemTaiKhoan());
            lb_tieude.Text = btn_tk.Text;
        }

       

        
       
    }
}
