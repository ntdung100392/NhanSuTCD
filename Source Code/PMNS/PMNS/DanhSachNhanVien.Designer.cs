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
            this.dataGridDanhSachNV = new System.Windows.Forms.DataGridView();
            this.cbPhongBan = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
//9<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
//=======
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
//>>>>>>> e6d38c393c07c5c40f1be67b15026494bf4df535
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachNV)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDanhSachNV
            // 
            this.dataGridDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDanhSachNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridDanhSachNV.Location = new System.Drawing.Point(0, 44);
            this.dataGridDanhSachNV.MultiSelect = false;
            this.dataGridDanhSachNV.Name = "dataGridDanhSachNV";
            this.dataGridDanhSachNV.ReadOnly = true;
            this.dataGridDanhSachNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDanhSachNV.Size = new System.Drawing.Size(1184, 467);
            this.dataGridDanhSachNV.TabIndex = 0;
            this.dataGridDanhSachNV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDanhSachNV_CellDoubleClick);
            // 
            // cbPhongBan
            // 
            this.cbPhongBan.FormattingEnabled = true;
            this.cbPhongBan.Location = new System.Drawing.Point(78, 12);
            this.cbPhongBan.Name = "cbPhongBan";
            this.cbPhongBan.Size = new System.Drawing.Size(181, 21);
            this.cbPhongBan.TabIndex = 108;
            this.cbPhongBan.SelectedIndexChanged += new System.EventHandler(this.cbPhongBan_SelectedIndexChanged);
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
//<<<<<<< HEAD
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(862, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 109;
            this.button1.Text = "Xem toàn bộ thông tin";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1026, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 110;
            this.button2.Text = "Chỉnh sửa thông tin";
            this.button2.UseVisualStyleBackColor = true;
//=======
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(382, 12);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(160, 20);
            this.txtMaNhanVien.TabIndex = 110;
            this.txtMaNhanVien.TextChanged += new System.EventHandler(this.txtMaNhanVien_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 109;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(668, 12);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(160, 20);
            this.txtTenNhanVien.TabIndex = 112;
            this.txtTenNhanVien.TextChanged += new System.EventHandler(this.txtTenNhanVien_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 111;
            this.label2.Text = "Tên Nhân Viên";
//>>>>>>> e6d38c393c07c5c40f1be67b15026494bf4df535
            // 
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
//<<<<<<< HEAD
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
//=======
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.label1);
//>>>>>>> e6d38c393c07c5c40f1be67b15026494bf4df535
            this.Controls.Add(this.cbPhongBan);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.dataGridDanhSachNV);
            this.Name = "DanhSachNhanVien";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.DanhSachNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDanhSachNV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridDanhSachNV;
        private System.Windows.Forms.ComboBox cbPhongBan;
        private System.Windows.Forms.Label label25;
//<<<<<<< HEAD
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
//=======
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label2;
//>>>>>>> e6d38c393c07c5c40f1be67b15026494bf4df535

    }
}