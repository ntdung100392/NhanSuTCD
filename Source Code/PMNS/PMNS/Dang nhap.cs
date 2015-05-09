using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMNS.Services.Abstract;
using PMNS.Services.Implement;
using PMNS.Entities.Models;

namespace PMNS
{
    public partial class Dang_nhap : Form
    {
        protected readonly INguoiLaoDongServices _nguoiLaoDongService;

        public Dang_nhap(INguoiLaoDongServices nguoiLaoDongService)
        {
            this._nguoiLaoDongService = nguoiLaoDongService;
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
            if (String.IsNullOrEmpty(textBoxX1.Text.Trim()) || String.IsNullOrEmpty(textBoxX2.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = textBoxX1.Text.Trim();
                string pass = textBoxX2.Text.Trim();
                if (_nguoiLaoDongService.GetEmployeeByNameAndPass(name, pass) != null)
                {
                    Menu form = new Menu();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Bạn đăng nhập sai tên hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
