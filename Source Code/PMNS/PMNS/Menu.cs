namespace PMNS
{
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

    public partial class Menu : Form
    {
        #region Constructor Or Destructor

        protected readonly IBienCheServices bienCheServices;
        protected readonly ICapBacServices capBacServices;
        protected readonly IChucVuServices chucVuServices;
        protected readonly IHopDongServices hopDongServices;
        protected readonly IKhenThuongServices khenThuongServices;
        protected readonly IKyLuatServices kyLuatServices;
        protected readonly ILoaiHopDongServices loaiHopDongServices;
        protected readonly INhanVienServices nhanVienServices;
        protected readonly IPhongBanServices phongBanServices;
        protected readonly IThanhPhoServices thanhPhoServices;
        protected readonly IThongTinGiaDinhServices thongTinGiaDinhServices;
        protected readonly IThongTinServices thongTinServices;
        protected readonly IThongTinTrinhDoServices thongTinTrinhDoServices;
        protected readonly ITrinhDoServices trinhDoServices;

        public Menu(IBienCheServices bienCheServices, ICapBacServices capBacServices, IChucVuServices chucVuServices,
            IHopDongServices hopDongServices, IKhenThuongServices khenThuongServices, IKyLuatServices kyLuatServices, ILoaiHopDongServices loaiHopDongServices,
            INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IThanhPhoServices thanhPhoServices, IThongTinGiaDinhServices thongTinGiaDinhServices,
            IThongTinServices thongTinServices, IThongTinTrinhDoServices thongTinTrinhDoServices, ITrinhDoServices trinhDoServices)
        {
            this.bienCheServices = bienCheServices;
            this.capBacServices = capBacServices;
            this.chucVuServices = chucVuServices;
            this.hopDongServices = hopDongServices;
            this.khenThuongServices = khenThuongServices;
            this.kyLuatServices = kyLuatServices;
            this.loaiHopDongServices = loaiHopDongServices;
            this.nhanVienServices = nhanVienServices;
            this.phongBanServices = phongBanServices;
            this.thanhPhoServices = thanhPhoServices;
            this.thongTinGiaDinhServices = thongTinGiaDinhServices;
            this.thongTinServices = thongTinServices;
            this.thongTinTrinhDoServices = thongTinTrinhDoServices;
            this.trinhDoServices = trinhDoServices;
            InitializeComponent();
        }

        #endregion

        public void Form1_Load(object sender, EventArgs e) { }

        #region Application Method

        private void thôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                REPORT reportForm = new REPORT(bienCheServices, capBacServices, chucVuServices, nhanVienServices, phongBanServices, thanhPhoServices,
                    loaiHopDongServices, trinhDoServices);
                reportForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dang_nhap dangNhapForm = new Dang_nhap(bienCheServices, capBacServices, chucVuServices, hopDongServices, khenThuongServices,
                kyLuatServices, loaiHopDongServices, nhanVienServices, phongBanServices, thanhPhoServices, thongTinGiaDinhServices,
                thongTinServices, thongTinTrinhDoServices, trinhDoServices);
            UserProfile.hoTen = null;
            UserProfile.idNhanVien = 0;
            UserProfile.MaNV = null;
            UserProfile.permission = 0;
            UserProfile.userName = null;
            dangNhapForm.Show();
            this.Close();
        }

        #endregion

        #region Emp Management

        public void thêmNhânViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                ThemNV addEmpForm = new ThemNV(bienCheServices, capBacServices, chucVuServices, nhanVienServices, phongBanServices, thanhPhoServices);
                addEmpForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachNhanVien danhSachForm = new DanhSachNhanVien(hopDongServices, nhanVienServices, phongBanServices, thanhPhoServices, chucVuServices,
                capBacServices, bienCheServices, loaiHopDongServices, thongTinTrinhDoServices, thongTinGiaDinhServices, trinhDoServices);
            danhSachForm.ShowDialog(this);
        }

        #endregion

        #region Emp Informations

        private void khenThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                ThongTinKhenThuong khenThuongForm = new ThongTinKhenThuong(nhanVienServices, khenThuongServices);
                khenThuongForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kỷLuậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                ThongTinKyLuat kyLuatForm = new ThongTinKyLuat(nhanVienServices, kyLuatServices);
                kyLuatForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trìnhĐộToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                ThongTinTrinhDo trinhdoForm = new ThongTinTrinhDo(nhanVienServices, thongTinTrinhDoServices, trinhDoServices);
                trinhdoForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thêmHĐLĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                QuanLyHopDong hopDongForm = new QuanLyHopDong(nhanVienServices, hopDongServices, loaiHopDongServices, null);
                hopDongForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kiểmTraThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiemTraHDLD hopDongListForm = new KiemTraHDLD(hopDongServices, loaiHopDongServices, nhanVienServices);
            hopDongListForm.ShowDialog(this);
        }

        #endregion

        #region Informations Management

        private void thêmTTTDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                ThongTin_TuyenDung tuyenDungForm = new ThongTin_TuyenDung(nhanVienServices, thongTinServices, "Tuyển Dụng");
                tuyenDungForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void thêmTTĐĐToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                try
                {
                    ThongTin_TuyenDung dieuDongForm = new ThongTin_TuyenDung(nhanVienServices, thongTinServices, "Điều Động");
                    dieuDongForm.ShowDialog(this);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex);
                }
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thêmTTBNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                ThongTin_TuyenDung boNhiemForm = new ThongTin_TuyenDung(nhanVienServices, thongTinServices, "Bổ Nhiệm");
                boNhiemForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thêmTTTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                ThongTin_TuyenDung thoiViecForm = new ThongTin_TuyenDung(nhanVienServices, thongTinServices, "Thôi Việc");
                thoiViecForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void danhSáchTuyểnDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThongTin danhSachTuyenDung = new DanhSachThongTin(nhanVienServices, phongBanServices, thongTinServices, "Tuyển Dụng");
            danhSachTuyenDung.ShowDialog(this);
        }

        private void danhSáchĐiềuĐộngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThongTin danhSachDieuDong = new DanhSachThongTin(nhanVienServices, phongBanServices, thongTinServices, "Điều Động");
            danhSachDieuDong.ShowDialog(this);
        }

        private void danhSáchBổNhiệmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThongTin danhSachBoNhiem = new DanhSachThongTin(nhanVienServices, phongBanServices, thongTinServices, "Bổ Nhiệm");
            danhSachBoNhiem.ShowDialog(this);
        }

        private void danhSáchThôiViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DanhSachThongTin danhSachThoiViec = new DanhSachThongTin(nhanVienServices, phongBanServices, thongTinServices, "Thôi Việc");
            danhSachThoiViec.ShowDialog(this);
        }

        #endregion

        #region General Management

        private void quảnLýBiênChếToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                QuanLyBienChe bienCheForm = new QuanLyBienChe(bienCheServices);
                bienCheForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quảnLýCấpBậcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                QuanLyCapBac capBacForm = new QuanLyCapBac(capBacServices);
                capBacForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quảnLýChứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                QuanLyChucVu chucVuForm = new QuanLyChucVu(chucVuServices);
                chucVuForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void quảnLýPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                QuanLyPhongBan phongBanForm = new QuanLyPhongBan(phongBanServices);
                phongBanForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thôngTinPhầnMềmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About thongtinPhanMem = new About();
            thongtinPhanMem.ShowDialog(this);
        }

        #endregion

        private void thêmThôngTinTrìnhĐộToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTrinhDo trinhDoForm = new ThongTinTrinhDo(nhanVienServices, thongTinTrinhDoServices, trinhDoServices);
            trinhDoForm.ShowDialog(this);
        }

        private void quảnLýTrìnhĐộToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            QuanLyLoaiTrinhDo loaiTrinhDoForm = new QuanLyLoaiTrinhDo(trinhDoServices);
            loaiTrinhDoForm.ShowDialog(this);
        }
    }
}
