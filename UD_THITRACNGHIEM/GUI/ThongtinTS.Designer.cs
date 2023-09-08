namespace UD_THITRACNGHIEM.GUI
{
    partial class ThongtinTS
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
            this.monHocTableAdapter = new UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters.MonHocTableAdapter();
            this.uD_THITRACNGHIEM = new UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEM();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_bd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.monHocBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lb_kt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_tglm = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_ns = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_ml = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_ht = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uDTHITRACNGHIEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.uD_THITRACNGHIEM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uDTHITRACNGHIEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // uD_THITRACNGHIEM
            // 
            this.uD_THITRACNGHIEM.DataSetName = "UD_THITRACNGHIEM";
            this.uD_THITRACNGHIEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.uD_THITRACNGHIEM;
            // 
            // btn_bd
            // 
            this.btn_bd.Location = new System.Drawing.Point(345, 306);
            this.btn_bd.Name = "btn_bd";
            this.btn_bd.Size = new System.Drawing.Size(168, 41);
            this.btn_bd.TabIndex = 5;
            this.btn_bd.Text = "Bắt Đầu Thi";
            this.btn_bd.UseVisualStyleBackColor = true;
            this.btn_bd.Click += new System.EventHandler(this.btn_bd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.lb_kt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lb_tglm);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(455, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(355, 194);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin thi";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.monHocBindingSource1;
            this.comboBox1.DisplayMember = "MaMH";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(117, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "TenMH";
            // 
            // monHocBindingSource1
            // 
            this.monHocBindingSource1.DataMember = "MonHoc";
            this.monHocBindingSource1.DataSource = this.uD_THITRACNGHIEM;
            // 
            // lb_kt
            // 
            this.lb_kt.AutoSize = true;
            this.lb_kt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kt.Location = new System.Drawing.Point(78, 145);
            this.lb_kt.Name = "lb_kt";
            this.lb_kt.Size = new System.Drawing.Size(24, 17);
            this.lb_kt.TabIndex = 5;
            this.lb_kt.Text = "__";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Kỳ thi :";
            // 
            // lb_tglm
            // 
            this.lb_tglm.AutoSize = true;
            this.lb_tglm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tglm.Location = new System.Drawing.Point(164, 97);
            this.lb_tglm.Name = "lb_tglm";
            this.lb_tglm.Size = new System.Drawing.Size(24, 17);
            this.lb_tglm.TabIndex = 3;
            this.lb_tglm.Text = "__";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Thời gian làm bài thi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Môn thi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ Tên :";
            // 
            // lb_ns
            // 
            this.lb_ns.AutoSize = true;
            this.lb_ns.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ns.Location = new System.Drawing.Point(114, 145);
            this.lb_ns.Name = "lb_ns";
            this.lb_ns.Size = new System.Drawing.Size(24, 17);
            this.lb_ns.TabIndex = 5;
            this.lb_ns.Text = "__";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Ngày sinh :";
            // 
            // lb_ml
            // 
            this.lb_ml.AutoSize = true;
            this.lb_ml.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ml.Location = new System.Drawing.Point(114, 97);
            this.lb_ml.Name = "lb_ml";
            this.lb_ml.Size = new System.Drawing.Size(24, 17);
            this.lb_ml.TabIndex = 3;
            this.lb_ml.Text = "__";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Lớp : ";
            // 
            // lb_ht
            // 
            this.lb_ht.AutoSize = true;
            this.lb_ht.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ht.Location = new System.Drawing.Point(114, 49);
            this.lb_ht.Name = "lb_ht";
            this.lb_ht.Size = new System.Drawing.Size(24, 17);
            this.lb_ht.TabIndex = 1;
            this.lb_ht.Text = "__";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_ns);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_ml);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lb_ht);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 194);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // uDTHITRACNGHIEMBindingSource
            // 
            this.uDTHITRACNGHIEMBindingSource.DataSource = this.uD_THITRACNGHIEM;
            this.uDTHITRACNGHIEMBindingSource.Position = 0;
            // 
            // ThongtinTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 410);
            this.Controls.Add(this.btn_bd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThongtinTS";
            this.Text = "ThongtinTS";
            this.Load += new System.EventHandler(this.ThongtinTS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uD_THITRACNGHIEM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uDTHITRACNGHIEMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DAL.UD_THITRACNGHIEMTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private DAL.UD_THITRACNGHIEM uD_THITRACNGHIEM;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private System.Windows.Forms.Button btn_bd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lb_kt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_tglm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_ns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_ml;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_ht;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource monHocBindingSource1;
        private System.Windows.Forms.BindingSource uDTHITRACNGHIEMBindingSource;
    }
}