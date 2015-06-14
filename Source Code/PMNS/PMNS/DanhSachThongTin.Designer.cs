namespace PMNS
{
    partial class DanhSachThongTin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridThongTin = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.comboThang = new System.Windows.Forms.ComboBox();
            this.comboQuy = new System.Windows.Forms.ComboBox();
            this.txtNamThucHien = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLenh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInBieu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThongTin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridThongTin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // dataGridThongTin
            // 
            this.dataGridThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridThongTin.Location = new System.Drawing.Point(3, 16);
            this.dataGridThongTin.Name = "dataGridThongTin";
            this.dataGridThongTin.Size = new System.Drawing.Size(709, 211);
            this.dataGridThongTin.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxPhongBan);
            this.groupBox2.Controls.Add(this.comboThang);
            this.groupBox2.Controls.Add(this.comboQuy);
            this.groupBox2.Controls.Add(this.txtNamThucHien);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLenh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Location = new System.Drawing.Point(484, 65);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(219, 21);
            this.comboBoxPhongBan.TabIndex = 121;
            this.comboBoxPhongBan.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhongBan_SelectedIndexChanged);
            // 
            // comboThang
            // 
            this.comboThang.FormattingEnabled = true;
            this.comboThang.Location = new System.Drawing.Point(484, 25);
            this.comboThang.Name = "comboThang";
            this.comboThang.Size = new System.Drawing.Size(95, 21);
            this.comboThang.TabIndex = 117;
            this.comboThang.SelectedIndexChanged += new System.EventHandler(this.comboThang_SelectedIndexChanged);
            // 
            // comboQuy
            // 
            this.comboQuy.FormattingEnabled = true;
            this.comboQuy.Location = new System.Drawing.Point(293, 66);
            this.comboQuy.Name = "comboQuy";
            this.comboQuy.Size = new System.Drawing.Size(95, 21);
            this.comboQuy.TabIndex = 117;
            this.comboQuy.SelectedIndexChanged += new System.EventHandler(this.comboQuy_SelectedIndexChanged);
            // 
            // txtNamThucHien
            // 
            this.txtNamThucHien.Location = new System.Drawing.Point(293, 27);
            this.txtNamThucHien.Name = "txtNamThucHien";
            this.txtNamThucHien.Size = new System.Drawing.Size(95, 20);
            this.txtNamThucHien.TabIndex = 116;
            this.txtNamThucHien.TextChanged += new System.EventHandler(this.txtNamThucHien_TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTenNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenNV.Location = new System.Drawing.Point(95, 67);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(126, 20);
            this.txtTenNV.TabIndex = 113;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "Tên NV";
            // 
            // txtLenh
            // 
            this.txtLenh.Location = new System.Drawing.Point(95, 27);
            this.txtLenh.Name = "txtLenh";
            this.txtLenh.Size = new System.Drawing.Size(126, 20);
            this.txtLenh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lệnh (nội Dung)";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(628, 106);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 115;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInBieu
            // 
            this.btnInBieu.Location = new System.Drawing.Point(547, 106);
            this.btnInBieu.Name = "btnInBieu";
            this.btnInBieu.Size = new System.Drawing.Size(75, 23);
            this.btnInBieu.TabIndex = 118;
            this.btnInBieu.Text = "In Biểu";
            this.btnInBieu.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Năm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 123;
            this.label3.Text = "Quý";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 124;
            this.label5.Text = "Tháng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 125;
            this.label6.Text = "Phòng Ban";
            // 
            // DanhSachThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInBieu);
            this.Name = "DanhSachThongTin";
            this.Text = "Danh Sách Thông Tin";
            this.Load += new System.EventHandler(this.DanhSachThongTin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThongTin)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridThongTin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxPhongBan;
        private System.Windows.Forms.ComboBox comboThang;
        private System.Windows.Forms.ComboBox comboQuy;
        private System.Windows.Forms.TextBox txtNamThucHien;
        private System.Windows.Forms.Button btnInBieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}