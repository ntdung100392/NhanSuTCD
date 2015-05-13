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
        protected readonly IDoiServices _doiServices;
        protected readonly IToServices _toServices;
        protected readonly ILoaiToServices _loaiToServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        protected readonly IChucVuServices _chucVuServices;
        protected readonly ICapBacServices _capBacServices;
        protected readonly IBienCheServices _bienCheServices;

        public Menu(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IDoiServices doiServices,
            IToServices toServices, ILoaiToServices loaiToServices, IThanhPhoServices thanhPhoServices, IChucVuServices chucVuServices,
            ICapBacServices capBacServices, IBienCheServices bienCheServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._doiServices = doiServices;
            this._toServices = toServices;
            this._loaiToServices = loaiToServices;
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
                ThemNV ThemNV = new ThemNV(_nhanVienServices, _phongBanServices, _doiServices, _toServices, _loaiToServices,
                    _thanhPhoServices, _chucVuServices, _capBacServices, _bienCheServices);
                ThemNV.Show();
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTin formChinhsưa = new ChinhSuaThongTin();
            formChinhsưa.Show();
        }
    }
}
