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
    public partial class HopDongLaoDong : Form
    {
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IHopDongServices _hopDongServices;
        protected readonly ILoaiHopDongServices _loaiHopDongServices;
        private HopDongLaoDong updateHopDong;

        public HopDongLaoDong(INhanVienServices nhanVienServices, IHopDongServices hopDongServices,
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
            InitGridView();
            InitLoaiHopDong();
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

        }

        private void dataGridHDLD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            AutoCompleteStringCollection listMaNV = new AutoCompleteStringCollection();
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
