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
    public partial class ThongTinKyLuat : Form
    {

        #region Constructor Or Destructor
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IKyLuatServices _kyLuatServices;
        private AutoCompleteStringCollection listMaNV = new AutoCompleteStringCollection();
        private KyLuat updateKyLuat = new KyLuat();
        public ThongTinKyLuat(INhanVienServices nhanVienServices, IKyLuatServices kyLuatServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._kyLuatServices = kyLuatServices;
            InitializeComponent();
        }
        #endregion

        #region Method Event
        private void ThongTinKyLuat_Load(object sender, EventArgs e)
        {
            txtTenNV.ReadOnly = true;
            btnSua.Enabled = false;
            InitGridView();
            InitAutoComplete("");
        }

        private void dataGridKyLuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateKyLuat = _kyLuatServices.GetKyLuatById(Convert.ToInt32(dataGridKyLuat.CurrentRow.Cells[0].Value.ToString()));
            txtMaNV.ReadOnly = true;
            txtMaNV.Text = updateKyLuat.ThongTinNhanVIen.MaNV;
            txtTenNV.Text = updateKyLuat.ThongTinNhanVIen.hoTen;
            datetimeNgayKyLuat.Value = updateKyLuat.ngayKyLuat;
            txtSoQDKL.Text = updateKyLuat.soQuyetDinhKyLuat;
            txtHanhVi.Text = updateKyLuat.hanhViBiKyLuat;
            txtNguoiKyQD.Text = updateKyLuat.nguoiKyQuyetDinh;
            txtLoaiKL.Text = updateKyLuat.loaiKyLuat;
            txtGhiChuKyLuat.Text = updateKyLuat.ghiChu;
            txtCapKyLuat.Text = updateKyLuat.capKyLuat;
            btnSua.Enabled = true;
            bntThem.Enabled = false;
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaNV.Text.Trim()))
            {
                InitAutoComplete(txtMaNV.Text.Trim());
                var emp = _nhanVienServices.GetEmpByMaNV(txtMaNV.Text.Trim());
                if (emp != null)
                {
                    txtTenNV.Text = emp.hoTen;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            try
            {
                KyLuat addKyLuat = new KyLuat
                {
                    idNhanVien = _nhanVienServices.GetEmpByMaNV(txtMaNV.Text.Trim()).idNhanVien,
                    loaiKyLuat = txtLoaiKL.Text,
                    ngayKyLuat = datetimeNgayKyLuat.Value,
                    nguoiKyQuyetDinh = txtNguoiKyQD.Text,
                    soQuyetDinhKyLuat = txtSoQDKL.Text,
                    ghiChu = txtGhiChuKyLuat.Text,
                    capKyLuat = txtCapKyLuat.Text,
                    hanhViBiKyLuat = txtHanhVi.Text
                };
                if (_kyLuatServices.AddThongTinKyLuat(addKyLuat))
                {
                    MessageBox.Show("Đã Thêm Thông Tin Kỷ Luật Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                    ClearAllText(this);
                    InitGridView();
                    dataGridKyLuat.Refresh();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Kiểm Tra Lại Thông Tin!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                updateKyLuat.ngayKyLuat = datetimeNgayKyLuat.Value;
                updateKyLuat.soQuyetDinhKyLuat = txtSoQDKL.Text;
                updateKyLuat.hanhViBiKyLuat = txtHanhVi.Text;
                updateKyLuat.nguoiKyQuyetDinh = txtNguoiKyQD.Text;
                updateKyLuat.loaiKyLuat = txtLoaiKL.Text;
                updateKyLuat.ghiChu = txtGhiChuKyLuat.Text;
                updateKyLuat.capKyLuat = txtCapKyLuat.Text;
                if (_kyLuatServices.UpdateThongTinKyLuat(updateKyLuat))
                {
                    MessageBox.Show("Đã Chỉnh Sửa Thông Tin Kỷ Luật Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                    ClearAllText(this);
                    btnSua.Enabled = false;
                    bntThem.Enabled = true;
                    updateKyLuat = null;
                    InitGridView();
                    dataGridKyLuat.Refresh();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Kiểm Tra Lại Thông Tin!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region DateTimePicker
        private void datetimeNgayNhapNgu_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgayKyLuat.Format = DateTimePickerFormat.Custom;
            datetimeNgayKyLuat.CustomFormat = "dd/MM/yyyy";
            txtNgayKL.Text = datetimeNgayKyLuat.Text;
        }
        #endregion

        #region Method Init
        private void InitGridView()
        {
            dataGridKyLuat.DataSource = _kyLuatServices.GetAllKyLuat().OrderByDescending(x => x.ngayKyLuat).ToList().Select(x =>
                new
                {
                    TenNhanVien = x.ThongTinNhanVIen.hoTen,
                    MaNV = x.ThongTinNhanVIen.MaNV,
                    SoQuyetDinh = x.soQuyetDinhKyLuat,
                    NguoiKyLuat = x.ngayKyLuat,
                    HanhViKyLuat = x.hanhViBiKyLuat,
                    LoaiKyLuat = x.loaiKyLuat,
                    NgayKyLuat = x.ngayKyLuat.ToString("dd/MM/yyyy")
                }).ToList();
        }

        private void InitAutoComplete(string maNV)
        {
            listMaNV.AddRange(_nhanVienServices.FindEmpByMaNV(maNV).ToArray());
            txtMaNV.AutoCompleteCustomSource = listMaNV;
        }
        #endregion
    }
}
