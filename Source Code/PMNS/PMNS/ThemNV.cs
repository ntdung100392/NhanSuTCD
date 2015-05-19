using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using PMNS.Entities.Models;
using PMNS.Services.Abstract;
using PMNS.Model;

namespace PMNS
{
    public partial class ThemNV : Form
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

        public ThemNV(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IDoiServices doiServices,
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

        #region DateTimePicker

        private void datetimeNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgaySinh.Format = DateTimePickerFormat.Custom;
            datetimeNgaySinh.CustomFormat = "dd/MM/yyyy";
            txtNgaySinh.Text = datetimeNgaySinh.Text;
        }
        private void datetimeCMND_ValueChanged(object sender, EventArgs e)
        {
            datetimeCMND.Format = DateTimePickerFormat.Custom;
            datetimeCMND.CustomFormat = "dd/MM/yyyy";
            txtNgayCapCMND.Text = datetimeCMND.Text;
        }
        private void datetimeNgayVaoCang_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgayVaoCang.Format = DateTimePickerFormat.Custom;
            datetimeNgayVaoCang.CustomFormat = "dd/MM/yyyy";
            txtNgayVaoCang.Text = datetimeNgayVaoCang.Text;
        }
        private void datetimeNgayNhapNgu_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgayNhapNgu.Format = DateTimePickerFormat.Custom;
            datetimeNgayNhapNgu.CustomFormat = "dd/MM/yyyy";
            txtNgayNhapNgu.Text = datetimeNgayNhapNgu.Text;
        }

        private void datetimeNamVaoST_ValueChanged(object sender, EventArgs e)
        {
            datetimeNamVaoST.Format = DateTimePickerFormat.Custom;
            datetimeNamVaoST.CustomFormat = "dd/MM/yyyy";
            txtNamVaoST.Text = datetimeNamVaoST.Text;
        }
        #endregion


        #region Form's Event
        private void ThemNV_Load(object sender, EventArgs e)
        {
            txtUserName.Enabled = false;
            cbDoi.Enabled = false;
            cbTo.Enabled = false;
            cbLoaiTo.Enabled = false;
            txtMoiQuanHeNBL.Enabled = false;
            cbBienChe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCapBac.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDoi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbLoaiTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaCV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNguyenQuan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNoiCapCMND.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhanQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbThanhPho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinhTrangHonNhan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTo.DropDownStyle = ComboBoxStyle.DropDownList;
            InitPhongBan();
            InitCbThanhPho();
            InitCbNoiCapCMND();
            InitCbNguyenQuan();
            InitChucVu();
            InitHonNhan();
            InitEmployees();
            InitCapBac();
            InitBienChe();
            InitPermission();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            int sex = 0;
            int idTo = 0;
            int idLoaiTo = 0;
            int idDoi = 0;
            if (cbTo.SelectedItem != null)
            {
                idTo = Convert.ToInt32((cbTo.SelectedItem as To).idTo);
            }
            if (cbDoi.SelectedItem != null)
            {
                idDoi = Convert.ToInt32((cbDoi.SelectedItem as Doi).idDoi);
            }
            if (cbLoaiTo.SelectedItem != null)
            {
                idLoaiTo = Convert.ToInt32((cbLoaiTo.SelectedItem as LoaiTo).idLoaiTo);
            }
            if (rbtnNam.Checked == true)
            {
                sex = 0;
            }
            if (rBtnNu.Checked == true)
            {
                sex = 1;
            }
            ThongTinNhanVIen emp = new ThongTinNhanVIen
            {
                MaNV = txtManv.Text.Trim(),
                idPhong = Convert.ToInt32((cbPhongBan.SelectedItem as Phong).idPhong),
                idTo = idTo,
                idDoi = idDoi,
                idLoaiTo = idLoaiTo,
                userName = txtUserName.Text.Trim(),
                password = "12345678x@X",
                permission = Convert.ToInt32((cbPhanQuyen.SelectedItem as ComboBoxItem).Value),
                idBienChe = Convert.ToInt32((cbBienChe.SelectedItem as BienChe).idBienChe),
                idCapBac = Convert.ToInt32((cbCapBac.SelectedItem as CapBac).idCapBac),
                idChucVu = Convert.ToInt32((cbMaCV.SelectedItem as ChucVu).idChucVu),
                idTP = Convert.ToInt32((cbThanhPho.SelectedItem as ThanhPho).idThanhPho),
                CongViecDangLam = txtCongViecDangLam.Text.Trim(),
                hoTen = txtTennv.Text,
                gioiTinh = Convert.ToByte(sex),
                namSinh = datetimeNgaySinh.Value,
                nguyenQuan = (cbNguyenQuan.SelectedItem as ThanhPho).tenTP,
                noiOHienNay = txtdiachi.Text,
                hoKhau = txtHoKhau.Text,
                CMND = txtCMND.Text,
                ngayCapCMND = datetimeCMND.Value,
                noiCapCMND = (cbNoiCapCMND.SelectedItem as ThanhPho).tenTP,
                soDienThoaiNha = "",
                soDienThoaiDiDong = txtSdt.Text.Trim(),
                nguoiBaoLanh = txtNguoiBaoLanh.Text,
                moiQuanHeBaoLanh = txtMoiQuanHeNBL.Text,
                noiCongTac = txtNoiCongTac.Text.Trim(),
                ngayVaoCang = datetimeNgayVaoCang.Value,
                namVaoSongThan = datetimeNamVaoST.Value,
                ngayNhapNgu = datetimeNgayNhapNgu.Value,
                tinhTrangHonNhan = (cbTinhTrangHonNhan.SelectedItem as ComboBoxItem).Text,
                hinhAnhCaNhan = ""
            };
            if (_nhanVienServices.AddNhanVien(emp))
            {
                MessageBox.Show("Bạn đã thêm nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Clear();
                txtTennv.Clear();
                InitEmployees();
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("Đã Có Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn Có Muốn Thoát Khỏi Chương Trình ?", "Warning", MessageBoxButtons.YesNo);
        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            txtUserName.Text = txtManv.Text;
        }

        private void cbPhongBan_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbPhongBan.Text.Trim() != "")
            {
                var phong = cbPhongBan.SelectedItem as Phong;
                if (phong.Dois.Count != 0)
                {
                    cbDoi.Enabled = true;
                    cbDoi.DataSource = phong.Dois;
                    cbDoi.DisplayMember = "tenDoi";
                    cbDoi.ValueMember = "idDoi";
                }
                else
                {
                    cbDoi.Enabled = false;
                    cbDoi.DataSource = null;
                    cbTo.Enabled = false;
                    cbTo.DataSource = null;
                    cbLoaiTo.Enabled = false;
                    cbLoaiTo.DataSource = null;
                }
            }
        }

        private void cbDoi_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbDoi.Text.Trim() != "")
            {
                var doi = cbDoi.SelectedItem as Doi;
                if (doi.Toes.Count != 0)
                {
                    cbTo.Enabled = true;
                    cbTo.DataSource = doi.Toes;
                    cbTo.DisplayMember = "tenTo";
                    cbTo.ValueMember = "idTo";
                }
                else
                {
                    cbTo.Enabled = false;
                    cbTo.DataSource = null;
                    cbLoaiTo.Enabled = false;
                    cbLoaiTo.DataSource = null;
                }
            }
        }

        private void cbTo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTo.Text.Trim() != "")
            {
                var to = cbTo.SelectedItem as To;
                if (to.LoaiToes.Count != 0)
                {
                    cbLoaiTo.Enabled = true;
                    cbLoaiTo.DataSource = to.LoaiToes;
                    cbLoaiTo.DisplayMember = "tenLoaiTo";
                    cbLoaiTo.ValueMember = "idLoaiTo";
                }
                else
                {
                    cbLoaiTo.Enabled = false;
                    cbLoaiTo.DataSource = null;
                }
            }
        }

        private void txtNguoiBaoLanh_TextChanged(object sender, EventArgs e)
        {
            if (txtNguoiBaoLanh.Text.Trim() != "")
            {
                txtMoiQuanHeNBL.Enabled = true;
            }
            else
            {
                txtMoiQuanHeNBL.Enabled = false;
            }
        }

        #endregion

        #region Init
        public void InitPermission()
        {
            List<ComboBoxItem> item = new List<ComboBoxItem> 
            {
                new ComboBoxItem { Text = "Admin", Value = 1 },
                new ComboBoxItem { Text = "User", Value = 0 }
            };

            cbPhanQuyen.DataSource = item;
            cbPhanQuyen.DisplayMember = "Text";
            cbPhanQuyen.ValueMember = "Value";
        }
        public void InitEmployees()
        {
            var listNhanVien = _nhanVienServices.GetAllEmployees();
            dataGridView1.DataSource = listNhanVien.OrderBy(x => x.hoTen).ToList().Select(x =>
                new
                {
                    HoTen = x.hoTen,
                    GioiTinh = x.gioiTinh,
                    NamSinh = x.namSinh,
                    MaNV = x.MaNV,
                }).ToList();
        }

        public void InitPhongBan()
        {
            cbPhongBan.DataSource = _phongBanServices.GetAllPhongBan();
            cbPhongBan.DisplayMember = "tenPhong";
            cbPhongBan.ValueMember = "idPhong";
            cbPhongBan.SelectedIndex = -1;
        }

        public void InitChucVu()
        {
            cbMaCV.DataSource = _chucVuServices.GetAllChucVu();
            cbMaCV.DisplayMember = "ChucVu1";
            cbMaCV.ValueMember = "idChucVu";
            cbMaCV.SelectedIndex = -1;
        }

        public void InitCbNoiCapCMND()
        {
            cbNoiCapCMND.DataSource = _thanhPhoServices.GetAllThanhPho();
            cbNoiCapCMND.DisplayMember = "tenTP";
            cbNoiCapCMND.ValueMember = "idThanhPho";
            cbNoiCapCMND.SelectedIndex = -1;
        }

        public void InitCbNguyenQuan()
        {
            cbNguyenQuan.DataSource = _thanhPhoServices.GetAllThanhPho();
            cbNguyenQuan.DisplayMember = "tenTP";
            cbNguyenQuan.ValueMember = "idThanhPho";
            cbNguyenQuan.SelectedIndex = -1;
        }

        public void InitCbThanhPho()
        {
            cbThanhPho.DataSource = _thanhPhoServices.GetAllThanhPho();
            cbThanhPho.DisplayMember = "tenTP";
            cbThanhPho.ValueMember = "idThanhPho";
            cbThanhPho.SelectedIndex = -1;
        }

        public void InitHonNhan()
        {

            List<ComboBoxItem> item = new List<ComboBoxItem> 
            {
                new ComboBoxItem { Text = "Độc Thân", Value = 1 },
                new ComboBoxItem { Text = "Đã kết hôn", Value = 2 },
                new ComboBoxItem { Text = "Ly Thân", Value = 3 },
                new ComboBoxItem { Text = "Ly Dị", Value = 4 },
                new ComboBoxItem { Text = "Goá Chồng", Value = 5 },
                new ComboBoxItem { Text = "Goá Vợ", Value = 6 }
            };

            cbTinhTrangHonNhan.DataSource = item;
            cbTinhTrangHonNhan.DisplayMember = "Text";
            cbTinhTrangHonNhan.ValueMember = "Value";
            cbTinhTrangHonNhan.SelectedIndex = 0;
        }

        public void InitCapBac()
        {
            cbCapBac.DataSource = _capBacServices.GetAllCapBac();
            cbCapBac.DisplayMember = "capBac1";
            cbCapBac.ValueMember = "idCapBac";
        }

        public void InitBienChe()
        {
            cbBienChe.DataSource = _bienCheServices.GetAllBienChe();
            cbBienChe.ValueMember = "idBienChe";
            cbBienChe.DisplayMember = "bienChe1";
        }

        #endregion
    }
}
