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
    using PMNS.Entities.Models;
    using PMNS.Services.Abstract;
    using PMNS.Services.Models;

    #endregion

    public partial class QuanLyHopDong : Form
    {
        #region Properties

        private HopDongLaoDong updateHopDong;
        private AutoCompleteStringCollection listMaNV = new AutoCompleteStringCollection();

        #endregion

        #region Constructor Or Destructor

        protected readonly INhanVienServices nhanVienServices;
        protected readonly IHopDongServices hopDongServices;
        protected readonly ILoaiHopDongServices loaiHopDongServices;
        public QuanLyHopDong(INhanVienServices nhanVienServices, IHopDongServices hopDongServices,
            ILoaiHopDongServices loaiHopDongServices)
        {
            this.nhanVienServices = nhanVienServices;
            this.hopDongServices = hopDongServices;
            this.loaiHopDongServices = loaiHopDongServices;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void HopDongLaoDong_Load(object sender, EventArgs e)
        {
            cbLoaiHopDong.DropDownStyle = ComboBoxStyle.DropDownList;
            btnEdit.Enabled = false;
            txtTenNV.ReadOnly = true;
            btnClear.Enabled = true;
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
            try
            {
                var emp = nhanVienServices.GetEmpByMaNV(txtMaNv.Text.Trim());
                if (emp != null)
                {
                    updateHopDong.idLoaiHopDong = (cbLoaiHopDong.SelectedItem as LoaiHopDong).idLoaiHopDong;
                    updateHopDong.chucDanh = txtChucDanh.Text.Trim();
                    updateHopDong.ngayBatDau = datetimeNgayBatDau.Value;
                    updateHopDong.ngayKetThuc = dateTimeNgayKetThuc.Value;
                    updateHopDong.nguoiBaoLanh_TTHDLD = txtNguoiBaoLanh.Text.Trim();
                    updateHopDong.soHopDong_TTHDLD = txtSoHopDong.Text.Trim();
                    updateHopDong.ghiChu = txtGhiChu.Text.Trim();
                    if (hopDongServices.UpdateHopDongLaoDong(updateHopDong))
                    {
                        MessageBox.Show("Đã Chỉnh Sửa Hợp Đồng Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                        InitGridView();
                        dataGridHDLD.Refresh();
                        ClearAllText(this);
                        txtMaNv.ReadOnly = false;
                        btnAdd.Enabled = true;
                        btnClear.Enabled = false;
                        btnEdit.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            txtMaNv.ReadOnly = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnEdit.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = nhanVienServices.GetEmpByMaNV(txtMaNv.Text.Trim());
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
                    if (hopDongServices.AddHopDongLaoDong(hopDong))
                    {
                        MessageBox.Show("Đã Thêm Hợp Đồng Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                        InitGridView();
                        dataGridHDLD.Refresh();
                        ClearAllText(this);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void dataGridHDLD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateHopDong = hopDongServices.GetHopDongById(Convert.ToInt32(dataGridHDLD.CurrentRow.Cells[0].Value.ToString()));
            txtMaNv.Text = updateHopDong.ThongTinNhanVIen.MaNV;
            txtMaNv.ReadOnly = true;
            txtTenNV.Text = updateHopDong.ThongTinNhanVIen.hoTen;
            txtSoHopDong.Text = updateHopDong.soHopDong_TTHDLD;
            txtNguoiBaoLanh.Text = updateHopDong.nguoiBaoLanh_TTHDLD;
            datetimeNgayBatDau.Value = updateHopDong.ngayBatDau;
            dateTimeNgayKetThuc.Value = updateHopDong.ngayKetThuc;
            txtGhiChu.Text = updateHopDong.ghiChu;
            cbLoaiHopDong.SelectedValue = updateHopDong.idLoaiHopDong;
            btnEdit.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;
        }

        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtMaNv.Text.Trim()))
            {
                InitAutoComplete(txtMaNv.Text.Trim());
                var emp = nhanVienServices.GetEmpByMaNV(txtMaNv.Text.Trim());
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

        #endregion

        #region Method DateTime Picker

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

        #region Method Init

        private void InitAutoComplete(string maNV)
        {
            listMaNV.AddRange(nhanVienServices.FindEmpByMaNV(maNV).ToArray());
            txtMaNv.AutoCompleteCustomSource = listMaNV;
        }

        private void InitGridView()
        {
            dataGridHDLD.DataSource = hopDongServices.GetAllHopDong().Select(x =>
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
            var listLoaiHopDong = loaiHopDongServices.GettAllLoaiHopDong();
            if (listLoaiHopDong.Count != 0)
            {
                foreach (var loaiHd in loaiHopDongServices.GettAllLoaiHopDong())
                {
                    if (loaiHd.idCha != 0)
                    {
                        foreach (var removeHd in listLoaiHopDong)
                        {
                            if (loaiHd.idCha == removeHd.idLoaiHopDong)
                            {
                                listLoaiHopDong.Remove(removeHd);
                                break;
                            }
                        }
                    }
                }
            }
            cbLoaiHopDong.DataSource = listLoaiHopDong;
            cbLoaiHopDong.DisplayMember = "loaiHopDong1";
            cbLoaiHopDong.ValueMember = "idLoaiHopDong";
        }

        #endregion
    }
}
