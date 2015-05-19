namespace PMNS
{
    partial class QuanLyBienChe
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
            this.txtBienChe = new System.Windows.Forms.TextBox();
            this.txtMaBienChe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaBienChe = new System.Windows.Forms.Button();
            this.btnThemBienChe = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridBienChe = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBienChe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBienChe);
            this.groupBox1.Controls.Add(this.txtMaBienChe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSuaBienChe);
            this.groupBox1.Controls.Add(this.btnThemBienChe);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtBienChe
            // 
            this.txtBienChe.Location = new System.Drawing.Point(123, 58);
            this.txtBienChe.Name = "txtBienChe";
            this.txtBienChe.Size = new System.Drawing.Size(129, 20);
            this.txtBienChe.TabIndex = 5;
            // 
            // txtMaBienChe
            // 
            this.txtMaBienChe.Location = new System.Drawing.Point(123, 27);
            this.txtMaBienChe.Name = "txtMaBienChe";
            this.txtMaBienChe.Size = new System.Drawing.Size(129, 20);
            this.txtMaBienChe.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Biên Chế";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Biên Chế";
            // 
            // btnSuaBienChe
            // 
            this.btnSuaBienChe.Location = new System.Drawing.Point(258, 109);
            this.btnSuaBienChe.Name = "btnSuaBienChe";
            this.btnSuaBienChe.Size = new System.Drawing.Size(75, 23);
            this.btnSuaBienChe.TabIndex = 1;
            this.btnSuaBienChe.Text = "Sửa";
            this.btnSuaBienChe.UseVisualStyleBackColor = true;
            this.btnSuaBienChe.Click += new System.EventHandler(this.btnSuaBienChe_Click);
            // 
            // btnThemBienChe
            // 
            this.btnThemBienChe.Location = new System.Drawing.Point(177, 109);
            this.btnThemBienChe.Name = "btnThemBienChe";
            this.btnThemBienChe.Size = new System.Drawing.Size(75, 23);
            this.btnThemBienChe.TabIndex = 0;
            this.btnThemBienChe.Text = "Thêm";
            this.btnThemBienChe.UseVisualStyleBackColor = true;
            this.btnThemBienChe.Click += new System.EventHandler(this.btnThemBienChe_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridBienChe);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách biên chế";
            // 
            // dataGridBienChe
            // 
            this.dataGridBienChe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBienChe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridBienChe.Location = new System.Drawing.Point(3, 16);
            this.dataGridBienChe.MultiSelect = false;
            this.dataGridBienChe.Name = "dataGridBienChe";
            this.dataGridBienChe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridBienChe.Size = new System.Drawing.Size(333, 151);
            this.dataGridBienChe.TabIndex = 0;
            this.dataGridBienChe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridBienChe_CellClick);
            // 
            // QuanLyBienChe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 314);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "QuanLyBienChe";
            this.Text = "Quản Lý Biên Chế";
            this.Load += new System.EventHandler(this.QuanLyBienChe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBienChe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBienChe;
        private System.Windows.Forms.TextBox txtMaBienChe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaBienChe;
        private System.Windows.Forms.Button btnThemBienChe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridBienChe;
    }
}