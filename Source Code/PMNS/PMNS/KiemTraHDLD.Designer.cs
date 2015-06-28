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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamBatDau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHDLD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridHDLD
            // 
            this.dataGridHDLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHDLD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridHDLD.Location = new System.Drawing.Point(3, 17);
            this.dataGridHDLD.Name = "dataGridHDLD";
            this.dataGridHDLD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridHDLD.Size = new System.Drawing.Size(892, 360);
            this.dataGridHDLD.TabIndex = 0;
            this.dataGridHDLD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHDLD_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridHDLD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 380);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách";
            // 
            // btnInBieu
            // 
            this.btnInBieu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBieu.Location = new System.Drawing.Point(649, 82);
            this.btnInBieu.Name = "btnInBieu";
            this.btnInBieu.Size = new System.Drawing.Size(75, 27);
            this.btnInBieu.TabIndex = 2;
            this.btnInBieu.Text = "In Biểu";
            this.btnInBieu.UseVisualStyleBackColor = true;
            this.btnInBieu.Click += new System.EventHandler(this.btnInBieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(811, 82);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 27);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(730, 82);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 27);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(304, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 15);
            this.label9.TabIndex = 109;
            this.label9.Text = "Năm (Năm bắt đầu )";
            // 
            // cbLoaiHopDong
            // 
            this.cbLoaiHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiHopDong.FormattingEnabled = true;
            this.cbLoaiHopDong.Location = new System.Drawing.Point(416, 22);
            this.cbLoaiHopDong.Name = "cbLoaiHopDong";
            this.cbLoaiHopDong.Size = new System.Drawing.Size(138, 23);
            this.cbLoaiHopDong.TabIndex = 110;
            this.cbLoaiHopDong.SelectedIndexChanged += new System.EventHandler(this.cbLoaiHopDong_SelectedIndexChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTenNV.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTenNV.Location = new System.Drawing.Point(100, 69);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(126, 21);
            this.txtTenNV.TabIndex = 116;
            this.txtTenNV.TextChanged += new System.EventHandler(this.txtTenNV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 115;
            this.label2.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 114;
            this.label1.Text = "Mã NV";
            // 
            // txtMaNv
            // 
            this.txtMaNv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtMaNv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMaNv.Location = new System.Drawing.Point(100, 25);
            this.txtMaNv.Name = "txtMaNv";
            this.txtMaNv.Size = new System.Drawing.Size(126, 21);
            this.txtMaNv.TabIndex = 113;
            this.txtMaNv.TextChanged += new System.EventHandler(this.txtMaNv_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 109;
            this.label3.Text = "Thời hạn";
            // 
            // txtNamBatDau
            // 
            this.txtNamBatDau.Location = new System.Drawing.Point(416, 68);
            this.txtNamBatDau.Name = "txtNamBatDau";
            this.txtNamBatDau.Size = new System.Drawing.Size(138, 21);
            this.txtNamBatDau.TabIndex = 119;
            this.txtNamBatDau.TextChanged += new System.EventHandler(this.txtNamBatDau_TextChanged);
            this.txtNamBatDau.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNamBatDau_KeyPress);
            // 
            // KiemTraHDLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 495);
            this.Controls.Add(this.txtNamBatDau);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaNv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbLoaiHopDong);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnInBieu);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamBatDau;
    }
}