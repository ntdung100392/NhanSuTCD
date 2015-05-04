using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PMNS
{
    public partial class Dang_nhap : Form
    {
        public Dang_nhap()
        {
            InitializeComponent();
        }

        private void Dang_nhap_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxX1;
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            Dang_nhap.ActiveForm.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (textBoxX1.Text == "" || textBoxX2.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connection.moketnoi();
                SqlCommand cmd = new SqlCommand("Select * from _ThongTinNguoiLaoDong where _user = @_user and = _Password = @_Password", Connection.cnn);
                cmd.Parameters.AddWithValue("@_user", textBoxX1.Text);
                cmd.Parameters.AddWithValue("@_Password", textBoxX2.Text);
                if (cmd.CommandText == "Select * from _ThongTinNguoiLaoDong where _user = @_user and = _Password = @_Password")
                {
                    Menu form = new Menu();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Bạn đăng nhập sai tên hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Connection.dongketnoi();
            }
        }

        private void textBoxX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonX1.PerformClick();
            }
        }
    }
}
