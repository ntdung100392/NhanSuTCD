namespace PMNS
{
    partial class KiemTraHDLD
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
            this.dataGridHDLD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInBieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbLoaiHopDong = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNv = new System.Windows.Forms.TextBox();
            this.cBoxNamBatDau = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCoThoiHan = new System.Windows.Forms.RadioButton();
            this.rbKhongThoiHan = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHDLD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridHDLD
            // 
            this.dataGridHDLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHDLD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHDLD.Location = new System.Drawing.Point(3, 16);
            this.dataGridHDLD.Name = "dataGridHDLD";
            this.dataGridHDLD.Size = new System.Drawing.Size(892, 310);
            this.dataGridHDLD.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridHDLD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 329);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // btnInBieu
            // 
            this.btnInBieu.Location = new System.Drawing.Point(649, 66);
            this.btnInBieu.Name = "btnInBieu";
            this.btnInBieu.Size = new System.Drawing.Size(75, 23);
            this.btnInBieu.TabIndex = 2;
            this.btnInBieu.Text = "In Biểu";
            this.btnInBieu.UseVisualStyleBackColor = true;
            this.btnInBieu.Click += new System.EventHandler(this.btnInBieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(811, 66);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(730, 66);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(614, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 109;
            this.label9.Text = "Năm (Năm bắt đầu )";
            // 
            // cbLoaiHopDong
            // 
            this.cbLoaiHopDong.FormattingEnabled = true;
            this.cbLoaiHopDong.Location = new System.Drawing.Point(371, 57);
            this.cbLoaiHopDong.Name = "cbLoaiHopDong";
            this.cbLoaiHopDong.Size = new System.Drawing.Size(138, 21);
            this.cbLoaiHopDong.TabIndex = 110;
            this.cbLoaiHopDong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHopDong_SelectedIndexChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(100, 57);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(126, 20);
            this.txtTenNV.TabIndex = 116;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 114;
            this.label1.Text = "Mã NV";
            // 
            // txtMaNv
            // 
            this.txtMaNv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaNv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaNv.Location = new System.Drawing.Point(100, 19);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(126, 20);
            this.txtMaNv.TabIndex = 113;
            this.txtMaNv.TextChanged += new System.EventHandler(this.txtMaNv_TextChanged);
            // 
            // cBoxNamBatDau
            // 
            this.cBoxNamBatDau.FormattingEnabled = true;
            this.cBoxNamBatDau.Location = new System.Drawing.Point(720, 18);
            this.cBoxNamBatDau.Name = "cBoxNamBatDau";
            this.cBoxNamBatDau.Size = new System.Drawing.Size(116, 21);
            this.cBoxNamBatDau.TabIndex = 110;
            this.cBoxNamBatDau.SelectedIndexChanged += new System.EventHandler(this.cBoxNamBatDau_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "Thời hạn";
            // 
            // rbCoThoiHan
            // 
            this.rbCoThoiHan.AutoSize = true;
            this.rbCoThoiHan.Location = new System.Drawing.Point(319, 19);
            this.rbCoThoiHan.Name = "rbCoThoiHan";
            this.rbCoThoiHan.Size = new System.Drawing.Size(85, 17);
            this.rbCoThoiHan.TabIndex = 117;
            this.rbCoThoiHan.TabStop = true;
            this.rbCoThoiHan.Text = "Có Thời Hạn";
            this.rbCoThoiHan.UseVisualStyleBackColor = true;
            this.rbCoThoiHan.CheckedChanged += new System.EventHandler(this.rbCoThoiHan_CheckedChanged);
            // 
            // rbKhongThoiHan
            // 
            this.rbKhongThoiHan.AutoSize = true;
            this.rbKhongThoiHan.Location = new System.Drawing.Point(410, 19);
            this.rbKhongThoiHan.Name = "rbKhongThoiHan";
            this.rbKhongThoiHan.Size = new System.Drawing.Size(103, 17);
            this.rbKhongThoiHan.TabIndex = 118;
            this.rbKhongThoiHan.TabStop = true;
            this.rbKhongThoiHan.Text = "Không Thời Hạn";
            this.rbKhongThoiHan.UseVisualStyleBackColor = true;
            this.rbKhongThoiHan.CheckedChanged += new System.EventHandler(this.rbKhongThoiHan_CheckedChanged);
            // 
            // KiemTraHDLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 429);
            this.Controls.Add(this.rbKhongThoiHan);
            this.Controls.Add(this.rbCoThoiHan);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaNv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cBoxNamBatDau);
            this.Controls.Add(this.cbLoaiHopDong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnInBieu);
            this.Controls.Add(this.groupBox1);
            this.Name = "KiemTraHDLD";
            this.Text = "Kiểm Tra Hợp Đồng Lao Động";
            this.Load += new System.EventHandler(this.KiemTraHDLD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHDLD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHDLD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInBieu;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbLoaiHopDong;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNv;
        private System.Windows.Forms.ComboBox cBoxNamBatDau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCoThoiHan;
        private System.Windows.Forms.RadioButton rbKhongThoiHan;
    }
}