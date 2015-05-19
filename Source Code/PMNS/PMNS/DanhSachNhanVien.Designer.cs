namespace PMNS
{
    partial class DanhSachNhanVien
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gridDanhSachNV = new System.Windows.Forms.DataGridView();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.cbDoi = new System.Windows.Forms.ComboBox();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.cbLoaiTo = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDanhSachNV
            // 
            this.gridDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDanhSachNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridDanhSachNV.Location = new System.Drawing.Point(0, 44);
            this.gridDanhSachNV.Name = "gridDanhSachNV";
            this.gridDanhSachNV.Size = new System.Drawing.Size(1184, 467);
            this.gridDanhSachNV.TabIndex = 0;
            this.gridDanhSachNV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(521, 12);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(181, 21);
            this.cbTo.TabIndex = 111;
            // 
            // cbDoi
            // 
            this.cbDoi.FormattingEnabled = true;
            this.cbDoi.Location = new System.Drawing.Point(308, 12);
            this.cbDoi.Name = "cbDoi";
            this.cbDoi.Size = new System.Drawing.Size(181, 21);
            this.cbDoi.TabIndex = 110;
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.FormattingEnabled = true;
            this.cbPhongBan.Location = new System.Drawing.Point(78, 12);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(181, 21);
            this.cbPhongBan.TabIndex = 108;
            // 
            // cbLoaiTo
            // 
            this.cbLoaiTo.FormattingEnabled = true;
            this.cbLoaiTo.Location = new System.Drawing.Point(757, 12);
            this.cbLoaiTo.Name = "cbLoaiTo";
            this.cbLoaiTo.Size = new System.Drawing.Size(181, 21);
            this.cbLoaiTo.TabIndex = 109;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(708, 15);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(43, 13);
            this.label29.TabIndex = 107;
            this.label29.Text = "Loại Tổ";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(495, 15);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(20, 13);
            this.label23.TabIndex = 106;
            this.label23.Text = "Tổ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(279, 15);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(23, 13);
            this.label24.TabIndex = 105;
            this.label24.Text = "Đội";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(12, 15);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(60, 13);
            this.label25.TabIndex = 104;
            this.label25.Text = "Phòng Ban";
            // 
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbDoi);
            this.Controls.Add(this.cbPhongBan);
            this.Controls.Add(this.cbLoaiTo);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.gridDanhSachNV);
            this.Name = "DanhSachNhanVien";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.ChinhSuaThongTin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView gridDanhSachNV;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.ComboBox cbDoi;
        private System.Windows.Forms.ComboBox cbPhongBan;
        private System.Windows.Forms.ComboBox cbLoaiTo;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;

    }
}