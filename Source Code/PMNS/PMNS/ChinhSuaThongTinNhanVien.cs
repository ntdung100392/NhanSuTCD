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
    using PMNS.Services.Abstract;
    using PMNS.Entities.Models;
    using PMNS.Model;

    #endregion

    public delegate void OnClosing (bool close);

    public partial class ChinhSuaThongTinNhanVien : Form
    {
        #region Properties

        private ThongTinNhanVIen _empDetails;
        public event OnClosing OnClose;

        #endregion

        #region Constructor Or Destructor

        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        protected readonly IChucVuServices _chucVuServices;
        protected readonly ICapBacServices _capBacServices;
        protected readonly IBienCheServices _bienCheServices;
        protected readonly IThongTinTrinhDoServices _trinhDoServices;
        protected readonly IThongTinGiaDinhServices _giaDinhServices;
        public ChinhSuaThongTinNhanVien(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices,
            IThanhPhoServices thanhPhoServices, IChucVuServices chucVuServices,
            ICapBacServices capBacServices, IBienCheServices bienCheServices, IThongTinTrinhDoServices trinhDoServices, 
            IThongTinGiaDinhServices giaDinhServices, ThongTinNhanVIen empDetails)
        {
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._thanhPhoServices = thanhPhoServices;
            this._chucVuServices = chucVuServices;
            this._capBacServices = capBacServices;
            this._bienCheServices = bienCheServices;
            this._trinhDoServices = trinhDoServices;
            this._giaDinhServices = giaDinhServices;
            this._empDetails = empDetails;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void ChinhSuaThongTinNhanVien_Load(object sender, EventArgs e)
        {
            InitMain();
            EventLoading();
        }

        private void InitMain()
        {
            InitPhongBan();
            InitCbThanhPho();
            InitCbNoiCapCMND();
            InitCbNguyenQuan();
            InitChucVu();
            InitHonNhan();
            InitCapBac();
            InitBienChe();
            InitPermission();
            InitEmpInfo();
        }

        private void EventLoading()
        {
            cbBienChe.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCapBac.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaCV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNguyenQuan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNoiCapCMND.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhanQuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbThanhPho.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTinhTrangHonNhan.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        protected virtual void FireEvent(bool close)
        {
            if (OnClose != null)
            {
                OnClose(close);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FireEvent(true);
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int sex;
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
                _empDetails.idPhongDoiToLoai = Convert.ToInt32((cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai);
                _empDetails.permission = Convert.ToInt32((cbPhanQuyen.SelectedItem as ComboBoxItem).Value);
                _empDetails.idBienChe = Convert.ToInt32((cbBienChe.SelectedItem as BienChe).idBienChe);
                _empDetails.idCapBac = Convert.ToInt32((cbCapBac.SelectedItem as CapBac).idCapBac);
                _empDetails.idChucVu = Convert.ToInt32((cbMaCV.SelectedItem as ChucVu).idChucVu);
                _empDetails.idTP = Convert.ToInt32((cbThanhPho.SelectedItem as ThanhPho).idThanhPho);
                _empDetails.CongViecDangLam = txtCongViecDangLam.Text.Trim();
                _empDetails.hoTen = txtTennv.Text;
                _empDetails.gioiTinh = Convert.ToByte(sex);
                _empDetails.namSinh = datetimeNgaySinh.Value;
                _empDetails.nguyenQuan = (cbNguyenQuan.SelectedItem as ThanhPho).tenTP;
                _empDetails.noiOHienNay = txtdiachi.Text;
                _empDetails.hoKhau = txtHoKhau.Text;
                _empDetails.CMND = txtCMND.Text;
                _empDetails.ngayCapCMND = datetimeCMND.Value;
                _empDetails.noiCapCMND = (cbNoiCapCMND.SelectedItem as ThanhPho).tenTP;
                _empDetails.soDienThoaiNha = "";
                _empDetails.soDienThoaiDiDong = txtSdt.Text.Trim();
                _empDetails.nguoiBaoLanh = txtNguoiBaoLanh.Text;
                _empDetails.moiQuanHeBaoLanh = txtMoiQuanHeNBL.Text;
                _empDetails.noiCongTac = txtNoiCongTac.Text.Trim();
                _empDetails.ngayVaoCang = datetimeNgayVaoCang.Value;
                _empDetails.namVaoSongThan = datetimeNamVaoST.Value;
                _empDetails.ngayNhapNgu = datetimeNgayNhapNgu.Value;
                _empDetails.tinhTrangHonNhan = (cbTinhTrangHonNhan.SelectedItem as ComboBoxItem).Text;
                _empDetails.hinhAnhCaNhan = "";
                if (_nhanVienServices.UpdateEmpInfo(_empDetails))
                {
                    MessageBox.Show("Bạn đã cập nhật thông tin nhân viên thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAllText(this);
                    FireEvent(true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã Có Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnTrinhDoHocVan_Click(object sender, EventArgs e)
        {
            ThongTinTrinhDo trinhDoForm = new ThongTinTrinhDo(_nhanVienServices, _trinhDoServices);
            trinhDoForm.ShowDialog(this);
        }

        private void btnThongGiaDinh_Click(object sender, EventArgs e)
        {
            ThongTinGiaDinh giaDinhForm = new ThongTinGiaDinh(_nhanVienServices, _giaDinhServices, _empDetails);
            giaDinhForm.ShowDialog(this);
        }

        private void btnSuaHDLD_Click(object sender, EventArgs e)
        {
        }

        #endregion

        #region Method Init

        private void InitEmpInfo()
        {
            txtManv.Text = _empDetails.MaNV;
            txtManv.ReadOnly = true;
            txtTennv.Text = _empDetails.hoTen;
            txtTennv.ReadOnly = true;
            txtSdt.Text = _empDetails.soDienThoaiDiDong;
            cbCapBac.SelectedValue = _empDetails.idCapBac;
            cbBienChe.SelectedValue = _empDetails.idBienChe;
            cbMaCV.SelectedValue = _empDetails.idChucVu;
            if (_empDetails.gioiTinh == 1)
            {
                rBtnNu.Checked = true;
            }
            else
            {
                rbtnNam.Checked = true;
            }
            cbThanhPho.SelectedValue = _empDetails.idTP;
            cbNoiCapCMND.Text = _empDetails.noiCapCMND;
            cbNguyenQuan.Text = _empDetails.nguyenQuan;
            txtdiachi.Text = _empDetails.noiOHienNay;
            txtHoKhau.Text = _empDetails.hoKhau;
            txtCMND.Text = _empDetails.CMND;
            datetimeCMND.Value = Convert.ToDateTime(_empDetails.ngayCapCMND);
            datetimeNamVaoST.Value = Convert.ToDateTime(_empDetails.namVaoSongThan);
            datetimeNgaySinh.Value = Convert.ToDateTime(_empDetails.namSinh);
            datetimeNgayNhapNgu.Value = Convert.ToDateTime(_empDetails.ngayNhapNgu);
            datetimeNgayVaoCang.Value = Convert.ToDateTime(_empDetails.ngayVaoCang);
            txtNoiCongTac.Text = _empDetails.noiCongTac;
            txtCongViecDangLam.Text = _empDetails.CongViecDangLam;
            cbTinhTrangHonNhan.Text = _empDetails.tinhTrangHonNhan.ToString();
            cbPhanQuyen.SelectedValue = _empDetails.permission;
            txtNguoiBaoLanh.Text = _empDetails.nguoiBaoLanh;
            txtMoiQuanHeNBL.Text = _empDetails.moiQuanHeBaoLanh;
            btnSua.Enabled = true;
            cbPhongBan.SelectedValue = _empDetails.idPhongDoiToLoai;
        }

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

        #region Method DateTimePicker

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
    }
}
