namespace PMNS
{
    #region References

    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using PMNS.Entities.Models;
    using PMNS.Services.Abstract;

    #endregion

    public partial class ThongTinCaNhan : Form
    {
        #region Properties

        private ThongTinNhanVIen _empDetails;

        #endregion

        #region Constructor Or Destructor

        protected readonly ILoaiHopDongServices _loaiHopDongServices;
        public ThongTinCaNhan(ILoaiHopDongServices loaiHopDongServices, ThongTinNhanVIen empDetails)
        {
            this._loaiHopDongServices = loaiHopDongServices;
            this._empDetails = empDetails;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            Main();
        }

        private void Main()
        {
            //
            InitEmpDetails(_empDetails);

            HopDongLaoDong hopDong = _empDetails.HopDongLaoDongs.ToList().OrderByDescending(x => x.ngayBatDau).FirstOrDefault();
            InitHopDongLaoDong(hopDong);

            TrinhDo trinhDo = _empDetails.TrinhDoes.ToList().OrderByDescending(x => x.thoiGianTotNghiep).FirstOrDefault();
            InitThongTinHocVan(trinhDo);

            TD_DD_BN_TV tuyenDung = _empDetails.TD_DD_BN_TV.ToList().OrderByDescending(x => x.ngayKyQD)
                .Where(x => x.noiDung.Equals("Tuyển Dụng")).FirstOrDefault();
            InitTuyenDung(tuyenDung);

            TD_DD_BN_TV boNhiem = _empDetails.TD_DD_BN_TV.ToList().OrderByDescending(x => x.ngayKyQD)
                .Where(x => x.noiDung.Equals("Bổ Nhiệm")).FirstOrDefault();
            InitBoNhiem(boNhiem);

            TD_DD_BN_TV thoiViec = _empDetails.TD_DD_BN_TV.ToList().OrderByDescending(x => x.ngayKyQD)
                .Where(x => x.noiDung.Equals("Thôi Việc")).FirstOrDefault();
            InitThoiViec(thoiViec);

            TD_DD_BN_TV dieuDong = _empDetails.TD_DD_BN_TV.ToList().OrderByDescending(x => x.ngayKyQD)
                .Where(x => x.noiDung.Equals("Điều Động")).FirstOrDefault();
            InitDieuDong(dieuDong);

            KyLuat kyLuat = _empDetails.KyLuats.ToList().OrderByDescending(x => x.ngayKyLuat).FirstOrDefault();
            InitKyLuat(kyLuat);

            KhenThuong khenThuong = _empDetails.KhenThuongs.ToList().OrderByDescending(x => x.namKhenThuong).FirstOrDefault();
            InitKhenThuong(khenThuong);
        }

        #endregion

        #region Method Init

        private void InitEmpDetails(ThongTinNhanVIen emp)
        {
            lblTenNV.Text = _empDetails.hoTen;
            lblMaNV.Text = _empDetails.MaNV;
            lblHonNhan.Text = _empDetails.tinhTrangHonNhan;
            if (_empDetails.gioiTinh == 0)
            {
                lblGioiTinh.Text = "Nữ";
            }
            else
            {
                lblGioiTinh.Text = "Nam";
            }
            lblNgaySinh.Text = emp.namSinh.ToString("dd/MM/yyyy");
            lblSDTBan.Text = emp.soDienThoaiNha;
            lblSDTDD.Text = emp.soDienThoaiDiDong;
            lblCMND.Text = emp.CMND;
            lblNoiCapCMND.Text = emp.noiCapCMND;
            lblNgayCapCMND.Text = (Convert.ToDateTime(emp.ngayCapCMND)).ToString("dd/MM/yyyy");
            lblNguyenQuan.Text = emp.nguyenQuan;
            lblHoKhau.Text = emp.hoKhau;
            lblNoiOHienNay.Text = emp.noiOHienNay;
            lblThanhPho.Text = emp.ThanhPho.tenTP;
            if (emp.permission == 1)
            {
                lblPermission.Text = "Admin";
            }
            else
            {
                lblPermission.Text = "User";
            }
            lblUser.Text = emp.userName;
            lblCongViecDangLam.Text = emp.CongViecDangLam;
            lblBienChe.Text = emp.BienChe.bienChe1;
            lblCapBac.Text = emp.CapBac.capBac1;
            lblChucVu.Text = emp.ChucVu.ChucVu1;
            lblNguoiBaoLanh.Text = emp.nguoiBaoLanh;
            lblNamVaoCang.Text = Convert.ToDateTime(emp.ngayVaoCang).ToString("yyyy");
            lblNamVaoST.Text = Convert.ToDateTime(emp.namVaoSongThan).ToString("yyyy");
            lblNamNhapNgu.Text = Convert.ToDateTime(emp.ngayNhapNgu).ToString("yyyy");
            lblNoiCongTac.Text = emp.noiCongTac;
            lblMQHNguoiBaoLanh.Text = emp.moiQuanHeBaoLanh;
            lblPhongBan.Text = emp.PhongDoiToLoaiTo.tenPhongDoiToLoai;
        }

        private void InitThongTinGiaDinh(PMNS.Entities.Models.ThongTinGiaDinh giaDinh)
        {
            if (giaDinh != null)
            {
                lblHoTenBo.Text = giaDinh.hoTenCha;
                lblHoTenMe.Text = giaDinh.hoTenMe;
                lblNamSinhBo.Text = giaDinh.namSinhCha.ToString("yyyy");
                lblNamSinhme.Text = giaDinh.namSinhMe.ToString("yyyy");
                lblNgheNghiepBo.Text = giaDinh.ngheNghiepCha;
                lblNgheNghiepMe.Text = giaDinh.ngheNghiepMe;
                lblHoTenVoChong.Text = giaDinh.hoTenVoChong;
                lblNgheNghiepVoChong.Text = giaDinh.ngheNghiepVoChong;
                lblNamSinhVoChong.Text = Convert.ToDateTime(giaDinh.namSinhVoChong).ToString("yyyy");
                txtConCai.Text = giaDinh.thongTinConCai;
            }
            else
            {
                lblHoTenBo.Text = "Chưa Cập Nhật";
                lblHoTenMe.Text = "Chưa Cập Nhật";
                lblNamSinhBo.Text = "Chưa Cập Nhật";
                lblNamSinhme.Text = "Chưa Cập Nhật";
                lblNgheNghiepBo.Text = "Chưa Cập Nhật";
                lblNgheNghiepMe.Text = "Chưa Cập Nhật";
                lblHoTenVoChong.Text = "Chưa Cập Nhật";
                lblNgheNghiepVoChong.Text = "Chưa Cập Nhật";
                lblNamSinhVoChong.Text = "Chưa Cập Nhật";
                txtConCai.Text = "Chưa Cập Nhật";
            }
        }

        private void InitThongTinHocVan(TrinhDo trinhDo)
        {
            if (trinhDo != null)
            {
                lblVanHoa.Text = trinhDo.vanHoa;
                lblTrinhDo.Text = trinhDo.trinhDo1;
                lblNoiDaoTao.Text = trinhDo.noiDaoTao;
                lblChuyenNganh.Text = trinhDo.chuyenNganh;
                lblLoaiHinh.Text = trinhDo.loaiHinh;
                lblThoiGianTotNghiep.Text = Convert.ToDateTime(trinhDo.thoiGianTotNghiep).ToString("dd/MM/yyyy");
                lblBangCapPhu.Text = trinhDo.bangCapPhu_CC;
            }
            else
            {
                lblVanHoa.Text = "Chưa Cập Nhật";
                lblTrinhDo.Text = "Chưa Cập Nhật";
                lblNoiDaoTao.Text = "Chưa Cập Nhật";
                lblChuyenNganh.Text = "Chưa Cập Nhật";
                lblLoaiHinh.Text = "Chưa Cập Nhật";
                lblThoiGianTotNghiep.Text = "Chưa Cập Nhật";
                lblBangCapPhu.Text = "Chưa Cập Nhật";
            }
        }

        private void InitHopDongLaoDong(HopDongLaoDong hopDong)
        {
            if (hopDong != null)
            {
                lblSoHopDong.Text = hopDong.soHopDong_TTHDLD;
                lblNguoiBaoLanhHDLD.Text = hopDong.nguoiBaoLanh_TTHDLD;
                if (hopDong.LoaiHopDong.idCha != 0)
                {
                    lblLoaiHD.Text = String.Join(" - ", _loaiHopDongServices.GetLoaiHopDongById(hopDong.LoaiHopDong.idCha).loaiHopDong1,
                        hopDong.LoaiHopDong.loaiHopDong1);
                }
                else
                {
                    lblLoaiHD.Text = hopDong.LoaiHopDong.loaiHopDong1;
                }
                lblChucDanhHDLD.Text = hopDong.chucDanh;
                lblNgayBatDau.Text = hopDong.ngayBatDau.ToString("dd/MM/yyyy");
                lblNgayKetThuc.Text = hopDong.ngayKetThuc.ToString("dd/MM/yyyy");
                if (hopDong.ngayKetThuc <= DateTime.Today)
                {
                    lblNgayKetThuc.ForeColor = Color.Red;
                    lblNgayKetThuc.Font = new Font(lblNgayKetThuc.Font, FontStyle.Bold);
                }
                lblGhiChu.Text = hopDong.ghiChu;
            }
            else
            {
                lblSoHopDong.Text = "Chưa Cập Nhật";
                lblNguoiBaoLanhHDLD.Text = "Chưa Cập Nhật";
                lblChucDanhHDLD.Text = "Chưa Cập Nhật";
                lblLoaiHD.Text = "Chưa Cập Nhật";
                lblNgayBatDau.Text = "Chưa Cập Nhật";
                lblNgayKetThuc.Text = "Chưa Cập Nhật";
                lblGhiChu.Text = "Chưa Cập Nhật";
            }
        }

        private void InitKyLuat(KyLuat kyLuat)
        {
            if (kyLuat != null)
            {
                lblLoaiKyLuat.Text = kyLuat.loaiKyLuat;
                lblNgayKyLuat.Text = kyLuat.ngayKyLuat.ToString("dd/MM/yyyy");
                lblSoQDKyLuat.Text = kyLuat.soQuyetDinhKyLuat;
                lblHanhViKL.Text = kyLuat.hanhViBiKyLuat;
                lblNguoiKyQD.Text = kyLuat.nguoiKyQuyetDinh;
                lblGhiChuKyLuat.Text = kyLuat.ghiChu;
            }
            else
            {
                lblLoaiKyLuat.Text = "Chưa Cập Nhật";
                lblNgayKyLuat.Text = "Chưa Cập Nhật";
                lblSoQDKyLuat.Text = "Chưa Cập Nhật";
                lblHanhViKL.Text = "Chưa Cập Nhật";
                lblNguoiKyQD.Text = "Chưa Cập Nhật";
                lblGhiChuKyLuat.Text = "Chưa Cập Nhật";
            }
        }

        private void InitTuyenDung(TD_DD_BN_TV thongTin)
        {
            if (thongTin != null)
            {
                lblNamTD.Text = thongTin.namThucHien.ToString("yyyy");
                lblViTriMoiTD.Text = thongTin.viTriMoi;
                lblSoQDTD.Text = thongTin.soQuyetDinh;
                lblNgayHieuLucTD.Text = Convert.ToDateTime(thongTin.ngayHieuLuc).ToString("dd/MM/yyyy");
            }
            else
            {
                lblNamTD.Text = "Chưa Cập Nhật";
                lblViTriMoiTD.Text = "Chưa Cập Nhật";
                lblSoQDTD.Text = "Chưa Cập Nhật";
                lblNgayHieuLucTD.Text = "Chưa Cập Nhật";
            }
        }

        private void InitBoNhiem(TD_DD_BN_TV thongTin)
        {
            if (thongTin != null)
            {
                lblNamBN.Text = thongTin.namThucHien.ToString("yyyy");
                lblViTriCuBN.Text = thongTin.viTriCu;
                lblViTriMoiBN.Text = thongTin.viTriMoi;
                lblSoQDBN.Text = thongTin.soQuyetDinh;
                lblNgayHieuLucBN.Text = Convert.ToDateTime(thongTin.ngayHieuLuc).ToString("dd/MM/yyyy");
            }
            else
            {
                lblNamBN.Text = "Chưa Cập Nhật";
                lblViTriCuBN.Text = "Chưa Cập Nhật";
                lblViTriMoiBN.Text = "Chưa Cập Nhật";
                lblSoQDBN.Text = "Chưa Cập Nhật";
                lblNgayHieuLucBN.Text = "Chưa Cập Nhật";
            }
        }

        private void InitThoiViec(TD_DD_BN_TV thongTin)
        {
            if (thongTin != null)
            {
                lblNamTV.Text = thongTin.namThucHien.ToString("yyyy");
                lblSoQDTV.Text = thongTin.soQuyetDinh;
                lblNgayHieuLucTV.Text = Convert.ToDateTime(thongTin.ngayHieuLuc).ToString("dd/MM/yyyy");
            }
            else
            {
                lblNamTV.Text = "Chưa Cập Nhật";
                lblSoQDTV.Text = "Chưa Cập Nhật";
                lblNgayHieuLucTV.Text = "Chưa Cập Nhật";
            }
        }

        private void InitDieuDong(TD_DD_BN_TV thongTin)
        {
            if (thongTin != null)
            {
                lblNamDD.Text = thongTin.namThucHien.ToString("yyyy");
                lblViTriCuDD.Text = thongTin.viTriCu;
                lblViTriMoiDD.Text = thongTin.viTriMoi;
                lblSoQDDD.Text = thongTin.soQuyetDinh;
                lblNgayHieuLucDD.Text = Convert.ToDateTime(thongTin.ngayHieuLuc).ToString("dd/MM/yyyy");
            }
            else
            {
                lblNamDD.Text = "Chưa Cập Nhật";
                lblViTriCuDD.Text = "Chưa Cập Nhật";
                lblViTriMoiDD.Text = "Chưa Cập Nhật";
                lblSoQDDD.Text = "Chưa Cập Nhật";
                lblNgayHieuLucDD.Text = "Chưa Cập Nhật";
            }
        }

        private void InitKhenThuong(KhenThuong khenThuong)
        {
            if (khenThuong != null)
            {
                lblLoaiKhenThuong.Text = khenThuong.loaiKhenThuong;
                lblNamKhenThuong.Text = khenThuong.namKhenThuong.ToString("yyyy");
                lblSoQDKhen.Text = khenThuong.soSoKhenThuong;
                lblNguoiKhen.Text = khenThuong.nguoiKhenThuong;
                lblThanhTichKhen.Text = khenThuong.thanhTichKhenThuong;
                lblGhiChuKhen.Text = khenThuong.ghiChu;
            }
            else
            {
                lblLoaiKhenThuong.Text = "Chưa Cập Nhật";
                lblNamKhenThuong.Text = "Chưa Cập Nhật";
                lblSoQDKhen.Text = "Chưa Cập Nhật";
                lblNguoiKhen.Text = "Chưa Cập Nhật";
                lblThanhTichKhen.Text = "Chưa Cập Nhật";
                lblGhiChuKhen.Text = "Chưa Cập Nhật";
            }
        }

        #endregion
    }
}
