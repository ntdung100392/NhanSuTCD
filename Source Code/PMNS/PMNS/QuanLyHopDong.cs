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

    using PMNS.Entities.Models;
    using PMNS.Services.Abstract;
    using PMNS.Services.Models;

    public partial class QuanLyHopDong : Form
    {
        #region Properties

        private ThongTinNhanVIen empDetails;
        private int idUpdateHopDong;
        private AutoCompleteStringCollection listMaNV = new AutoCompleteStringCollection();

        #endregion

        #region Constructor Or Destructor

        protected readonly INhanVienServices nhanVienServices;
        protected readonly IHopDongServices hopDongServices;
        protected readonly ILoaiHopDongServices loaiHopDongServices;
        public QuanLyHopDong(INhanVienServices nhanVienServices, IHopDongServices hopDongServices,
            ILoaiHopDongServices loaiHopDongServices, ThongTinNhanVIen empDetails)
        {
            this.nhanVienServices = nhanVienServices;
            this.hopDongServices = hopDongServices;
            this.loaiHopDongServices = loaiHopDongServices;
            this.empDetails = empDetails;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void HopDongLaoDong_Load(object sender, EventArgs e)
        {
            if (empDetails != null)
            {
                InitListHopDong();
                InitDetails();
            }
            else
            {
                InitGridView();
            }
            cbLoaiHopDong.DropDownStyle = ComboBoxStyle.DropDownList;
            btnEdit.Enabled = false;
            txtTenNV.ReadOnly = true;
            btnClear.Enabled = true;
            InitLoaiHopDong();
            InitAutoComplete("");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (empDetails != null)
            {
                UpdateContract(empDetails);
                InitListHopDong();
                dataGridHDLD.Refresh();
                ClearAllText(this);
                txtMaNv.ReadOnly = false;
                btnClear.Enabled = false;
                btnEdit.Enabled = false;
            }
            else
            {
                var emp = nhanVienServices.GetEmpByMaNV(txtMaNv.Text.Trim());
                if (emp != null)
                {
                    UpdateContract(emp);
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
            if (empDetails != null)
            {
                InsertContract(empDetails);
                InitListHopDong();
                dataGridHDLD.Refresh();
                ClearAllText(this);
            }
            else
            {
                var emp = nhanVienServices.GetEmpByMaNV(txtMaNv.Text.Trim());
                if (emp != null)
                {
                    InsertContract(emp);
                    InitGridView();
                    dataGridHDLD.Refresh();
                    ClearAllText(this);
                }
                else
                {
                    MessageBox.Show("Đã Có Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridHDLD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var hopDong = hopDongServices.GetHopDongById(Convert.ToInt32(dataGridHDLD.CurrentRow.Cells[0].Value.ToString()));
            idUpdateHopDong = hopDong.idHopDongLaoDong;
            txtMaNv.Text = hopDong.ThongTinNhanVIen.MaNV;
            txtMaNv.ReadOnly = true;
            txtTenNV.Text = hopDong.ThongTinNhanVIen.hoTen;
            txtSoHopDong.Text = hopDong.soHopDong_TTHDLD;
            txtNguoiBaoLanh.Text = hopDong.nguoiBaoLanh_TTHDLD;
            datetimeNgayBatDau.Value = hopDong.ngayBatDau;
            dateTimeNgayKetThuc.Value = hopDong.ngayKetThuc;
            txtGhiChu.Text = hopDong.ghiChu;
            cbLoaiHopDong.SelectedValue = hopDong.idLoaiHopDong;
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

        private void InitListHopDong()
        {
            dataGridHDLD.DataSource = empDetails.HopDongLaoDongs.OrderByDescending(hd => hd.ngayBatDau).ToList().Select(hd =>
                new
                {
                    ID = hd.idHopDongLaoDong,
                    MaNhanVien = hd.ThongTinNhanVIen.MaNV,
                    TenNhanVien = hd.ThongTinNhanVIen.hoTen,
                    LoaiHopDong = hd.LoaiHopDong.loaiHopDong1,
                    SoHopDong = hd.soHopDong_TTHDLD,
                    NgayBatDau = hd.ngayBatDau,
                    NgayKetThuc = hd.ngayKetThuc,
                    NguoiBaoLanh = hd.nguoiBaoLanh_TTHDLD
                }).ToList();
            dataGridHDLD.Columns[0].Visible = false;
            dataGridHDLD.CurrentCell = null;
        }

        private void InitDetails()
        {
            txtMaNv.Text = empDetails.MaNV;
            txtTenNV.Text = empDetails.hoTen;
            txtMaNv.ReadOnly = true;
        }

        #endregion

        #region Method

        private void InsertContract(ThongTinNhanVIen empInfo)
        {
            try
            {
                var hopDong = new HopDongLaoDong
                {
                    idLoaiHopDong = (cbLoaiHopDong.SelectedItem as LoaiHopDong).idLoaiHopDong,
                    chucDanh = txtChucDanh.Text.Trim(),
                    ngayBatDau = datetimeNgayBatDau.Value,
                    ngayKetThuc = dateTimeNgayKetThuc.Value,
                    nguoiBaoLanh_TTHDLD = txtNguoiBaoLanh.Text.Trim(),
                    soHopDong_TTHDLD = txtSoHopDong.Text.Trim(),
                    ghiChu = txtGhiChu.Text.Trim()
                };
                empInfo.HopDongLaoDongs.Add(hopDong);
                hopDongServices.CommitHopDongLaoDong();
                MessageBox.Show("Đã Thêm Hợp Đồng Thành Công!", "Thông Báo", MessageBoxButtons.OK);
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

        private void UpdateContract(ThongTinNhanVIen empInfo)
        {
            try
            {
                var hopDong = empInfo.HopDongLaoDongs.Where(hd => hd.idHopDongLaoDong == idUpdateHopDong).FirstOrDefault();
                hopDong.idLoaiHopDong = (cbLoaiHopDong.SelectedItem as LoaiHopDong).idLoaiHopDong;
                hopDong.chucDanh = txtChucDanh.Text.Trim();
                hopDong.ngayBatDau = datetimeNgayBatDau.Value;
                hopDong.ngayKetThuc = dateTimeNgayKetThuc.Value;
                hopDong.nguoiBaoLanh_TTHDLD = txtNguoiBaoLanh.Text.Trim();
                hopDong.soHopDong_TTHDLD = txtSoHopDong.Text.Trim();
                hopDong.ghiChu = txtGhiChu.Text.Trim();
                empInfo.HopDongLaoDongs.Where(hd => hd.idHopDongLaoDong == idUpdateHopDong).ToList().ForEach(hd => hd = hopDong);
                hopDongServices.CommitHopDongLaoDong();
                MessageBox.Show("Đã Chỉnh Sửa Hợp Đồng Thành Công!", "Thông Báo", MessageBoxButtons.OK);
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

        #endregion
    }
}
