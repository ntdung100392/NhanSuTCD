namespace PMNS
{
    partial class QuanLyChucVu
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
            this.txtChucVu = new System.Windows.Forms.TextBox();
            this.txtMaChucVu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaChucVu = new System.Windows.Forms.Button();
            this.btnThemChucVu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridChucVu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtChucVu);
            this.groupBox1.Controls.Add(this.txtMaChucVu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSuaChucVu);
            this.groupBox1.Controls.Add(this.btnThemChucVu);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtChucVu
            // 
            this.txtChucVu.Location = new System.Drawing.Point(123, 58);
            this.txtChucVu.Name = "txtChucVu";
            this.txtChucVu.Size = new System.Drawing.Size(129, 20);
            this.txtChucVu.TabIndex = 5;
            // 
            // txtMaChucVu
            // 
            this.txtMaChucVu.Location = new System.Drawing.Point(123, 27);
            this.txtMaChucVu.Name = "txtMaChucVu";
            this.txtMaChucVu.Size = new System.Drawing.Size(129, 20);
            this.txtMaChucVu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chức Vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Chức Vụ";
            // 
            // btnSuaChucVu
            // 
            this.btnSuaChucVu.Location = new System.Drawing.Point(258, 109);
            this.btnSuaChucVu.Name = "btnSuaChucVu";
            this.btnSuaChucVu.Size = new System.Drawing.Size(75, 23);
            this.btnSuaChucVu.TabIndex = 1;
            this.btnSuaChucVu.Text = "Sửa";
            this.btnSuaChucVu.UseVisualStyleBackColor = true;
            this.btnSuaChucVu.Click += new System.EventHandler(this.btnSuaChucVu_Click);
            // 
            // btnThemChucVu
            // 
            this.btnThemChucVu.Location = new System.Drawing.Point(177, 109);
            this.btnThemChucVu.Name = "btnThemChucVu";
            this.btnThemChucVu.Size = new System.Drawing.Size(75, 23);
            this.btnThemChucVu.TabIndex = 0;
            this.btnThemChucVu.Text = "Thêm";
            this.btnThemChucVu.UseVisualStyleBackColor = true;
            this.btnThemChucVu.Click += new System.EventHandler(this.btnThemChucVu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridChucVu);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chức vụ";
            // 
            // dataGridChucVu
            // 
            this.dataGridChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridChucVu.Location = new System.Drawing.Point(3, 16);
            this.dataGridChucVu.MultiSelect = false;
            this.dataGridChucVu.Name = "dataGridChucVu";
            this.dataGridChucVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridChucVu.Size = new System.Drawing.Size(333, 151);
            this.dataGridChucVu.TabIndex = 0;
            this.dataGridChucVu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridChucVu_CellClick);
            // 
            // QuanLyChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyChucVu";
            this.Text = "Chức Vụ";
            this.Load += new System.EventHandler(this.QuanLyChucVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridChucVu;
        private System.Windows.Forms.TextBox txtChucVu;
        private System.Windows.Forms.TextBox txtMaChucVu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaChucVu;
        private System.Windows.Forms.Button btnThemChucVu;
    }
}