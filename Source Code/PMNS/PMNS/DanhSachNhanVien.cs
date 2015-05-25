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
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        protected readonly IChucVuServices _chucVuServices;
        protected readonly ICapBacServices _capBacServices;
        protected readonly IBienCheServices _bienCheServices;
        public DanhSachNhanVien(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices,
            IThanhPhoServices thanhPhoServices, IChucVuServices chucVuServices,
            ICapBacServices capBacServices, IBienCheServices bienCheServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._thanhPhoServices = thanhPhoServices;
            this._chucVuServices = chucVuServices;
            this._capBacServices = capBacServices;
            this._bienCheServices = bienCheServices;
            InitializeComponent();
        }

        #region Init
        private void InitGridView()
        {
            dataGridDanhSachNV.DataSource = _nhanVienServices.GetAllEmployees().Select(x =>
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
        #endregion

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            InitGridView();
            InitPhongBan();
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idPhongBan = (cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai;
            if (idPhongBan != 0)
            {
                dataGridDanhSachNV.DataSource = _nhanVienServices.GetAllNhanVienByIdPhongBan(idPhongBan).Select(x =>
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
            else
            {
                InitGridView();
                dataGridDanhSachNV.Refresh();
            }
        }

        private void dataGridDanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (UserProfile.permission == 1)
            //{
            var _emp = _nhanVienServices.GetEmpById(Convert.ToInt32(dataGridDanhSachNV.CurrentRow.Cells[0].Value.ToString()));
            ChinhSuaThongTinNhanVien editEmpInfo = new ChinhSuaThongTinNhanVien(_nhanVienServices, _phongBanServices, _thanhPhoServices,
                _chucVuServices, _capBacServices, _bienCheServices, _emp);
            editEmpInfo.ShowDialog(this);
            
            //}
            //else
            //{
            //    MessageBox.Show("Bạn Không Có Quyền Đăng Nhập Vào Chức Năng Này!", "Permission Denied!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
