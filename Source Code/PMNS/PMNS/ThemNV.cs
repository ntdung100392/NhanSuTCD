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

        public ThemNV(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IDoiServices doiServices,
            IToServices toServices, ILoaiToServices loaiToServices, IThanhPhoServices thanhPhoServices, IChucVuServices chucVuServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._doiServices = doiServices;
            this._toServices = toServices;
            this._loaiToServices = loaiToServices;
            this._thanhPhoServices = thanhPhoServices;
            this._chucVuServices = chucVuServices;
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

        private void ThemNV_Load(object sender, EventArgs e)
        {
            txtPass.Visible = false;
            txtPQ.Visible = false;
            textBox1.Enabled = false;
            GetAllPhongBan();
            GetAllDoi();
            GetAllTo();
            GetAllLoaiTo();
            GetAllThanhPho();
            GetAllChucVu();
            GetHonNhan();
            GetAllEmployees();
            cbTo.SelectedIndex = -1;
            cbDoi.SelectedIndex = -1;
            cbLoaiTo.SelectedIndex = -1;
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
            if (_nhanVienServices.AddNhanVien(txtManv.Text.Trim(), Convert.ToInt32(cbTo.SelectedValue), textBox1.Text.Trim(),
                txtPass.Text.Trim(), 0, Convert.ToInt32(cbBienChe.SelectedValue), Convert.ToInt32(cbCapBac.SelectedValue),
                Convert.ToInt32(cbMaCV.SelectedValue), Convert.ToInt32(cbThanhPho.SelectedValue), txtCongViecDangLam.Text.Trim(),
                txtTennv.Text, sex, datetimeNgaySinh.Value, txtNguyenquan.Text, txtdiachi.Text, txtHoKhau.Text, txtCMND.Text,
                datetimeCMND.Value, cbNoiCapCMND.SelectedText, "", txtSdt.Text.Trim(), txtNguoiBaoLanh.Text,
                txtMoiQuanHeNBL.Text, "", datetimeNgayVaoCang.Value, datetimeNamVaoST.Value, datetimeNgayNhapNgu.Value,
                cbTinhTrangHonNhan.SelectedText, ""))
            {
                MessageBox.Show("Bạn đã thêm nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtManv.Clear();
                txtTennv.Clear();
            }
            else
            {
                MessageBox.Show("Đã Có Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void cbMaCV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaCV.SelectedIndex == -1)
            {
                txtChucVu.Text = string.Empty;
            }
            else
            {
                txtChucVu.Text = cbMaCV.SelectedValue.ToString();
            }
        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = txtManv.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPhongBan.SelectedIndex == -1)
            {
                label31.Text = string.Empty;
            }
            else
            {
                label31.Text = cbPhongBan.SelectedValue.ToString();
            }
        }

        #region Init
        public void GetAllEmployees()
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

        public void GetAllPhongBan()
        {
            List<Phong> listPhongBan = _phongBanServices.GetAllPhongBan();
            cbPhongBan.DataSource = listPhongBan;
            cbPhongBan.DisplayMember = "tenPhong";
            cbPhongBan.ValueMember = "idPhong";
            cbPhongBan.SelectedIndex = -1;
            txtChucVu.Enabled = false;
        }
        public void GetAllChucVu()
        {
            List<ChucVu> listChucVu = _chucVuServices.GetAllChucVu();
            cbMaCV.DataSource = listChucVu;
            cbMaCV.DisplayMember = "ChucVu1";
            cbMaCV.ValueMember = "idChucVu";
            cbMaCV.SelectedIndex = -1;
        }
        public void GetAllDoi()
        {
            List<Doi> listDoi = _doiServices.GetAllDoi();
            cbDoi.DataSource = listDoi;
            cbDoi.DisplayMember = "tenDoi";
            cbDoi.ValueMember = "idDoi";
            cbDoi.SelectedIndex = -1;
        }
        public void GetAllTo()
        {
            List<To> listTo = _toServices.GetAllTo();
            cbTo.DataSource = listTo;
            cbTo.DisplayMember = "tenTo";
            cbTo.ValueMember = "idTo";
            cbTo.SelectedIndex = -1;
        }
        public void GetAllLoaiTo()
        {
            List<LoaiTo> listLoaiTo = _loaiToServices.GetAllLoaiTo();
            cbLoaiTo.DataSource = listLoaiTo;
            cbLoaiTo.DisplayMember = "tenLoaiTo";
            cbLoaiTo.ValueMember = "idLoaiTo";
            cbLoaiTo.SelectedIndex = -1;
        }
        public void GetAllThanhPho()
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

        public void GetHonNhan()
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

        public bool AddEmployee(ThongTinNhanVIen empDetail)
        {
            if (empDetail != null)
            {

            }
            return false;
        }

        #endregion
    }
}
