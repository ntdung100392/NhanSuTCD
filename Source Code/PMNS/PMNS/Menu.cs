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
        #region Constructor Or Destructor
        protected readonly IBienCheServices _bienCheServices;
        protected readonly ICapBacServices _capBacServices;
        protected readonly IChucVuServices _chucVuServices;
        protected readonly IHopDongServices _hopDongServices;
        protected readonly IKhenThuongServices _khenThuongServices;
        protected readonly IKyLuatServices _kyLuatServices;
        protected readonly ILoaiHopDongServices _loaiHopDongServices;
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        protected readonly IThongTinGiaDinhServices _thongTinGiaDinhServices;
        protected readonly IThongTinServices _thongTinServices;
        protected readonly IThongTinTrinhDoServices _trinhDoServices;
        public Menu(IBienCheServices bienCheServices, ICapBacServices capBacServices, IChucVuServices chucVuServices,
            IHopDongServices hopDongServices, IKhenThuongServices khenThuongServices, IKyLuatServices kyLuatServices, ILoaiHopDongServices loaiHopDongServices,
            INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IThanhPhoServices thanhPhoServices, IThongTinGiaDinhServices thongTinGiaDinhServices,
            IThongTinServices thongTinServices, IThongTinTrinhDoServices trinhDoServices)
        {
            this._bienCheServices = bienCheServices;
            this._capBacServices = capBacServices;
            this._chucVuServices = chucVuServices;
            this._hopDongServices = hopDongServices;
            this._khenThuongServices = khenThuongServices;
            this._kyLuatServices = kyLuatServices;
            this._loaiHopDongServices = loaiHopDongServices;
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._thanhPhoServices = thanhPhoServices;
            this._thongTinGiaDinhServices = thongTinGiaDinhServices;
            this._thongTinServices = thongTinServices;
            this._trinhDoServices = trinhDoServices;
            InitializeComponent();
        }
        #endregion

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void thêmNhânViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                ThemNV addEmpForm = new ThemNV(_nhanVienServices, _phongBanServices, _thanhPhoServices, _chucVuServices,
                    _capBacServices, _bienCheServices);
                addEmpForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien danhSachForm = new DanhSachNhanVien(_nhanVienServices, _phongBanServices, _thanhPhoServices, _chucVuServices,
                _capBacServices, _bienCheServices, _loaiHopDongServices, _trinhDoServices, _thongTinGiaDinhServices);
            danhSachForm.ShowDialog(this);
        }

        private void thêmTTTDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin_TuyenDung tuyenDungForm = new ThongTin_TuyenDung(_nhanVienServices, _thongTinServices, "Tuyển Dụng");
            tuyenDungForm.ShowDialog(this);
        }

        private void thêmTTĐĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin_TuyenDung dieuDongForm = new ThongTin_TuyenDung(_nhanVienServices, _thongTinServices, "Điều Động");
            dieuDongForm.ShowDialog(this);
        }

        private void thêmTTBNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin_TuyenDung boNhiemForm = new ThongTin_TuyenDung(_nhanVienServices, _thongTinServices, "Bổ Nhiệm");
            boNhiemForm.ShowDialog(this);
        }

        private void thêmTTTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTin_TuyenDung thoiViecForm = new ThongTin_TuyenDung(_nhanVienServices, _thongTinServices, "Thôi Việc");
            thoiViecForm.ShowDialog(this);
        }

        private void quảnLýBiênChếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyBienChe bienCheForm = new QuanLyBienChe(_bienCheServices);
            bienCheForm.ShowDialog(this);
        }

        private void quảnLýCấpBậcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyCapBac capBacForm = new QuanLyCapBac(_capBacServices);
            capBacForm.ShowDialog(this);
        }

        private void quảnLýChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyChucVu chucVuForm = new QuanLyChucVu(_chucVuServices);
            chucVuForm.ShowDialog(this);
        }

        private void danhSáchTuyểnDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThongTin danhSachTuyenDung = new DanhSachThongTin(_thongTinServices, "Tuyển Dụng");
            danhSachTuyenDung.ShowDialog(this);
        }

        private void danhSáchĐiềuĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThongTin danhSachDieuDong = new DanhSachThongTin(_thongTinServices, "Điều Động");
            danhSachDieuDong.ShowDialog(this);
        }

        private void danhSáchBổNhiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThongTin danhSachBoNhiem = new DanhSachThongTin(_thongTinServices, "Bổ Nhiệm");
            danhSachBoNhiem.ShowDialog(this);
        }

        private void danhSáchThôiViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThongTin danhSachThoiViec = new DanhSachThongTin(_thongTinServices, "Thôi Việc");
            danhSachThoiViec.ShowDialog(this);
        }

        private void quảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyPhongBan phongBanForm = new QuanLyPhongBan(_phongBanServices);
            phongBanForm.ShowDialog(this);
        }

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinKhenThuong khenThuongForm = new ThongTinKhenThuong(_nhanVienServices, _khenThuongServices);
            khenThuongForm.ShowDialog(this);
        }

        private void kỷLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinKyLuat kyLuatForm = new ThongTinKyLuat(_nhanVienServices, _kyLuatServices);
            kyLuatForm.ShowDialog(this);
        }

        private void trìnhĐộToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTinTrinhDo trinhdoForm = new ThongTinTrinhDo(_nhanVienServices, _trinhDoServices);
            trinhdoForm.ShowDialog(this);
        }
    }
}
