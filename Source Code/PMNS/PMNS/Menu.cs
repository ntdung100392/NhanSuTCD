using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMNS
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }
        public void thêmNhânViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNV ThemNV = new ThemNV();
            ThemNV.Show();
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTin formChinhsưa = new ChinhSuaThongTin();
            formChinhsưa.Show();
        }



    }
}
