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
    public partial class QuanLyHopDong : Form
    {
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IHopDongServices _hopDongServices;
        protected readonly ILoaiHopDongServices _loaiHopDongServices;
        private HopDongLaoDong updateHopDong;
        private AutoCompleteStringCollection listMaNV = new AutoCompleteStringCollection();

        public QuanLyHopDong(INhanVienServices nhanVienServices, IHopDongServices hopDongServices,
            ILoaiHopDongServices loaiHopDongServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._hopDongServices = hopDongServices;
            this._loaiHopDongServices = loaiHopDongServices;
            InitializeComponent();
        }

        private void HopDongLaoDong_Load(object sender, EventArgs e)
        {
            cbLoaiHopDong.DropDownStyle = ComboBoxStyle.DropDownList;
            btnEdit.Enabled = false;
            txtTenNV.ReadOnly = true;
            InitGridView();
            InitLoaiHopDong();
            InitAutoComplete("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CheckAllNullTextBox(this);
            var emp = _nhanVienServices.GetEmpByMaNV(txtMaNv.Text.Trim());
            if (emp != null)
            {
                HopDongLaoDong hopDong = new HopDongLaoDong
                {
                    idNhanVien = emp.idNhanVien,
                    idLoaiHopDong = (cbLoaiHopDong.SelectedItem as LoaiHopDong).idLoaiHopDong,
                    chucDanh = txtChucDanh.Text.Trim(),
                    ngayBatDau = datetimeNgayBatDau.Value,
                    ngayKetThuc = dateTimeNgayKetThuc.Value,
                    nguoiBaoLanh_TTHDLD = txtNguoiBaoLanh.Text.Trim(),
                    soHopDong_TTHDLD = txtSoHopDong.Text.Trim(),
                    ghiChu = txtGhiChu.Text.Trim()
                };
                if (_hopDongServices.AddHopDongLaoDong(hopDong))
                {
                    MessageBox.Show("Đã Thêm Hợp Đồng Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    InitGridView();
                    dataGridHDLD.Refresh();
                }
                else
                {
                    MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridHDLD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateHopDong = _hopDongServices.GetHopDongById(Convert.ToInt32(dataGridHDLD.CurrentRow.Cells[0].Value.ToString()));
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaNv.Text.Trim()))
            {
                InitAutoComplete(txtMaNv.Text.Trim());
                var emp = _nhanVienServices.GetEmpByMaNV(txtMaNv.Text.Trim());
                if (emp != null)
                {
                    txtTenNV.Text = emp.hoTen;
                }
            }
        }

        private void CheckAllNullTextBox(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                {
                    if (String.IsNullOrEmpty(c.Text.Trim()))
                        MessageBox.Show("Thông Tin Đầu Vào Còn Thiếu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CheckAllNullTextBox(c);
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

        #region DateTime Picker
        private void datetimeNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgayBatDau.Format = DateTimePickerFormat.Custom;
            datetimeNgayBatDau.CustomFormat = "dd/MM/yyyy";
            txtNgayBatDau.Text = datetimeNgayBatDau.Text;
        }

        private void dateTimeNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            dateTimeNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dateTimeNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            txtNgayKetThuc.Text = dateTimeNgayKetThuc.Text;
        }
        #endregion

        #region Init
        private void InitAutoComplete(string maNV)
        {
            listMaNV.AddRange(_nhanVienServices.FindEmpByMaNV(maNV).ToArray());
            txtMaNv.AutoCompleteCustomSource = listMaNV;
        }

        private void InitGridView()
        {
            dataGridHDLD.DataSource = _hopDongServices.GetAllHopDong().Select(x =>
                new
                {
                    ID = x.idHopDongLaoDong,
                    MaNhanVien = x.ThongTinNhanVIen.MaNV,
                    TenNhanVien = x.ThongTinNhanVIen.hoTen,
                    LoaiHopDong = x.LoaiHopDong.loaiHopDong1,
                    SoHopDong = x.soHopDong_TTHDLD,
                    NgayBatDau = x.ngayBatDau,
                    NgayKetThuc = x.ngayKetThuc,
                    NguoiBaoLanh = x.nguoiBaoLanh_TTHDLD
                }).ToList();
            dataGridHDLD.Columns[0].Visible = false;
            dataGridHDLD.CurrentCell = null;
        }

        private void InitLoaiHopDong()
        {
            cbLoaiHopDong.DataSource = _loaiHopDongServices.GettAllLoaiHopDong();
            cbLoaiHopDong.DisplayMember = "loaiHopDong1";
            cbLoaiHopDong.ValueMember = "idLoaiHopDong";
        }
        #endregion
    }
}
