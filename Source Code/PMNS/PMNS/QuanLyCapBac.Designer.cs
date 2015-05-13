namespace PMNS
{
    partial class QuanLyCapBac
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridCapBac = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCapBac = new System.Windows.Forms.TextBox();
            this.txtMaCapBac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuaCapBac = new System.Windows.Forms.Button();
            this.btnThemCapBac = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCapBac)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridCapBac);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(339, 170);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chức vụ";
            // 
            // dataGridCapBac
            // 
            this.dataGridCapBac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCapBac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridCapBac.Location = new System.Drawing.Point(3, 16);
            this.dataGridCapBac.Name = "dataGridCapBac";
            this.dataGridCapBac.Size = new System.Drawing.Size(333, 151);
            this.dataGridCapBac.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCapBac);
            this.groupBox1.Controls.Add(this.txtMaCapBac);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSuaCapBac);
            this.groupBox1.Controls.Add(this.btnThemCapBac);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 138);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtCapBac
            // 
            this.txtCapBac.Location = new System.Drawing.Point(123, 58);
            this.txtCapBac.Name = "txtCapBac";
            this.txtCapBac.Size = new System.Drawing.Size(129, 20);
            this.txtCapBac.TabIndex = 5;
            // 
            // txtMaCapBac
            // 
            this.txtMaCapBac.Location = new System.Drawing.Point(123, 27);
            this.txtMaCapBac.Name = "txtMaCapBac";
            this.txtMaCapBac.Size = new System.Drawing.Size(129, 20);
            this.txtMaCapBac.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cấp Bậc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Cấp Bậc";
            // 
            // btnSuaCapBac
            // 
            this.btnSuaCapBac.Location = new System.Drawing.Point(258, 109);
            this.btnSuaCapBac.Name = "btnSuaCapBac";
            this.btnSuaCapBac.Size = new System.Drawing.Size(75, 23);
            this.btnSuaCapBac.TabIndex = 1;
            this.btnSuaCapBac.Text = "Sửa";
            this.btnSuaCapBac.UseVisualStyleBackColor = true;
            // 
            // btnThemCapBac
            // 
            this.btnThemCapBac.Location = new System.Drawing.Point(177, 109);
            this.btnThemCapBac.Name = "btnThemCapBac";
            this.btnThemCapBac.Size = new System.Drawing.Size(75, 23);
            this.btnThemCapBac.TabIndex = 0;
            this.btnThemCapBac.Text = "Thêm";
            this.btnThemCapBac.UseVisualStyleBackColor = true;
            // 
            // CapBac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 314);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CapBac";
            this.Text = "Cấp Bậc";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCapBac)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridCapBac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCapBac;
        private System.Windows.Forms.TextBox txtMaCapBac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuaCapBac;
        private System.Windows.Forms.Button btnThemCapBac;
    }
}