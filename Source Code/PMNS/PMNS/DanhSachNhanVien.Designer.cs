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
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 511);
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

    }
}