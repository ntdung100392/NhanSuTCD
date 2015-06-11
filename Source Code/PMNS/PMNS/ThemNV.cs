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

        #region Constructor Or Destructor
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        protected readonly IChucVuServices _chucVuServices;
        protected readonly ICapBacServices _capBacServices;
        protected readonly IBienCheServices _bienCheServices;
        private ThongTinNhanVIen empUpdate = new ThongTinNhanVIen();
        public ThemNV(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices,
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
        #endregion

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
            txtMoiQuanHeNBL.Enabled = false;
            rbtnNam.Checked = true;
            btnSua.Enabled = false;
            cbBienChe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCapBac.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaCV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNguyenQuan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNoiCapCMND.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhanQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbThanhPho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinhTrangHonNhan.DropDownStyle = ComboBoxStyle.DropDownList;
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
            try
            {
                int sex ;
                if (rbtnNam.Checked == true)
                {
                    sex = 0;
                }
                else
                {
                    sex = 1;
                }
                if (rBtnNu.Checked == true)
                {
                    sex = 1;
                }
                else
                {
                    sex = 0;
                }
                ThongTinNhanVIen emp = new ThongTinNhanVIen
                {
                    MaNV = txtManv.Text.Trim(),
                    idPhongDoiToLoai = Convert.ToInt32((cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai),
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
                    ClearAllText(this);
                    InitEmployees();
                    dataGridNhanVien.Refresh();
                }
                else
                {
                    MessageBox.Show("Đã Có Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
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
                empUpdate.idPhongDoiToLoai = Convert.ToInt32((cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai);
                empUpdate.permission = Convert.ToInt32((cbPhanQuyen.SelectedItem as ComboBoxItem).Value);
                empUpdate.idBienChe = Convert.ToInt32((cbBienChe.SelectedItem as BienChe).idBienChe);
                empUpdate.idCapBac = Convert.ToInt32((cbCapBac.SelectedItem as CapBac).idCapBac);
                empUpdate.idChucVu = Convert.ToInt32((cbMaCV.SelectedItem as ChucVu).idChucVu);
                empUpdate.idTP = Convert.ToInt32((cbThanhPho.SelectedItem as ThanhPho).idThanhPho);
                empUpdate.CongViecDangLam = txtCongViecDangLam.Text.Trim();
                empUpdate.hoTen = txtTennv.Text;
                empUpdate.gioiTinh = Convert.ToByte(sex);
                empUpdate.namSinh = datetimeNgaySinh.Value;
                empUpdate.nguyenQuan = (cbNguyenQuan.SelectedItem as ThanhPho).tenTP;
                empUpdate.noiOHienNay = txtdiachi.Text;
                empUpdate.hoKhau = txtHoKhau.Text;
                empUpdate.CMND = txtCMND.Text;
                empUpdate.ngayCapCMND = datetimeCMND.Value;
                empUpdate.noiCapCMND = (cbNoiCapCMND.SelectedItem as ThanhPho).tenTP;
                empUpdate.soDienThoaiNha = "";
                empUpdate.soDienThoaiDiDong = txtSdt.Text.Trim();
                empUpdate.nguoiBaoLanh = txtNguoiBaoLanh.Text;
                empUpdate.moiQuanHeBaoLanh = txtMoiQuanHeNBL.Text;
                empUpdate.noiCongTac = txtNoiCongTac.Text.Trim();
                empUpdate.ngayVaoCang = datetimeNgayVaoCang.Value;
                empUpdate.namVaoSongThan = datetimeNamVaoST.Value;
                empUpdate.ngayNhapNgu = datetimeNgayNhapNgu.Value;
                empUpdate.tinhTrangHonNhan = (cbTinhTrangHonNhan.SelectedItem as ComboBoxItem).Text;
                empUpdate.hinhAnhCaNhan = "";
                if (_nhanVienServices.UpdateEmpInfo(empUpdate))
                {
                    MessageBox.Show("Bạn đã cập nhật thông tin nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllText(this);
                    InitEmployees();
                    dataGridNhanVien.Refresh();
                }
                else
                {
                    MessageBox.Show("Đã Có Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        private void txtManv_TextChanged(object sender, EventArgs e)
        {
            txtUserName.Text = txtManv.Text;
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

        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        private void dataGridNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            empUpdate = _nhanVienServices.GetEmpById(Convert.ToInt32(dataGridNhanVien.CurrentRow.Cells[0].Value.ToString()));
            txtManv.Text = empUpdate.MaNV;
            txtManv.ReadOnly = true;
            txtTennv.Text = empUpdate.hoTen;
            txtTennv.ReadOnly = true;
            txtSdt.Text = empUpdate.soDienThoaiDiDong;
            cbCapBac.SelectedValue = empUpdate.idCapBac;
            cbBienChe.SelectedValue = empUpdate.idBienChe;
            cbMaCV.SelectedValue = empUpdate.idChucVu;
            if (empUpdate.gioiTinh == 1)
            {
                rBtnNu.Checked = true;
            }
            else
            {
                rbtnNam.Checked = true;
            }
            cbThanhPho.SelectedValue = empUpdate.idTP;
            cbNoiCapCMND.Text = empUpdate.noiCapCMND;
            cbNguyenQuan.Text = empUpdate.nguyenQuan;
            txtdiachi.Text = empUpdate.noiOHienNay;
            txtHoKhau.Text = empUpdate.hoKhau;
            txtCMND.Text = empUpdate.CMND;
            datetimeCMND.Value = Convert.ToDateTime(empUpdate.ngayCapCMND);
            datetimeNamVaoST.Value = Convert.ToDateTime(empUpdate.namVaoSongThan);
            datetimeNgaySinh.Value = Convert.ToDateTime(empUpdate.namSinh);
            datetimeNgayNhapNgu.Value = Convert.ToDateTime(empUpdate.ngayNhapNgu);
            datetimeNgayVaoCang.Value = Convert.ToDateTime(empUpdate.ngayVaoCang);
            txtNoiCongTac.Text = empUpdate.noiCongTac;
            txtCongViecDangLam.Text = empUpdate.CongViecDangLam;
            cbTinhTrangHonNhan.Text = empUpdate.tinhTrangHonNhan.ToString();
            cbPhanQuyen.SelectedValue = empUpdate.permission;
            txtNguoiBaoLanh.Text = empUpdate.nguoiBaoLanh;
            txtMoiQuanHeNBL.Text = empUpdate.moiQuanHeBaoLanh;
            btnSua.Enabled = true;
            cbPhongBan.SelectedValue = empUpdate.idPhongDoiToLoai;
        }
        #endregion

        #region Init
        public void InitPermission()
        {
            List<ComboBoxItem> item = new List<ComboBoxItem> 
            {
                new ComboBoxItem { Text = "User", Value = 0 },
                new ComboBoxItem { Text = "Admin", Value = 1 }
            };

            cbPhanQuyen.DataSource = item;
            cbPhanQuyen.DisplayMember = "Text";
            cbPhanQuyen.ValueMember = "Value";
        }
        public void InitEmployees()
        {
            var listNhanVien = _nhanVienServices.GetAllEmployees();
            dataGridNhanVien.DataSource = listNhanVien.OrderBy(x => x.hoTen).ToList().Select(x =>
                new
                {
                    ID = x.idNhanVien,
                    HoTen = x.hoTen,
                    MaNV = x.MaNV,
                    NamSinh = x.namSinh.ToString("dd/MM/yyyy"),
                    CapBac = x.CapBac.capBac1,
                    ChucVu = x.ChucVu.ChucVu1,
                    PhongBan = x.PhongDoiToLoaiTo.tenPhongDoiToLoai,
                    HeBienChe = x.BienChe.bienChe1,
                    NgayVaoCang = Convert.ToDateTime(x.ngayVaoCang).ToString("dd/MM/yyyy"),
                    NamVaoST = Convert.ToDateTime(x.namVaoSongThan).Year,
                    NgayNhapNgu = Convert.ToDateTime(x.ngayNhapNgu).ToString("dd/MM/yyyy"),
                    NguoiBaoLanh = x.nguoiBaoLanh,
                    MoiQuanHe = x.moiQuanHeBaoLanh
                }).ToList();
            dataGridNhanVien.Columns[0].Visible = false;
            dataGridNhanVien.CurrentCell = null;
        }

        public void InitPhongBan()
        {
            cbPhongBan.DataSource = _phongBanServices.GetAllPhongBan();
            cbPhongBan.DisplayMember = "tenPhongDoiToLoai";
            cbPhongBan.ValueMember = "idPhongDoiToLoai";
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

        private void rbtnNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}
