namespace UD_THITRACNGHIEM.GUI
{
    partial class QL_CAUHOI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_mh = new System.Windows.Forms.ComboBox();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uD_THITRACNGHIEM = new UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEM();
            this.label1 = new System.Windows.Forms.Label();
            this.kyThiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters.MonHocTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtb_cauhoi = new System.Windows.Forms.RichTextBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.cauHoiTableAdapter = new UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters.CauHoiTableAdapter();
            this.dapAnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dapAnTableAdapter = new UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters.DapAnTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uD_THITRACNGHIEM1 = new UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEM();
            this.kyThiTableAdapter = new UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters.KyThiTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uD_THITRACNGHIEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dapAnBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uD_THITRACNGHIEM1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cb_mh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 50);
            this.panel1.TabIndex = 0;
            // 
            // cb_mh
            // 
            this.cb_mh.DataSource = this.monHocBindingSource;
            this.cb_mh.DisplayMember = "TenMH";
            this.cb_mh.FormattingEnabled = true;
            this.cb_mh.Location = new System.Drawing.Point(140, 15);
            this.cb_mh.Name = "cb_mh";
            this.cb_mh.Size = new System.Drawing.Size(182, 24);
            this.cb_mh.TabIndex = 1;
            this.cb_mh.ValueMember = "MaMH";
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.uD_THITRACNGHIEM;
            // 
            // uD_THITRACNGHIEM
            // 
            this.uD_THITRACNGHIEM.DataSetName = "UD_THITRACNGHIEM";
            this.uD_THITRACNGHIEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn thi :";
            // 
            // kyThiBindingSource
            // 
            this.kyThiBindingSource.DataMember = "KyThi";
            this.kyThiBindingSource.DataSource = this.uD_THITRACNGHIEM;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(35, 125);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(632, 127);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Các câu trả lời";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(563, 86);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(17, 16);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(563, 30);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(17, 16);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(259, 34);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(17, 16);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(259, 86);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(17, 16);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(313, 85);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(235, 22);
            this.textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(313, 31);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(235, 22);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(5, 85);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(235, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(5, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 22);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtb_cauhoi);
            this.groupBox2.Location = new System.Drawing.Point(32, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(635, 102);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nội Dung Câu Hỏi";
            // 
            // rtb_cauhoi
            // 
            this.rtb_cauhoi.Location = new System.Drawing.Point(3, 19);
            this.rtb_cauhoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtb_cauhoi.Name = "rtb_cauhoi";
            this.rtb_cauhoi.Size = new System.Drawing.Size(632, 79);
            this.rtb_cauhoi.TabIndex = 0;
            this.rtb_cauhoi.Text = "";
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightBlue;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.ForeColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(848, 152);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(101, 26);
            this.button13.TabIndex = 16;
            this.button13.Text = "Xuất Excel";
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightBlue;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.ForeColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(848, 112);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(101, 26);
            this.button11.TabIndex = 13;
            this.button11.Text = "Sửa ";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightBlue;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(709, 152);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 26);
            this.button9.TabIndex = 13;
            this.button9.Text = "Xóa";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightBlue;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(709, 114);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(101, 26);
            this.button8.TabIndex = 12;
            this.button8.Text = "Thêm ";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // cauHoiTableAdapter
            // 
            this.cauHoiTableAdapter.ClearBeforeFill = true;
            // 
            // dapAnBindingSource
            // 
            this.dapAnBindingSource.DataMember = "DapAn";
            this.dapAnBindingSource.DataSource = this.uD_THITRACNGHIEM;
            // 
            // dapAnTableAdapter
            // 
            this.dapAnTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.button11);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(995, 288);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách câu hỏi";
            // 
            // uD_THITRACNGHIEM1
            // 
            this.uD_THITRACNGHIEM1.DataSetName = "UD_THITRACNGHIEM";
            this.uD_THITRACNGHIEM1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kyThiTableAdapter
            // 
            this.kyThiTableAdapter.ClearBeforeFill = true;
            // 
            // QL_CAUHOI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 338);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "QL_CAUHOI";
            this.Text = "QL_CAUHOI";
            this.Load += new System.EventHandler(this.QL_CAUHOI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uD_THITRACNGHIEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kyThiBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dapAnBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uD_THITRACNGHIEM1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cb_mh;
        private System.Windows.Forms.Label label1;
        private DAL.UD_THITRACNGHIEM uD_THITRACNGHIEM;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private DAL.UD_THITRACNGHIEMTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private DAL.UD_THITRACNGHIEMTableAdapters.CauHoiTableAdapter cauHoiTableAdapter;
        private System.Windows.Forms.BindingSource dapAnBindingSource;
        private DAL.UD_THITRACNGHIEMTableAdapters.DapAnTableAdapter dapAnTableAdapter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtb_cauhoi;
        private System.Windows.Forms.GroupBox groupBox1;
        private DAL.UD_THITRACNGHIEM uD_THITRACNGHIEM1;
        private System.Windows.Forms.BindingSource kyThiBindingSource;
        private DAL.UD_THITRACNGHIEMTableAdapters.KyThiTableAdapter kyThiTableAdapter;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}