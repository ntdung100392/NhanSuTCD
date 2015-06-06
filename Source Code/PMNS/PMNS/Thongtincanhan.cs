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

namespace PMNS
{
    public partial class ThongTinCaNhan : Form
    {
        private ThongTinNhanVIen _empDetails;
        public ThongTinCaNhan(ThongTinNhanVIen empDetails)
        {
            this._empDetails = empDetails;
            InitializeComponent();
        }

        private void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            InitDataForm();
        }

        private void InitDataForm()
        {
            InitEmpDetails(_empDetails);
            HopDongLaoDong hopDong = _empDetails.HopDongLaoDongs.ToList().OrderByDescending(x => x.ngayBatDau).FirstOrDefault();
            InitHopDongLaoDong(hopDong);
            TD_DD_BN_TV tuyenDung = _empDetails.TD_DD_BN_TV.ToList().OrderByDescending(x => x.ngayKyQD)
                .Where(x => x.noiDung.Equals("Tuyển Dụng")).FirstOrDefault();
            TD_DD_BN_TV boNhiem = _empDetails.TD_DD_BN_TV.ToList().OrderByDescending(x => x.ngayKyQD)
                .Where(x => x.noiDung.Equals("Bổ Nhiệm")).FirstOrDefault();
            InitThongTin(tuyenDung, "Tuyển Dụng");
            InitThongTin(boNhiem, "Bổ Nhiệm");
            KyLuat kyLuat = _empDetails.KyLuats.ToList().OrderByDescending(x => x.ngayKyLuat).FirstOrDefault();
            InitKyLuat(kyLuat);
        }

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

        }

        private void InitHopDongLaoDong(HopDongLaoDong hopDong)
        {

        }

        private void InitKyLuat(KyLuat kyLuat)
        {

        }

        private void InitThongTin(TD_DD_BN_TV thongTin, string noiDung)
        {

        }
    }
}
