namespace UD_THITRACNGHIEM.GUI
{
    partial class QL_TS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thiSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uD_THITRACNGHIEM = new UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEM();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtxt_NgaySinh = new System.Windows.Forms.MaskedTextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_malop = new System.Windows.Forms.TextBox();
            this.txt_tendn = new System.Windows.Forms.TextBox();
            this.txt_tents = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thiSinhTableAdapter = new UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters.ThiSinhTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thiSinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uD_THITRACNGHIEM)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTSDataGridViewTextBoxColumn,
            this.maLopDataGridViewTextBoxColumn,
            this.tenTSDataGridViewTextBoxColumn,
            this.tenDNDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.thiSinhBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 356);
            this.dataGridView1.TabIndex = 5;
            // 
            // maTSDataGridViewTextBoxColumn
            // 
            this.maTSDataGridViewTextBoxColumn.DataPropertyName = "MaTS";
            this.maTSDataGridViewTextBoxColumn.HeaderText = "MaTS";
            this.maTSDataGridViewTextBoxColumn.Name = "maTSDataGridViewTextBoxColumn";
            // 
            // maLopDataGridViewTextBoxColumn
            // 
            this.maLopDataGridViewTextBoxColumn.DataPropertyName = "MaLop";
            this.maLopDataGridViewTextBoxColumn.HeaderText = "MaLop";
            this.maLopDataGridViewTextBoxColumn.Name = "maLopDataGridViewTextBoxColumn";
            // 
            // tenTSDataGridViewTextBoxColumn
            // 
            this.tenTSDataGridViewTextBoxColumn.DataPropertyName = "TenTS";
            this.tenTSDataGridViewTextBoxColumn.HeaderText = "TenTS";
            this.tenTSDataGridViewTextBoxColumn.Name = "tenTSDataGridViewTextBoxColumn";
            // 
            // tenDNDataGridViewTextBoxColumn
            // 
            this.tenDNDataGridViewTextBoxColumn.DataPropertyName = "TenDN";
            this.tenDNDataGridViewTextBoxColumn.HeaderText = "TenDN";
            this.tenDNDataGridViewTextBoxColumn.Name = "tenDNDataGridViewTextBoxColumn";
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            // 
            // thiSinhBindingSource
            // 
            this.thiSinhBindingSource.DataMember = "ThiSinh";
            this.thiSinhBindingSource.DataSource = this.uD_THITRACNGHIEM;
            // 
            // uD_THITRACNGHIEM
            // 
            this.uD_THITRACNGHIEM.DataSetName = "UD_THITRACNGHIEM";
            this.uD_THITRACNGHIEM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.mtxt_NgaySinh);
            this.panel2.Controls.Add(this.button12);
            this.panel2.Controls.Add(this.btn_sua);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.txt_malop);
            this.panel2.Controls.Add(this.txt_tendn);
            this.panel2.Controls.Add(this.txt_tents);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1053, 142);
            this.panel2.TabIndex = 4;
            // 
            // mtxt_NgaySinh
            // 
            this.mtxt_NgaySinh.Location = new System.Drawing.Point(109, 51);
            this.mtxt_NgaySinh.Mask = "00/00/0000";
            this.mtxt_NgaySinh.Name = "mtxt_NgaySinh";
            this.mtxt_NgaySinh.Size = new System.Drawing.Size(149, 22);
            this.mtxt_NgaySinh.TabIndex = 7;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightBlue;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.ForeColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(944, 56);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(101, 26);
            this.button12.TabIndex = 15;
            this.button12.Text = "Clear ";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.LightBlue;
            this.btn_sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sua.ForeColor = System.Drawing.Color.Black;
            this.btn_sua.Location = new System.Drawing.Point(944, 11);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(101, 26);
            this.btn_sua.TabIndex = 13;
            this.btn_sua.Text = "Sửa ";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightBlue;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.Color.Black;
            this.button10.Location = new System.Drawing.Point(857, 101);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(132, 26);
            this.button10.TabIndex = 14;
            this.button10.Text = "Thêm tài khoản";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.LightBlue;
            this.btn_xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_xoa.ForeColor = System.Drawing.Color.Black;
            this.btn_xoa.Location = new System.Drawing.Point(805, 56);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(101, 26);
            this.btn_xoa.TabIndex = 13;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.LightBlue;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_them.ForeColor = System.Drawing.Color.Black;
            this.btn_them.Location = new System.Drawing.Point(805, 13);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(101, 26);
            this.btn_them.TabIndex = 12;
            this.btn_them.Text = "Thêm ";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_malop
            // 
            this.txt_malop.Location = new System.Drawing.Point(477, 88);
            this.txt_malop.Name = "txt_malop";
            this.txt_malop.Size = new System.Drawing.Size(237, 22);
            this.txt_malop.TabIndex = 11;
            // 
            // txt_tendn
            // 
            this.txt_tendn.Location = new System.Drawing.Point(507, 48);
            this.txt_tendn.Name = "txt_tendn";
            this.txt_tendn.Size = new System.Drawing.Size(207, 22);
            this.txt_tendn.TabIndex = 10;
            // 
            // txt_tents
            // 
            this.txt_tents.Location = new System.Drawing.Point(477, 13);
            this.txt_tents.Name = "txt_tents";
            this.txt_tents.Size = new System.Drawing.Size(237, 22);
            this.txt_tents.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(388, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Mã Lớp :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(388, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tên đăng nhập :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(388, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Họ và Tên:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(22, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày Sinh :";
            // 
            // thiSinhTableAdapter
            // 
            this.thiSinhTableAdapter.ClearBeforeFill = true;
            // 
            // QL_TS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 498);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Name = "QL_TS";
            this.Text = "QL_TS";
            this.Load += new System.EventHandler(this.QL_TS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thiSinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uD_THITRACNGHIEM)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox txt_malop;
        private System.Windows.Forms.TextBox txt_tendn;
        private System.Windows.Forms.TextBox txt_tents;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DAL.UD_THITRACNGHIEM uD_THITRACNGHIEM;
        private System.Windows.Forms.BindingSource thiSinhBindingSource;
        private DAL.UD_THITRACNGHIEMTableAdapters.ThiSinhTableAdapter thiSinhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.MaskedTextBox mtxt_NgaySinh;



    }
}