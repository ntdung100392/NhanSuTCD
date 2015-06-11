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
            this.dataGridKiemTraHDLD = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKiemTraHDLD)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridKiemTraHDLD
            // 
            this.dataGridKiemTraHDLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridKiemTraHDLD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridKiemTraHDLD.Location = new System.Drawing.Point(0, 0);
            this.dataGridKiemTraHDLD.Name = "dataGridKiemTraHDLD";
            this.dataGridKiemTraHDLD.Size = new System.Drawing.Size(883, 283);
            this.dataGridKiemTraHDLD.TabIndex = 0;
            // 
            // KiemTraHDLD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 283);
            this.Controls.Add(this.dataGridKiemTraHDLD);
            this.Name = "KiemTraHDLD";
            this.Text = "Kiểm Tra Hợp Đồng Lao Động";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridKiemTraHDLD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridKiemTraHDLD;
    }
}