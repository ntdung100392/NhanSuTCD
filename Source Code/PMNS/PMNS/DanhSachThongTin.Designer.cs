﻿namespace PMNS
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
            this.comboNam = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPhongBan = new System.Windows.Forms.ComboBox();
            this.comboThang = new System.Windows.Forms.ComboBox();
            this.comboQuy = new System.Windows.Forms.ComboBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLenh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnInBieu = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThongTin)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridThongTin);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // dataGridThongTin
            // 
            this.dataGridThongTin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridThongTin.Location = new System.Drawing.Point(3, 20);
            this.dataGridThongTin.Name = "dataGridThongTin";
            this.dataGridThongTin.ReadOnly = true;
            this.dataGridThongTin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridThongTin.Size = new System.Drawing.Size(709, 242);
            this.dataGridThongTin.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboNam);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBoxPhongBan);
            this.groupBox2.Controls.Add(this.comboThang);
            this.groupBox2.Controls.Add(this.comboQuy);
            this.groupBox2.Controls.Add(this.txtTenNV);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLenh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 115);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm Kiếm";
            // 
            // comboNam
            // 
            this.comboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNam.FormattingEnabled = true;
            this.comboNam.Location = new System.Drawing.Point(293, 29);
            this.comboNam.Name = "comboNam";
            this.comboNam.Size = new System.Drawing.Size(95, 23);
            this.comboNam.TabIndex = 126;
            this.comboNam.SelectedIndexChanged += new System.EventHandler(this.comboNam_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(409, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 15);
            this.label6.TabIndex = 125;
            this.label6.Text = "Phòng Ban";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(431, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 124;
            this.label5.Text = "Tháng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 123;
            this.label3.Text = "Quý";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 122;
            this.label2.Text = "Năm";
            // 
            // comboBoxPhongBan
            // 
            this.comboBoxPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPhongBan.FormattingEnabled = true;
            this.comboBoxPhongBan.Location = new System.Drawing.Point(484, 75);
            this.comboBoxPhongBan.Name = "comboBoxPhongBan";
            this.comboBoxPhongBan.Size = new System.Drawing.Size(219, 23);
            this.comboBoxPhongBan.TabIndex = 121;
            this.comboBoxPhongBan.SelectedIndexChanged += new System.EventHandler(this.comboBoxPhongBan_SelectedIndexChanged);
            // 
            // comboThang
            // 
            this.comboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboThang.FormattingEnabled = true;
            this.comboThang.Location = new System.Drawing.Point(484, 29);
            this.comboThang.Name = "comboThang";
            this.comboThang.Size = new System.Drawing.Size(95, 23);
            this.comboThang.TabIndex = 117;
            this.comboThang.SelectedIndexChanged += new System.EventHandler(this.comboThang_SelectedIndexChanged);
            // 
            // comboQuy
            // 
            this.comboQuy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuy.FormattingEnabled = true;
            this.comboQuy.Location = new System.Drawing.Point(293, 76);
            this.comboQuy.Name = "comboQuy";
            this.comboQuy.Size = new System.Drawing.Size(95, 23);
            this.comboQuy.TabIndex = 117;
            this.comboQuy.SelectedIndexChanged += new System.EventHandler(this.comboQuy_SelectedIndexChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTenNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenNV.Location = new System.Drawing.Point(95, 77);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(126, 21);
            this.txtTenNV.TabIndex = 113;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 111;
            this.label4.Text = "Tên NV";
            // 
            // txtLenh
            // 
            this.txtLenh.Location = new System.Drawing.Point(95, 31);
            this.txtLenh.Name = "txtLenh";
            this.txtLenh.Size = new System.Drawing.Size(126, 21);
            this.txtLenh.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lệnh (nội Dung)";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(628, 122);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 115;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInBieu
            // 
            this.btnInBieu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBieu.Location = new System.Drawing.Point(547, 122);
            this.btnInBieu.Name = "btnInBieu";
            this.btnInBieu.Size = new System.Drawing.Size(75, 27);
            this.btnInBieu.TabIndex = 118;
            this.btnInBieu.Text = "In Biểu";
            this.btnInBieu.UseVisualStyleBackColor = true;
            this.btnInBieu.Click += new System.EventHandler(this.btnInBieu_Click);
            // 
            // DanhSachThongTin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnInBieu);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Button btnInBieu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboNam;
    }
}