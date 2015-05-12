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
using PMNS.Entities.Models;

namespace PMNS
{
    public partial class Dang_nhap : Form
    {
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IDoiServices _doiServices;
        protected readonly IToServices _toServices;
        protected readonly ILoaiToServices _loaiToServices;
        protected readonly IThanhPhoServices _thanhPhoServices;

        public Dang_nhap(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IDoiServices doiServices,
            IToServices toServices, ILoaiToServices loaiToServices, IThanhPhoServices thanhPhoServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._doiServices = doiServices;
            this._toServices = toServices;
            this._loaiToServices = loaiToServices;
            this._thanhPhoServices = thanhPhoServices;
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
                if (_nhanVienServices.GetEmployeeByNameAndPass(name, pass))
                {
                    Menu form = new Menu(_phongBanServices, _doiServices, _toServices, _loaiToServices, _thanhPhoServices, _nhanVienServices);
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
