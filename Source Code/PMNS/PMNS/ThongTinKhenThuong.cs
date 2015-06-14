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
using PMNS.Services.Models;

namespace PMNS
{
    public partial class ThongTinKhenThuong : Form
    {

        #region Constructor Or Destructor

        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IKhenThuongServices _khenThuongServices;
        private AutoCompleteStringCollection listMaNV = new AutoCompleteStringCollection();
        private KhenThuong updateKhenThuong = new KhenThuong();
        public ThongTinKhenThuong(INhanVienServices nhanVienServices, IKhenThuongServices khenThuongServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._khenThuongServices = khenThuongServices;
            InitializeComponent();
        }

        #endregion

        #region Method Event
        private void ThongTinKhenThuong_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            txtTenNV.ReadOnly = true;
            InitGridView();
            InitAutoComplete("");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (updateKhenThuong != null)
            {
                try
                {
                    updateKhenThuong.namKhenThuong = datetimeNgayKhenThuong.Value;
                    updateKhenThuong.loaiKhenThuong = txtLoaiKhenThuong.Text;
                    updateKhenThuong.soSoKhenThuong = txtSoSoKhenThuong.Text;
                    updateKhenThuong.nguoiKhenThuong = txtNguoiKyKhenThuong.Text;
                    updateKhenThuong.thanhTichKhenThuong = txtThanhTichKhenThuong.Text;
                    updateKhenThuong.capKhenThuong = txtCapKhenThuong.Text;
                    updateKhenThuong.ghiChu = txtGhiChuKhenThuong.Text;
                    if (_khenThuongServices.UpdateThongTinKhenThuong(updateKhenThuong))
                    {
                        MessageBox.Show("Đã Chỉnh Sửa Thông Tin Khen Thưởng Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                        ClearAllText(this);
                        bntThem.Enabled = true;
                        btnSua.Enabled = false;
                        updateKhenThuong = null;
                        InitGridView();
                        dataGridKhenThuong.Refresh();
                        txtMaNV.ReadOnly = false;
                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng Kiểm Tra Lại Thông Tin", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    if (UserProfile.permission == 1)
                    {
                        MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã Có Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Thông Tin", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            try
            {
                KhenThuong khenThuong = new KhenThuong
                {
                    idNhanVien = _nhanVienServices.GetEmpByMaNV(txtMaNV.Text.Trim()).idNhanVien,
                    namKhenThuong = datetimeNgayKhenThuong.Value,
                    loaiKhenThuong = txtLoaiKhenThuong.Text,
                    soSoKhenThuong = txtSoSoKhenThuong.Text,
                    nguoiKhenThuong = txtNguoiKyKhenThuong.Text,
                    thanhTichKhenThuong = txtThanhTichKhenThuong.Text,
                    capKhenThuong = txtCapKhenThuong.Text,
                    ghiChu = txtGhiChuKhenThuong.Text
                };

                if (_khenThuongServices.AddThongTinKhenThuong(khenThuong))
                {
                    MessageBox.Show("Đã Thêm Thông Tin Khen Thưởng Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    ClearAllText(this);
                    InitGridView();
                    dataGridKhenThuong.Refresh();
                }
                else
                {
                    MessageBox.Show("Vui Lòng Kiểm Tra Lại Thông Tin", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (UserProfile.permission == 1)
                {
                    MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Đã Có Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridKhenThuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateKhenThuong = _khenThuongServices.GetKhenThuongById(Convert.ToInt32(dataGridKhenThuong.CurrentRow.Cells[0].Value.ToString()));
            txtMaNV.Text = updateKhenThuong.ThongTinNhanVIen.MaNV;
            txtTenNV.Text = updateKhenThuong.ThongTinNhanVIen.hoTen;
            datetimeNgayKhenThuong.Value = updateKhenThuong.namKhenThuong;
            txtLoaiKhenThuong.Text = updateKhenThuong.loaiKhenThuong;
            txtSoSoKhenThuong.Text = updateKhenThuong.soSoKhenThuong;
            txtNguoiKyKhenThuong.Text = updateKhenThuong.nguoiKhenThuong;
            txtThanhTichKhenThuong.Text = updateKhenThuong.thanhTichKhenThuong;
            txtCapKhenThuong.Text = updateKhenThuong.capKhenThuong;
            txtGhiChuKhenThuong.Text = updateKhenThuong.ghiChu;
            txtMaNV.ReadOnly = true;
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
        #endregion

        #region Method Init
        private void InitGridView()
        {
            dataGridKhenThuong.DataSource = _khenThuongServices.GetAllKhenThuong().OrderByDescending(x => x.namKhenThuong).ToList().Select(
                x => new
                {
                    MaNV = x.ThongTinNhanVIen.MaNV,
                    TenNhanVien = x.ThongTinNhanVIen.hoTen,
                    LoaiKhenThuong = x.loaiKhenThuong,
                    NamKhenThuong = x.namKhenThuong,
                    NguoiKhenThuong = x.nguoiKhenThuong,
                    SoKhenThuong = x.soSoKhenThuong,
                    ThanhTich = x.thanhTichKhenThuong,
                    GhiChu = x.ghiChu
                }).ToList();
        }

        private void InitAutoComplete(string maNV)
        {
            listMaNV.AddRange(_nhanVienServices.FindEmpByMaNV(maNV).ToArray());
            txtMaNV.AutoCompleteCustomSource = listMaNV;
        }
        #endregion

        #region DateTimePicker
        private void datetimeNgayKhenThuong_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgayKhenThuong.Format = DateTimePickerFormat.Custom;
            datetimeNgayKhenThuong.CustomFormat = "dd/MM/yyyy";
            txtNamKhenthuong.Text = datetimeNgayKhenThuong.Text;
        }
        #endregion
    }
}
