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
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IThongTinServices _thongTinServices;
        protected readonly string _loaiThongTin;

        private TD_DD_BN_TV thongTin = new TD_DD_BN_TV();
        public ThongTin_TuyenDung(INhanVienServices nhanVienServices, IThongTinServices thongTinServices, string loaiThongTin)
        {
            this._nhanVienServices = nhanVienServices;
            this._thongTinServices = thongTinServices;
            this._loaiThongTin = loaiThongTin;
            InitializeComponent();
        }

        #region Form's Event
        private void ThongTin_TuyenDung_Load(object sender, EventArgs e)
        {
            txtNoiDung.Text = _loaiThongTin;
            InitGridView();
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

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

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
            }
        }
        private void dataGridThongTin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            thongTin = _thongTinServices.GetThongTinById(Convert.ToInt32(dataGridThongTin.CurrentRow.Cells[0].Value.ToString()));
            txtMaNv.Text = thongTin.ThongTinNhanVIen.MaNV;
            txtTenNguoiKy.Text = thongTin.hoTenDD;
            txtSoQuyetDinh.Text = thongTin.soQuyetDinh;
            datetimeNamThucHien.Value = thongTin.namThucHien;
            dateTimeNgayHieuLuc.Value = Convert.ToDateTime(thongTin.ngayHieuLuc);
            dateTimeNgayKy.Value = Convert.ToDateTime(thongTin.ngayKyQD);
            txtViTriCu.Text = thongTin.viTriCu;
            txtViTriMoi.Text = thongTin.viTriMoi;
            txtDienLaoDong.Text = thongTin.dienLaoDong;
            txtDienHuongLuong.Text = thongTin.dienHuongLuong;
            txtGhiChu.Text = thongTin.ghiChu;
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
            dataGridThongTin.ClearSelection();
            dataGridThongTin.CurrentCell = null;
        }

        private void InitAutoComplete(string maNV)
        {
            AutoCompleteStringCollection listMaNV = new AutoCompleteStringCollection();
            listMaNV.AddRange(_nhanVienServices.FindEmpByMaNV(maNV).ToArray());
            txtMaNv.AutoCompleteCustomSource = listMaNV;
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
