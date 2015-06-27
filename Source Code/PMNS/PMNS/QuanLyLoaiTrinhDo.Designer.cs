namespace PMNS
{
    partial class QuanLyLoaiTrinhDo
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
            this.dataGridTrinhDo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTrinhDo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuaTrinhDo = new System.Windows.Forms.Button();
            this.btnThemTrinhDo = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrinhDo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridTrinhDo);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 150);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách loại trình độ";
            // 
            // dataGridTrinhDo
            // 
            this.dataGridTrinhDo.AllowUserToOrderColumns = true;
            this.dataGridTrinhDo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTrinhDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridTrinhDo.Location = new System.Drawing.Point(3, 16);
            this.dataGridTrinhDo.MultiSelect = false;
            this.dataGridTrinhDo.Name = "dataGridTrinhDo";
            this.dataGridTrinhDo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridTrinhDo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridTrinhDo.Size = new System.Drawing.Size(348, 131);
            this.dataGridTrinhDo.TabIndex = 0;
            this.dataGridTrinhDo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridTrinhDo_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTrinhDo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSuaTrinhDo);
            this.groupBox1.Controls.Add(this.btnThemTrinhDo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // txtTrinhDo
            // 
            this.txtTrinhDo.Location = new System.Drawing.Point(123, 33);
            this.txtTrinhDo.Name = "txtTrinhDo";
            this.txtTrinhDo.Size = new System.Drawing.Size(129, 20);
            this.txtTrinhDo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Trình Độ";
            // 
            // btnSuaTrinhDo
            // 
            this.btnSuaTrinhDo.Location = new System.Drawing.Point(258, 59);
            this.btnSuaTrinhDo.Name = "btnSuaTrinhDo";
            this.btnSuaTrinhDo.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTrinhDo.TabIndex = 1;
            this.btnSuaTrinhDo.Text = "Sửa";
            this.btnSuaTrinhDo.UseVisualStyleBackColor = true;
            this.btnSuaTrinhDo.Click += new System.EventHandler(this.btnSuaTrinhDo_Click);
            // 
            // btnThemTrinhDo
            // 
            this.btnThemTrinhDo.Location = new System.Drawing.Point(177, 59);
            this.btnThemTrinhDo.Name = "btnThemTrinhDo";
            this.btnThemTrinhDo.Size = new System.Drawing.Size(75, 23);
            this.btnThemTrinhDo.TabIndex = 0;
            this.btnThemTrinhDo.Text = "Thêm";
            this.btnThemTrinhDo.UseVisualStyleBackColor = true;
            this.btnThemTrinhDo.Click += new System.EventHandler(this.btnThemTrinhDo_Click);
            // 
            // QuanLyLoaiTrinhDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 246);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyLoaiTrinhDo";
            this.Text = "QuanLyLoaiTrinhDo";
            this.Load += new System.EventHandler(this.QuanLyLoaiTrinhDo_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTrinhDo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridTrinhDo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTrinhDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuaTrinhDo;
        private System.Windows.Forms.Button btnThemTrinhDo;
    }
}