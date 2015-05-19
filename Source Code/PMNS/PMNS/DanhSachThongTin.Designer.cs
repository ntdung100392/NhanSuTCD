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
            this.gridviewTDDDBNTV = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.datetimeNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtNamThucHien = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLenh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTDDDBNTV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridviewTDDDBNTV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // gridviewTDDDBNTV
            // 
            this.gridviewTDDDBNTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewTDDDBNTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridviewTDDDBNTV.Location = new System.Drawing.Point(3, 16);
            this.gridviewTDDDBNTV.Name = "gridviewTDDDBNTV";
            this.gridviewTDDDBNTV.Size = new System.Drawing.Size(709, 211);
            this.gridviewTDDDBNTV.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnTim);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.datetimeNgaySinh);
            this.groupBox2.Controls.Add(this.txtNamThucHien);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtLenh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 234);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "abc";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(153, 122);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(126, 20);
            this.txtTenNV.TabIndex = 113;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 111;
            this.label4.Text = "Tên NV";
            // 
            // datetimeNgaySinh
            // 
            this.datetimeNgaySinh.Location = new System.Drawing.Point(264, 80);
            this.datetimeNgaySinh.Name = "datetimeNgaySinh";
            this.datetimeNgaySinh.Size = new System.Drawing.Size(15, 20);
            this.datetimeNgaySinh.TabIndex = 108;
            // 
            // txtNamThucHien
            // 
            this.txtNamThucHien.Location = new System.Drawing.Point(153, 80);
            this.txtNamThucHien.Mask = "00/00/0000";
            this.txtNamThucHien.Name = "txtNamThucHien";
            this.txtNamThucHien.Size = new System.Drawing.Size(126, 20);
            this.txtNamThucHien.TabIndex = 109;
            this.txtNamThucHien.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm Thực Hiện";
            // 
            // txtLenh
            // 
            this.txtLenh.Location = new System.Drawing.Point(153, 44);
            this.txtLenh.Name = "txtLenh";
            this.txtLenh.Size = new System.Drawing.Size(126, 20);
            this.txtLenh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lệnh (nội Dung)";
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(426, 193);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 114;
            this.btnTim.Text = "Tìm ";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(527, 193);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 115;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // DanhSachThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DanhSachThongTin";
            this.Text = "Danh Sách Thông Tin";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTDDDBNTV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridviewTDDDBNTV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker datetimeNgaySinh;
        private System.Windows.Forms.MaskedTextBox txtNamThucHien;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTim;
    }
}