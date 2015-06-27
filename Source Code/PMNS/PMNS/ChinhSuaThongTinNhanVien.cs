namespace PMNS
{
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

    #region Delegate

    public delegate void OnClosingEmpModifier(bool close);

    #endregion

    public partial class ChinhSuaThongTinNhanVien : Form
    {
        #region Properties

        private ThongTinNhanVIen empDetails;
        public event OnClosingEmpModifier OnClose;

        #endregion

        #region Constructor Or Destructor

        protected readonly IHopDongServices hopDongServices;
        protected readonly ILoaiHopDongServices loaiHopDongServices;
        protected readonly INhanVienServices nhanVienServices;
        protected readonly IPhongBanServices phongBanServices;
        protected readonly IThanhPhoServices thanhPhoServices;
        protected readonly IChucVuServices chucVuServices;
        protected readonly ICapBacServices capBacServices;
        protected readonly IBienCheServices bienCheServices;
        protected readonly IThongTinTrinhDoServices thongTinTrinhDoServices;
        protected readonly IThongTinGiaDinhServices giaDinhServices;
        protected readonly ITrinhDoServices trinhDoServices;

        public ChinhSuaThongTinNhanVien(IHopDongServices hopDongServices, ILoaiHopDongServices loaiHopDongServices,
            INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IThanhPhoServices thanhPhoServices,
            IChucVuServices chucVuServices, ICapBacServices capBacServices, IBienCheServices bienCheServices,
            IThongTinTrinhDoServices thongTinTrinhDoServices, ITrinhDoServices trinhDoServices
            , IThongTinGiaDinhServices giaDinhServices, ThongTinNhanVIen empDetails)
        {
            this.hopDongServices = hopDongServices;
            this.loaiHopDongServices = loaiHopDongServices;
            this.nhanVienServices = nhanVienServices;
            this.phongBanServices = phongBanServices;
            this.thanhPhoServices = thanhPhoServices;
            this.chucVuServices = chucVuServices;
            this.capBacServices = capBacServices;
            this.bienCheServices = bienCheServices;
            this.thongTinTrinhDoServices = thongTinTrinhDoServices;
            this.giaDinhServices = giaDinhServices;
            this.trinhDoServices = trinhDoServices;
            this.empDetails = empDetails;
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
                empDetails.idPhongDoiToLoai = Convert.ToInt32((cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai);
                empDetails.permission = Convert.ToInt32((cbPhanQuyen.SelectedItem as ComboBoxItem).Value);
                empDetails.idBienChe = Convert.ToInt32((cbBienChe.SelectedItem as BienChe).idBienChe);
                empDetails.idCapBac = Convert.ToInt32((cbCapBac.SelectedItem as CapBac).idCapBac);
                empDetails.idChucVu = Convert.ToInt32((cbMaCV.SelectedItem as ChucVu).idChucVu);
                empDetails.idTP = Convert.ToInt32((cbThanhPho.SelectedItem as ThanhPho).idThanhPho);
                empDetails.CongViecDangLam = txtCongViecDangLam.Text.Trim();
                empDetails.hoTen = txtTennv.Text;
                empDetails.gioiTinh = Convert.ToByte(sex);
                empDetails.namSinh = datetimeNgaySinh.Value;
                empDetails.nguyenQuan = (cbNguyenQuan.SelectedItem as ThanhPho).tenTP;
                empDetails.noiOHienNay = txtdiachi.Text;
                empDetails.hoKhau = txtHoKhau.Text;
                empDetails.CMND = txtCMND.Text;
                empDetails.ngayCapCMND = datetimeCMND.Value;
                empDetails.noiCapCMND = (cbNoiCapCMND.SelectedItem as ThanhPho).tenTP;
                empDetails.soDienThoaiNha = "";
                empDetails.soDienThoaiDiDong = txtSdt.Text.Trim();
                empDetails.nguoiBaoLanh = txtNguoiBaoLanh.Text;
                empDetails.moiQuanHeBaoLanh = txtMoiQuanHeNBL.Text;
                empDetails.noiCongTac = txtNoiCongTac.Text.Trim();
                empDetails.ngayVaoCang = datetimeNgayVaoCang.Value;
                empDetails.namVaoSongThan = datetimeNamVaoST.Value;
                empDetails.ngayNhapNgu = datetimeNgayNhapNgu.Value;
                empDetails.tinhTrangHonNhan = (cbTinhTrangHonNhan.SelectedItem as ComboBoxItem).Text;
                empDetails.hinhAnhCaNhan = "";
                if (nhanVienServices.UpdateEmpInfo(empDetails))
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
            catch (Exception ex)
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
            ThongTinTrinhDo trinhDoForm = new ThongTinTrinhDo(nhanVienServices, thongTinTrinhDoServices, trinhDoServices);
            trinhDoForm.ShowDialog(this);
        }

        private void btnThongGiaDinh_Click(object sender, EventArgs e)
        {
            ThongTinGiaDinh giaDinhForm = new ThongTinGiaDinh(nhanVienServices, giaDinhServices, empDetails);
            giaDinhForm.ShowDialog(this);
        }

        private void btnSuaHDLD_Click(object sender, EventArgs e)
        {
            var hopDongDetails = hopDongServices.GetHopDongByEmpId(empDetails.idNhanVien)
                .OrderByDescending(hd => hd.ngayBatDau).FirstOrDefault();
            if (hopDongDetails != null)
            {
                ChinhSuaHopDongLaoDong editorContractForm = new ChinhSuaHopDongLaoDong(hopDongServices, loaiHopDongServices,
                nhanVienServices, hopDongDetails);
                editorContractForm.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Thông Tin Hợp Đồng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Method Init

        private void InitEmpInfo()
        {
            txtManv.Text = empDetails.MaNV;
            txtManv.ReadOnly = true;
            txtTennv.Text = empDetails.hoTen;
            txtTennv.ReadOnly = true;
            txtSdt.Text = empDetails.soDienThoaiDiDong;
            cbCapBac.SelectedValue = empDetails.idCapBac;
            cbBienChe.SelectedValue = empDetails.idBienChe;
            cbMaCV.SelectedValue = empDetails.idChucVu;
            if (empDetails.gioiTinh == 1)
            {
                rBtnNu.Checked = true;
            }
            else
            {
                rbtnNam.Checked = true;
            }
            cbThanhPho.SelectedValue = empDetails.idTP;
            cbNoiCapCMND.Text = empDetails.noiCapCMND;
            cbNguyenQuan.Text = empDetails.nguyenQuan;
            txtdiachi.Text = empDetails.noiOHienNay;
            txtHoKhau.Text = empDetails.hoKhau;
            txtCMND.Text = empDetails.CMND;
            datetimeCMND.Value = Convert.ToDateTime(empDetails.ngayCapCMND);
            datetimeNamVaoST.Value = Convert.ToDateTime(empDetails.namVaoSongThan);
            datetimeNgaySinh.Value = Convert.ToDateTime(empDetails.namSinh);
            datetimeNgayNhapNgu.Value = Convert.ToDateTime(empDetails.ngayNhapNgu);
            datetimeNgayVaoCang.Value = Convert.ToDateTime(empDetails.ngayVaoCang);
            txtNoiCongTac.Text = empDetails.noiCongTac;
            txtCongViecDangLam.Text = empDetails.CongViecDangLam;
            cbTinhTrangHonNhan.Text = empDetails.tinhTrangHonNhan.ToString();
            cbPhanQuyen.SelectedValue = empDetails.permission;
            txtNguoiBaoLanh.Text = empDetails.nguoiBaoLanh;
            txtMoiQuanHeNBL.Text = empDetails.moiQuanHeBaoLanh;
            btnSua.Enabled = true;
            cbPhongBan.SelectedValue = empDetails.idPhongDoiToLoai;
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
            cbPhongBan.DataSource = phongBanServices.GetAllPhongBan();
            cbPhongBan.DisplayMember = "tenPhongDoiToLoai";
            cbPhongBan.ValueMember = "idPhongDoiToLoai";
            cbPhongBan.SelectedIndex = -1;
        }

        public void InitChucVu()
        {
            cbMaCV.DataSource = chucVuServices.GetAllChucVu();
            cbMaCV.DisplayMember = "ChucVu1";
            cbMaCV.ValueMember = "idChucVu";
            cbMaCV.SelectedIndex = -1;
        }

        public void InitCbNoiCapCMND()
        {
            cbNoiCapCMND.DataSource = thanhPhoServices.GetAllThanhPho();
            cbNoiCapCMND.DisplayMember = "tenTP";
            cbNoiCapCMND.ValueMember = "idThanhPho";
            cbNoiCapCMND.SelectedIndex = -1;
        }

        public void InitCbNguyenQuan()
        {
            cbNguyenQuan.DataSource = thanhPhoServices.GetAllThanhPho();
            cbNguyenQuan.DisplayMember = "tenTP";
            cbNguyenQuan.ValueMember = "idThanhPho";
            cbNguyenQuan.SelectedIndex = -1;
        }

        public void InitCbThanhPho()
        {
            cbThanhPho.DataSource = thanhPhoServices.GetAllThanhPho();
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
            cbCapBac.DataSource = capBacServices.GetAllCapBac();
            cbCapBac.DisplayMember = "capBac1";
            cbCapBac.ValueMember = "idCapBac";
        }

        public void InitBienChe()
        {
            cbBienChe.DataSource = bienCheServices.GetAllBienChe();
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
