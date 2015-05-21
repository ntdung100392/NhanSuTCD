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
using PMNS.Entities.Models;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;
using PMNS.Services.Models;

namespace PMNS
{
    public partial class Menu : Form
    {
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        protected readonly IChucVuServices _chucVuServices;
        protected readonly ICapBacServices _capBacServices;
        protected readonly IBienCheServices _bienCheServices;
        protected readonly IThongTinServices _thongTinServices;
        protected readonly IThongTinTrinhDoServices _thongTinTrinhDoServices;

        public Menu(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices,
            IThanhPhoServices thanhPhoServices, IChucVuServices chucVuServices,
            ICapBacServices capBacServices, IBienCheServices bienCheServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._thanhPhoServices = thanhPhoServices;
            this._chucVuServices = chucVuServices;
            this._capBacServices = capBacServices;
            this._bienCheServices = bienCheServices;
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void thêmNhânViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                ThemNV ThemNV = new ThemNV(_nhanVienServices, _phongBanServices, _thanhPhoServices, _chucVuServices,
                    _capBacServices, _bienCheServices);
                ThemNV.Show();
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien formChinhsưa = new DanhSachNhanVien();
            formChinhsưa.Show();
        }
    }
}
