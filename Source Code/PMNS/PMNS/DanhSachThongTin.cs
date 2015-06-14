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
using PMNS.Services.Models;

namespace PMNS
{
    public partial class DanhSachThongTin : Form
    {

        #region Constructor Or Destructor

        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThongTinServices _thongTinServices;
        protected readonly string _loaiThongTin;
        public DanhSachThongTin(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IThongTinServices thongTinServices,
            string loaiThongTin)
        {
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._thongTinServices = thongTinServices;
            this._loaiThongTin = loaiThongTin;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void DanhSachThongTin_Load(object sender, EventArgs e)
        {
            EventLoading();
            InitGridView();
            InitPhongBan();
            InitQuy();
            InitThang();
        }

        private void EventLoading()
        {
            txtLenh.Text = _loaiThongTin;
            txtLenh.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void datetimeNgayKy_ValueChanged(object sender, EventArgs e)
        {
            //datetimeNgayKy.Format = DateTimePickerFormat.Custom;
            //datetimeNgayKy.CustomFormat = "dd/MM/yyyy";
            //txtNamThucHien.Text = datetimeNgayKy.Text;
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTenNV.Text.Trim()))
            {
                dataGridThongTin.DataSource = _thongTinServices.GetAllThongTin().Where(x => x.noiDung.Equals(_loaiThongTin)).ToList()
                    .Where(x => x.ThongTinNhanVIen.hoTen.Contains(txtTenNV.Text.Trim())).ToList().Select(x => new
                    {
                        id = x.idTDDDBNTV,
                        MaNhanVien = x.ThongTinNhanVIen.MaNV,
                        TenNhanVien = x.ThongTinNhanVIen.hoTen,
                        NguoiKyQuyetDinh = x.hoTenDD,
                        NamThucHien = x.namThucHien.Year,
                        NgayKy = Convert.ToDateTime(x.ngayKyQD).ToString("dd/MM/yyyy"),
                        NgayHieuLuc = Convert.ToDateTime(x.ngayHieuLuc).ToString("dd/MM/yyyy"),
                        SoQuyetDinh = x.soQuyetDinh,
                        ViTriCu = x.viTriCu,
                        ViTriMoi = x.viTriMoi
                    }).ToList();
                dataGridThongTin.Columns[0].Visible = false;
                dataGridThongTin.CurrentCell = null;
            }
        }

        private List<TD_DD_BN_TV> SearchingFilterData(List<TD_DD_BN_TV> filterList)
        {
            if (filterList.Count != 0)
            {
                if (!String.IsNullOrEmpty(txtNamThucHien.Text.Trim()))
                    filterList = filterList.Where(x => x.namThucHien.Year == Convert.ToDateTime(txtNamThucHien.Text.Trim()).Year).ToList();
                if (!String.IsNullOrEmpty(txtTenNV.Text.Trim()))
                    filterList = filterList.Where(x => x.ThongTinNhanVIen.hoTen.Contains(txtTenNV.Text.Trim())).ToList();
                if ((comboBoxPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai != 0)
                    filterList = filterList.Where(x => x.ThongTinNhanVIen.idPhongDoiToLoai == (comboThang.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai).ToList();
                if (Convert.ToInt32(comboThang.SelectedValue) != 0)
                    filterList = filterList.Where(x => x.namThucHien.Month == Convert.ToInt32(comboThang.SelectedValue)).ToList();
            }            
            return filterList;
        }


        private void txtNamThucHien_TextChanged(object sender, EventArgs e)
        {
            dataGridThongTin.DataSource = SearchingFilterData(_thongTinServices.GetAllThongTin().Where(x => x.noiDung.Equals(_loaiThongTin)).ToList())
                    .Where(x => x.ThongTinNhanVIen.hoTen.Contains(txtTenNV.Text.Trim())).ToList().Select(x => new
                    {
                        id = x.idTDDDBNTV,
                        MaNhanVien = x.ThongTinNhanVIen.MaNV,
                        TenNhanVien = x.ThongTinNhanVIen.hoTen,
                        NguoiKyQuyetDinh = x.hoTenDD,
                        NamThucHien = x.namThucHien.Year,
                        NgayKy = Convert.ToDateTime(x.ngayKyQD).ToString("dd/MM/yyyy"),
                        NgayHieuLuc = Convert.ToDateTime(x.ngayHieuLuc).ToString("dd/MM/yyyy"),
                        SoQuyetDinh = x.soQuyetDinh,
                        ViTriCu = x.viTriCu,
                        ViTriMoi = x.viTriMoi
                    }).ToList();
            dataGridThongTin.Columns[0].Visible = false;
            dataGridThongTin.CurrentCell = null;
        }

        private void comboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridThongTin.DataSource = SearchingFilterData(_thongTinServices.GetAllThongTin().Where(x => x.noiDung.Equals(_loaiThongTin)).ToList())
                    .Where(x => x.ThongTinNhanVIen.hoTen.Contains(txtTenNV.Text.Trim())).ToList().Select(x => new
                    {
                        id = x.idTDDDBNTV,
                        MaNhanVien = x.ThongTinNhanVIen.MaNV,
                        TenNhanVien = x.ThongTinNhanVIen.hoTen,
                        NguoiKyQuyetDinh = x.hoTenDD,
                        NamThucHien = x.namThucHien.Year,
                        NgayKy = Convert.ToDateTime(x.ngayKyQD).ToString("dd/MM/yyyy"),
                        NgayHieuLuc = Convert.ToDateTime(x.ngayHieuLuc).ToString("dd/MM/yyyy"),
                        SoQuyetDinh = x.soQuyetDinh,
                        ViTriCu = x.viTriCu,
                        ViTriMoi = x.viTriMoi
                    }).ToList();
            dataGridThongTin.Columns[0].Visible = false;
            dataGridThongTin.CurrentCell = null;
        }

        private void comboBoxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridThongTin.DataSource = SearchingFilterData(_thongTinServices.GetAllThongTin().Where(x => x.noiDung.Equals(_loaiThongTin)).ToList())
                    .Where(x => x.ThongTinNhanVIen.hoTen.Contains(txtTenNV.Text.Trim())).ToList().Select(x => new
                    {
                        id = x.idTDDDBNTV,
                        MaNhanVien = x.ThongTinNhanVIen.MaNV,
                        TenNhanVien = x.ThongTinNhanVIen.hoTen,
                        NguoiKyQuyetDinh = x.hoTenDD,
                        NamThucHien = x.namThucHien.Year,
                        NgayKy = Convert.ToDateTime(x.ngayKyQD).ToString("dd/MM/yyyy"),
                        NgayHieuLuc = Convert.ToDateTime(x.ngayHieuLuc).ToString("dd/MM/yyyy"),
                        SoQuyetDinh = x.soQuyetDinh,
                        ViTriCu = x.viTriCu,
                        ViTriMoi = x.viTriMoi
                    }).ToList();
            dataGridThongTin.Columns[0].Visible = false;
            dataGridThongTin.CurrentCell = null;
        }

        private void comboQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridThongTin.DataSource = SearchingFilterData(_thongTinServices.GetAllThongTin().Where(x => x.noiDung.Equals(_loaiThongTin)).ToList())
                    .Where(x => x.ThongTinNhanVIen.hoTen.Contains(txtTenNV.Text.Trim())).ToList().Select(x => new
                    {
                        id = x.idTDDDBNTV,
                        MaNhanVien = x.ThongTinNhanVIen.MaNV,
                        TenNhanVien = x.ThongTinNhanVIen.hoTen,
                        NguoiKyQuyetDinh = x.hoTenDD,
                        NamThucHien = x.namThucHien.Year,
                        NgayKy = Convert.ToDateTime(x.ngayKyQD).ToString("dd/MM/yyyy"),
                        NgayHieuLuc = Convert.ToDateTime(x.ngayHieuLuc).ToString("dd/MM/yyyy"),
                        SoQuyetDinh = x.soQuyetDinh,
                        ViTriCu = x.viTriCu,
                        ViTriMoi = x.viTriMoi
                    }).ToList();
            dataGridThongTin.Columns[0].Visible = false;
            dataGridThongTin.CurrentCell = null;
        }

        #endregion

        #region Method Init

        private void InitGridView()
        {
            dataGridThongTin.DataSource = _thongTinServices.GetAllThongTin().Where(x => x.noiDung.Equals(_loaiThongTin)).ToList()
                .Select(x => new
                {
                    id = x.idTDDDBNTV,
                    MaNhanVien = x.ThongTinNhanVIen.MaNV,
                    TenNhanVien = x.ThongTinNhanVIen.hoTen,
                    NguoiKyQuyetDinh = x.hoTenDD,
                    NamThucHien = x.namThucHien.Year,
                    NgayKy = x.ngayKyQD,
                    NgayHieuLuc = x.ngayHieuLuc,
                    SoQuyetDinh = x.soQuyetDinh,
                    ViTriCu = x.viTriCu,
                    ViTriMoi = x.viTriMoi
                }).ToList();
            dataGridThongTin.Columns[0].Visible = false;
            dataGridThongTin.CurrentCell = null;
        }

        private void InitPhongBan()
        {
            PhongDoiToLoaiTo firstItem = new PhongDoiToLoaiTo
            {
                idPhongDoiToLoai = 0,
                tenPhongDoiToLoai = "Tất Cả",
                maPhongDoiToLoai = "All",
                idCha = 0,
                ThongTinNhanVIens = null
            };
            List<PhongDoiToLoaiTo> listPhongBan = new List<PhongDoiToLoaiTo>();
            listPhongBan.Add(firstItem);
            listPhongBan.AddRange(_phongBanServices.GetAllPhongBan());
            comboBoxPhongBan.DataSource = listPhongBan;
            comboBoxPhongBan.DisplayMember = "tenPhongDoiToLoai";
            comboBoxPhongBan.ValueMember = "idPhongDoiToLoai";
        }

        private void InitQuy()
        {
            List<ComboBoxItem> item = new List<ComboBoxItem> 
            {
                new ComboBoxItem { Text = "Tất Cả", Value = 0 },
                new ComboBoxItem { Text = "Quý 1", Value = 1 },
                new ComboBoxItem { Text = "Quý 2", Value = 2 },
                new ComboBoxItem { Text = "Quý 3", Value = 3 },
                new ComboBoxItem { Text = "Quý 4", Value = 4 }
            };
            comboQuy.DataSource = item;
            comboQuy.DisplayMember = "Text";
            comboQuy.ValueMember = "Value";
        }

        private void InitThang()
        {
            List<ComboBoxItem> item = new List<ComboBoxItem> 
            {
                new ComboBoxItem { Text = "Tất Cả", Value = 0 },
                new ComboBoxItem { Text = "Tháng 1", Value = 1 },
                new ComboBoxItem { Text = "Tháng 2", Value = 2 },
                new ComboBoxItem { Text = "Tháng 3", Value = 3 },
                new ComboBoxItem { Text = "Tháng 4", Value = 4 },
                new ComboBoxItem { Text = "Tháng 5", Value = 5 },
                new ComboBoxItem { Text = "Tháng 6", Value = 6 },
                new ComboBoxItem { Text = "Tháng 7", Value = 7 },
                new ComboBoxItem { Text = "Tháng 8", Value = 8 },
                new ComboBoxItem { Text = "Tháng 9", Value = 9 },
                new ComboBoxItem { Text = "Tháng 10", Value = 10 },
                new ComboBoxItem { Text = "Tháng 11", Value = 11 },
                new ComboBoxItem { Text = "Tháng 12", Value = 12 },
            };
            comboThang.DataSource = item;
            comboThang.DisplayMember = "Text";
            comboThang.ValueMember = "Value";
        }

        #endregion
    }
}
