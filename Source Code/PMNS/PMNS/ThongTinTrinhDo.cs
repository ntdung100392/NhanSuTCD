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
    using PMNS.Model;
    using PMNS.Services.Models;

    #endregion

    public partial class ThongTinTrinhDo : Form
    {
        #region Properties

        private AutoCompleteStringCollection listMaNV = new AutoCompleteStringCollection();
        private TrinhDo updateTrinhDo = new TrinhDo();

        #endregion

        #region Constructor Or Destructor

        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IThongTinTrinhDoServices _trinhDoServices;
        
        public ThongTinTrinhDo(INhanVienServices nhanVienServices, IThongTinTrinhDoServices trinhDoServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._trinhDoServices = trinhDoServices;
            InitializeComponent();
        }

        #endregion

        #region Method DatetimePicker

        private void datetimeTotNghiep_ValueChanged(object sender, EventArgs e)
        {
            datetimeTotNghiep.Format = DateTimePickerFormat.Custom;
            datetimeTotNghiep.CustomFormat = "dd/MM/yyyy";
            txtThoiGianTotNghiep.Text = datetimeTotNghiep.Text;
        }

        #endregion

        #region Method Init

        private void InitAutoComplete(string maNV)
        {
            listMaNV.AddRange(_nhanVienServices.FindEmpByMaNV(maNV).ToArray());
            txtMaNV.AutoCompleteCustomSource = listMaNV;
        }

        private void InitGridView()
        {
            dataGridTrinhDo.DataSource = _trinhDoServices.GetAllThongTinTrinhDo().Select(x => new
            {
                ID = x.idTrinhDo,
                TenNhanVien = x.ThongTinNhanVIen.hoTen,
                MaNV = x.ThongTinNhanVIen.MaNV,
                VanHoa = x.vanHoa,
                TrinhDo = x.trinhDo1,
                ChuyenNganh = x.chuyenNganh,
                LoaiHinh = x.loaiHinh,
                NoiDaoTao = x.noiDaoTao,
                NgayTotNghiep = Convert.ToDateTime(x.thoiGianTotNghiep).ToString("dd/MM/yyyy"),
                ChungChiPhu = x.bangCapPhu_CC
            }).ToList();
            dataGridTrinhDo.Columns[0].Visible = false;
            dataGridTrinhDo.CurrentCell = null;
        }

        #endregion

        #region Method Event

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() != null)
            {
                InitAutoComplete(txtMaNV.Text.Trim());
                var emp = _nhanVienServices.GetEmpByMaNV(txtMaNV.Text.Trim());
                if (emp != null)
                {
                    txtTenNV.Text = emp.hoTen;
                }
            }
        }

        private void ThongTinTrinhDo_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnClear.Enabled = false;
            InitGridView();
            InitAutoComplete("");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TrinhDo trinhDo = null;
            try
            {
                trinhDo = new TrinhDo
                {
                    idNhanVien = _nhanVienServices.GetEmpByMaNV(txtMaNV.Text.Trim()).idNhanVien,
                    vanHoa = txtVanHoa.Text,
                    trinhDo1 = txtTrinhDo.Text,
                    noiDaoTao = txtNoiDaoTao.Text,
                    chuyenNganh = txtChuyenNganh.Text,
                    loaiHinh = txtLoaiHinh.Text,
                    thoiGianTotNghiep = datetimeTotNghiep.Value,
                    bangCapPhu_CC = txtChungChi.Text
                };
            }
            catch (NullReferenceException ex)
            {
                if (UserProfile.permission == 1)
                {
                    MessageBox.Show(ex.ToString(), "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (_trinhDoServices.AddThongTinTrinhDo(trinhDo))
            {
                MessageBox.Show("Đã Thêm Thông Tin Trình Độ Thành Công!", "Thành Công!", MessageBoxButtons.OK);
                InitGridView();
                dataGridTrinhDo.Refresh();
                ClearAllText(this);
            }
            else
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                updateTrinhDo.vanHoa = txtVanHoa.Text;
                updateTrinhDo.trinhDo1 = txtTrinhDo.Text;
                updateTrinhDo.noiDaoTao = txtNoiDaoTao.Text;
                updateTrinhDo.chuyenNganh = txtChuyenNganh.Text;
                updateTrinhDo.loaiHinh = txtLoaiHinh.Text;
                updateTrinhDo.thoiGianTotNghiep = datetimeTotNghiep.Value;
                updateTrinhDo.bangCapPhu_CC = txtChungChi.Text;
            }
            catch (NullReferenceException ex)
            {
                if (UserProfile.permission == 1)
                {
                    MessageBox.Show("Lỗi!", ex.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi!", "Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (_trinhDoServices.UpdateThongTinTrinhDo(updateTrinhDo))
            {
                MessageBox.Show("Thành Công!", "Đã Cập Nhật Thông Tin Trình Độ Thành Công!", MessageBoxButtons.OK);
                InitGridView();
                dataGridTrinhDo.Refresh();
                ClearAllText(this);
                btnThem.Enabled = true;
                btnSua.Enabled = false;
                btnClear.Enabled = false;
                txtMaNV.ReadOnly = false;
            }
            else
            {
                MessageBox.Show("Lỗi!", "Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btnThem.Enabled = true;
            btnSua.Enabled = false;
        }

        private void dataGridTrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateTrinhDo = _trinhDoServices.GetThongTinTrinhDoById(Convert.ToInt32(dataGridTrinhDo.CurrentRow.Cells[0].Value.ToString()));
            if (updateTrinhDo != null)
            {
                txtMaNV.Text = updateTrinhDo.ThongTinNhanVIen.MaNV;
                txtTenNV.Text = updateTrinhDo.ThongTinNhanVIen.hoTen;
                txtVanHoa.Text = updateTrinhDo.vanHoa;
                txtTrinhDo.Text = updateTrinhDo.trinhDo1;
                txtNoiDaoTao.Text = updateTrinhDo.noiDaoTao;
                txtChuyenNganh.Text = updateTrinhDo.chuyenNganh;
                txtLoaiHinh.Text = updateTrinhDo.loaiHinh;
                datetimeTotNghiep.Value = Convert.ToDateTime(updateTrinhDo.thoiGianTotNghiep);
                txtChungChi.Text = updateTrinhDo.bangCapPhu_CC;
                btnSua.Enabled = true;
                btnThem.Enabled = false;
                btnClear.Enabled = true;
                txtMaNV.ReadOnly = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnClear.Enabled = false;
            txtMaNV.ReadOnly = false;
        }

        #endregion
    }
}
