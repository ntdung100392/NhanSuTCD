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
    public partial class ChinhSuaThongTin : Form
    {
        public ChinhSuaThongTin()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        private void ChinhSuaThongTin_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from _ThongTinNguoiLaoDong",Connection.cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
