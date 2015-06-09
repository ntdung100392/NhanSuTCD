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

namespace PMNS
{
    public partial class ThongTin_TuyenDung : Form
    {

        #region Constructor Or Destructor
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IThongTinServices _thongTinServices;
        protected readonly string _loaiThongTin;
        private AutoCompleteStringCollection listMaNV = new AutoCompleteStringCollection();
        private TD_DD_BN_TV thongTinUpdate = new TD_DD_BN_TV();
        public ThongTin_TuyenDung(INhanVienServices nhanVienServices, IThongTinServices thongTinServices, string loaiThongTin)
        {
            this._nhanVienServices = nhanVienServices;
            this._thongTinServices = thongTinServices;
            this._loaiThongTin = loaiThongTin;
            InitializeComponent();
        }
        #endregion

        #region Form's Event
        private void ThongTin_TuyenDung_Load(object sender, EventArgs e)
        {
            txtHoTen.ReadOnly = true;
            btnSua.Enabled = false;
            txtNoiDung.Text = _loaiThongTin;
            InitGridView();
            InitAutoComplete("");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNv.Text.Trim();
            var emp = _nhanVienServices.GetEmpByMaNV(maNV);
            if (emp != null)
            {
                TD_DD_BN_TV thongTin = new TD_DD_BN_TV
                {
                    idNhanVien = emp.idNhanVien,
                    hoTenDD = txtTenNguoiKy.Text.Trim(),
                    noiDung = txtNoiDung.Text.Trim(),
                    namThucHien = datetimeNamThucHien.Value,
                    viTriCu = txtViTriCu.Text.Trim(),
                    viTriMoi = txtViTriMoi.Text.Trim(),
                    dienLaoDong = txtDienLaoDong.Text.Trim(),
                    dienHuongLuong = txtDienHuongLuong.Text.Trim(),
                    soQuyetDinh = txtSoQuyetDinh.Text.Trim(),
                    ngayKyQD = dateTimeNgayKy.Value,
                    ngayHieuLuc = dateTimeNgayHieuLuc.Value,
                    ghiChu = txtGhiChu.Text
                };
                if (_thongTinServices.AddThongTin(thongTin))
                {
                    MessageBox.Show("Đã Thêm Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                    ClearAllText(this);
                    InitGridView();
                    dataGridThongTin.Refresh();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Kiểm Tra Lại Thông Tin Nhập Vào!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không Tồn Tại Mã Nhân Viên Trong Dữ Liệu!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            thongTinUpdate.hoTenDD = txtTenNguoiKy.Text.Trim();
            thongTinUpdate.namThucHien = datetimeNamThucHien.Value;
            thongTinUpdate.ngayHieuLuc = dateTimeNgayHieuLuc.Value;
            thongTinUpdate.ngayKyQD = dateTimeNgayKy.Value;
            thongTinUpdate.noiDung = txtNoiDung.Text.Trim();
            thongTinUpdate.soQuyetDinh = txtSoQuyetDinh.Text.Trim();
            thongTinUpdate.viTriCu = txtViTriCu.Text.Trim();
            thongTinUpdate.viTriMoi = txtViTriMoi.Text.Trim();
            if (_thongTinServices.UpdateThongTin(thongTinUpdate))
            {
                MessageBox.Show("Đã Sửa Thông Tin Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                InitGridView();
                dataGridThongTin.Refresh();
                txtHoTen.ReadOnly = false;
                txtMaNv.ReadOnly = false;
                ClearAllText(this);
                txtNoiDung.Text = _loaiThongTin;
                thongTinUpdate = null;
                btnSua.Enabled = false;
                btnThem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtSearch.Text.Trim()))
            {
                InitGridView();
                dataGridThongTin.Refresh();
            }
            else
            {
                InitSearch(txtSearch.Text.Trim());
                dataGridThongTin.Refresh();
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

        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNv.Text.Trim() != null)
            {
                InitAutoComplete(txtMaNv.Text.Trim());
                var emp=_nhanVienServices.GetEmpByMaNV(txtMaNv.Text.Trim());
                if (emp != null)
                {
                    txtHoTen.Text = emp.hoTen;
                }
            }
        }

        private void dataGridThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thongTinUpdate = _thongTinServices.GetThongTinById(Convert.ToInt32(dataGridThongTin.CurrentRow.Cells[0].Value.ToString()));
            txtMaNv.Text = thongTinUpdate.ThongTinNhanVIen.MaNV;
            txtHoTen.Text = thongTinUpdate.ThongTinNhanVIen.hoTen;
            txtHoTen.ReadOnly = true;
            txtMaNv.ReadOnly = true;
            txtNoiDung.Text = thongTinUpdate.noiDung;
            txtTenNguoiKy.Text = thongTinUpdate.hoTenDD;
            txtSoQuyetDinh.Text = thongTinUpdate.soQuyetDinh;
            datetimeNamThucHien.Value = thongTinUpdate.namThucHien;
            dateTimeNgayHieuLuc.Value = Convert.ToDateTime(thongTinUpdate.ngayHieuLuc);
            dateTimeNgayKy.Value = Convert.ToDateTime(thongTinUpdate.ngayKyQD);
            txtViTriCu.Text = thongTinUpdate.viTriCu;
            txtViTriMoi.Text = thongTinUpdate.viTriMoi;
            txtDienLaoDong.Text = thongTinUpdate.dienLaoDong;
            txtDienHuongLuong.Text = thongTinUpdate.dienHuongLuong;
            txtGhiChu.Text = thongTinUpdate.ghiChu;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
        }
        #endregion

        #region Init
        private void InitGridView()
        {
            dataGridThongTin.DataSource = _thongTinServices.GetAllThongTin().Select(x =>
                    new
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

        private void InitAutoComplete(string maNV)
        {            
            listMaNV.AddRange(_nhanVienServices.FindEmpByMaNV(maNV).ToArray());
            txtMaNv.AutoCompleteCustomSource = listMaNV;
        }

        private void InitSearch(string maNV)
        {
            dataGridThongTin.DataSource = _thongTinServices.FindThongTin(maNV).Select(x =>
                    new
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
        #endregion

        #region DateTimePicker
        private void dateTimeNgayKy_ValueChanged(object sender, EventArgs e)
        {
            dateTimeNgayKy.Format = DateTimePickerFormat.Custom;
            dateTimeNgayKy.CustomFormat = "dd/MM/yyyy";
            txtNgayKyQD.Text = dateTimeNgayKy.Text;
        }

        private void dateTimeNgayHieuLuc_ValueChanged(object sender, EventArgs e)
        {
            dateTimeNgayHieuLuc.Format = DateTimePickerFormat.Custom;
            dateTimeNgayHieuLuc.CustomFormat = "dd/MM/yyyy";
            txtNgayHieuLuc.Text = dateTimeNgayHieuLuc.Text;
        }

        private void datetimeNamThucHien_ValueChanged(object sender, EventArgs e)
        {
            datetimeNamThucHien.Format = DateTimePickerFormat.Custom;
            datetimeNamThucHien.CustomFormat = "dd/MM/yyyy";
            txtNamThucHien.Text = datetimeNamThucHien.Text;
        }
        #endregion
    }
}
