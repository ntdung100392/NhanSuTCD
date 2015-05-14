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
            InitPhongBan();
            InitThanhPho();
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
            if (rbtnNam.Checked == true)
            {
                sex = 0;
            }
            if (rBtnNu.Checked == true)
            {
                sex = 1;
            }
            if (_nhanVienServices.AddNhanVien(txtManv.Text.Trim(), Convert.ToInt32((cbTo.SelectedItem as To).idTo), txtUserName.Text.Trim(),
                "12345678x@X", Convert.ToInt32((cbPhanQuyen.SelectedItem as ComboBoxItem).Value),
                Convert.ToInt32((cbBienChe.SelectedItem as BienChe).idBienChe), Convert.ToInt32((cbCapBac.SelectedItem as CapBac).idCapBac),
                Convert.ToInt32((cbMaCV.SelectedItem as ChucVu).idChucVu), Convert.ToInt32((cbThanhPho.SelectedItem as ThanhPho).idThanhPho), 
                txtCongViecDangLam.Text.Trim(), txtTennv.Text, sex, datetimeNgaySinh.Value, txtNguyenquan.Text, txtdiachi.Text,
                txtHoKhau.Text, txtCMND.Text, datetimeCMND.Value, cbNoiCapCMND.SelectedText, "", txtSdt.Text.Trim(), txtNguoiBaoLanh.Text,
                txtMoiQuanHeNBL.Text, txtNoiCongTac.Text.Trim(), datetimeNgayVaoCang.Value, datetimeNamVaoST.Value, datetimeNgayNhapNgu.Value,
                cbTinhTrangHonNhan.SelectedText, ""))
            {
                MessageBox.Show("Bạn đã thêm nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Clear();
                txtTennv.Clear();
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
            var listPhongBan = _phongBanServices.GetAllPhongBan();
            cbPhongBan.DataSource = listPhongBan;
            cbPhongBan.DisplayMember = "tenPhong";
            cbPhongBan.ValueMember = "idPhong";
            cbPhongBan.SelectedIndex = -1;
        }

        public void InitChucVu()
        {
            List<ChucVu> listChucVu = _chucVuServices.GetAllChucVu();
            cbMaCV.DataSource = listChucVu;
            cbMaCV.DisplayMember = "ChucVu1";
            cbMaCV.ValueMember = "idChucVu";
            cbMaCV.SelectedIndex = -1;
        }

        public void InitThanhPho()
        {
            List<ThanhPho> listThanhPho = _thanhPhoServices.GetAllThanhPho();
            cbThanhPho.DataSource = listThanhPho;
            cbThanhPho.DisplayMember = "tenTP";
            cbThanhPho.ValueMember = "idThanhPho";
            cbThanhPho.SelectedIndex = -1;

            cbNoiCapCMND.DataSource = listThanhPho;
            cbNoiCapCMND.DisplayMember = "tenTP";
            cbNoiCapCMND.ValueMember = "idThanhPho";
            cbNoiCapCMND.SelectedIndex = -1;
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
            List<CapBac> listCapBac = _capBacServices.GetAllCapBac();
            cbCapBac.DataSource = listCapBac;
            cbCapBac.DisplayMember = "capBac1";
            cbCapBac.ValueMember = "idCapBac";
        }

        public void InitBienChe()
        {
            List<BienChe> listBienChe = _bienCheServices.GetAllBienChe();
            cbBienChe.DataSource = listBienChe;
            cbBienChe.ValueMember = "idBienChe";
            cbBienChe.DisplayMember = "bienChe1";
        }

        #endregion        
    }
}
