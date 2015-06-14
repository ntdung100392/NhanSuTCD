using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMNS.Entities.Models;
using PMNS.Services.Abstract;
using PMNS.Services.Models;
using PMNS.Model;

namespace PMNS
{
    public partial class DanhSachNhanVien : Form
    {

        #region Constructor Or Destructor

        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        protected readonly IChucVuServices _chucVuServices;
        protected readonly ICapBacServices _capBacServices;
        protected readonly IBienCheServices _bienCheServices;
        protected readonly ILoaiHopDongServices _loaiHopDongServices;
        protected readonly IThongTinTrinhDoServices _trinhDoServices;
        protected readonly IThongTinGiaDinhServices _giaDinhServices;
        private List<ThongTinNhanVIen> _fullEmpList;
        public DanhSachNhanVien(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices,
            IThanhPhoServices thanhPhoServices, IChucVuServices chucVuServices,
            ICapBacServices capBacServices, IBienCheServices bienCheServices, ILoaiHopDongServices loaiHopDongServices,
            IThongTinTrinhDoServices trinhDoServices, IThongTinGiaDinhServices giaDinhServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._thanhPhoServices = thanhPhoServices;
            this._chucVuServices = chucVuServices;
            this._capBacServices = capBacServices;
            this._bienCheServices = bienCheServices;
            this._loaiHopDongServices = loaiHopDongServices;
            this._trinhDoServices = trinhDoServices;
            this._giaDinhServices = giaDinhServices;
            InitializeComponent();
        }

        #endregion

        #region Init Data
        private void InitGridView()
        {
            ReFormatCollumnGridView(_fullEmpList);
        }

        private void InitRefreshGridView(bool close)
        {
            InitGridView();
            dataGridDanhSachNV.Refresh();
            btnViewDetails.Enabled = false;
            btnEditDetails.Enabled = false;
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
            cbPhongBan.DataSource = listPhongBan;
            cbPhongBan.DisplayMember = "tenPhongDoiToLoai";
            cbPhongBan.ValueMember = "idPhongDoiToLoai";
        }

        private void ReFormatCollumnGridView(List<ThongTinNhanVIen> empList)
        {
            dataGridDanhSachNV.DataSource = empList.Select(x =>
                new
                {
                    ID = x.idNhanVien,
                    HoTen = x.hoTen,
                    MaNV = x.MaNV,
                    NamSinh = x.namSinh.ToString("dd/MM/yyyy"),
                    CapBac = x.CapBac.capBac1,
                    ChucVu = x.ChucVu.ChucVu1,
                    PhongBan = x.PhongDoiToLoaiTo.tenPhongDoiToLoai,
                    HeBienChe = x.BienChe.bienChe1,
                    NgayVaoCang = Convert.ToDateTime(x.ngayVaoCang).ToString("dd/MM/yyyy"),
                    NamVaoST = Convert.ToDateTime(x.namVaoSongThan).Year,
                    NgayNhapNgu = Convert.ToDateTime(x.ngayNhapNgu).ToString("dd/MM/yyyy"),
                    NguoiBaoLanh = x.nguoiBaoLanh,
                    MoiQuanHe = x.moiQuanHeBaoLanh
                }).ToList();
            dataGridDanhSachNV.Columns[0].Visible = false;
            dataGridDanhSachNV.CurrentCell = null;
        }
        #endregion

        #region Form's Event

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            this._fullEmpList = _nhanVienServices.GetAllEmployees();
            cbPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            btnEditDetails.Enabled = false;
            btnViewDetails.Enabled = false;
            InitGridView();
            InitPhongBan();
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterGridView(txtMaNhanVien.Text.Trim(), txtTenNhanVien.Text.Trim(),
                (cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai);
        }

        private void dataGridDanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                var _emp = _nhanVienServices.GetEmpById(Convert.ToInt32(dataGridDanhSachNV.CurrentRow.Cells[0].Value.ToString()));
                ChinhSuaThongTinNhanVien editEmpInfo = new ChinhSuaThongTinNhanVien(_nhanVienServices, _phongBanServices, _thanhPhoServices,
                    _chucVuServices, _capBacServices, _bienCheServices, _trinhDoServices, _giaDinhServices, _emp);
                editEmpInfo.OnClose += new OnClosing(InitRefreshGridView);
                editEmpInfo.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Đăng Nhập Vào Chức Năng Này!", "Permission Denied!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {
            FilterGridView(txtMaNhanVien.Text.Trim(), txtTenNhanVien.Text.Trim(),
                (cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai);
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            FilterGridView(txtMaNhanVien.Text.Trim(), txtTenNhanVien.Text.Trim(),
                (cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai);
        }

        private void FilterGridView(string maNv, string name, int idPhongBan)
        {
            List<ThongTinNhanVIen> empList = null;
            if (idPhongBan != 0 && String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(maNv))
            {
                empList = _fullEmpList.Where(x => x.idPhongDoiToLoai == idPhongBan).ToList()
                    .Where(x => x.MaNV.Contains(maNv)).ToList();
                ReFormatCollumnGridView(empList);
            }
            else if (idPhongBan != 0 && !String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(maNv))
            {
                empList = _fullEmpList.Where(x => x.idPhongDoiToLoai == idPhongBan).ToList()
                    .Where(x => x.MaNV.Contains(maNv)).ToList().Where(x => x.hoTen.Contains(name)).ToList();
                ReFormatCollumnGridView(empList);
            }
            else if (idPhongBan != 0 && !String.IsNullOrEmpty(name) && String.IsNullOrEmpty(maNv))
            {
                empList = _fullEmpList.Where(x => x.idPhongDoiToLoai == idPhongBan).ToList()
                    .Where(x => x.hoTen.Contains(name)).ToList();
                ReFormatCollumnGridView(empList);
            }
            else if (idPhongBan != 0 && String.IsNullOrEmpty(name) && String.IsNullOrEmpty(maNv))
            {
                empList = _fullEmpList.Where(x => x.idPhongDoiToLoai == idPhongBan).ToList();
                ReFormatCollumnGridView(empList);
            }
            else if (idPhongBan == 0 && !String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(maNv))
            {
                empList = _fullEmpList.Where(x => x.MaNV.Contains(maNv)).ToList().Where(x => x.hoTen.Contains(name)).ToList();
                ReFormatCollumnGridView(empList);
            }
            else if (idPhongBan == 0 && String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(maNv))
            {
                empList = _fullEmpList.Where(x => x.MaNV.Contains(maNv)).ToList();
                ReFormatCollumnGridView(empList);
            }
            else if (idPhongBan == 0 && !String.IsNullOrEmpty(name) && String.IsNullOrEmpty(maNv))
            {
                empList = _fullEmpList.Where(x => x.hoTen.Contains(name)).ToList();
                ReFormatCollumnGridView(empList);
            }
            else
            {
                empList = _fullEmpList;
                ReFormatCollumnGridView(empList);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                var _emp = _nhanVienServices.GetEmpById(Convert.ToInt32(dataGridDanhSachNV.CurrentRow.Cells[0].Value.ToString()));
                ThongTinCaNhan formDetails = new ThongTinCaNhan(_loaiHopDongServices, _emp);
                formDetails.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void dataGridDanhSachNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var _emp = _nhanVienServices.GetEmpById(Convert.ToInt32(dataGridDanhSachNV.CurrentRow.Cells[0].Value.ToString()));
                btnViewDetails.Enabled = true;
                btnEditDetails.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                var _emp = _nhanVienServices.GetEmpById(Convert.ToInt32(dataGridDanhSachNV.CurrentRow.Cells[0].Value.ToString()));
                ChinhSuaThongTinNhanVien editEmpInfo = new ChinhSuaThongTinNhanVien(_nhanVienServices, _phongBanServices, _thanhPhoServices,
                    _chucVuServices, _capBacServices, _bienCheServices, _trinhDoServices, _giaDinhServices, _emp);
                editEmpInfo.OnClose += new OnClosing(InitRefreshGridView);
                editEmpInfo.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Đăng Nhập Vào Chức Năng Này!", "Permission Denied!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
