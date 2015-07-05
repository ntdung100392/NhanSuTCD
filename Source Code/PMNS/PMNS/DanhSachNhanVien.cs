namespace PMNS
{
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

    public partial class DanhSachNhanVien : Form
    {
        #region Properties

        private List<ThongTinNhanVIen> fullEmpList = new List<ThongTinNhanVIen>();

        #endregion

        #region Constructor Or Destructor

        protected readonly IHopDongServices hopDongServices;
        protected readonly INhanVienServices nhanVienServices;
        protected readonly IPhongBanServices phongBanServices;
        protected readonly IThanhPhoServices thanhPhoServices;
        protected readonly IChucVuServices chucVuServices;
        protected readonly ICapBacServices capBacServices;
        protected readonly IBienCheServices bienCheServices;
        protected readonly ILoaiHopDongServices loaiHopDongServices;
        protected readonly IThongTinTrinhDoServices thongTinTrinhDoServices;
        protected readonly IThongTinGiaDinhServices giaDinhServices;
        protected readonly ITrinhDoServices trinhDoServices;

        public DanhSachNhanVien(IHopDongServices hopDongServices, INhanVienServices nhanVienServices, IPhongBanServices phongBanServices,
            IThanhPhoServices thanhPhoServices, IChucVuServices chucVuServices,
            ICapBacServices capBacServices, IBienCheServices bienCheServices, ILoaiHopDongServices loaiHopDongServices,
            IThongTinTrinhDoServices thongTinTrinhDoServices, IThongTinGiaDinhServices giaDinhServices, ITrinhDoServices trinhDoServices)
        {
            this.hopDongServices = hopDongServices;
            this.nhanVienServices = nhanVienServices;
            this.phongBanServices = phongBanServices;
            this.thanhPhoServices = thanhPhoServices;
            this.chucVuServices = chucVuServices;
            this.capBacServices = capBacServices;
            this.bienCheServices = bienCheServices;
            this.loaiHopDongServices = loaiHopDongServices;
            this.thongTinTrinhDoServices = thongTinTrinhDoServices;
            this.giaDinhServices = giaDinhServices;
            this.trinhDoServices = trinhDoServices;
            InitializeComponent();
        }

        #endregion

        #region Event Method

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            cbPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            btnEditDetails.Enabled = false;
            btnViewDetails.Enabled = false;
            InitGridView();
            InitPhongBan();
        }

        private void cbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterList = FilterGridView(fullEmpList);
            ReFormatCollumnGridView(filterList);
        }

        private void dataGridDanhSachNV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UserProfile.permission == 1)
            {
                var emp = nhanVienServices.GetEmpById(Convert.ToInt32(dataGridDanhSachNV.CurrentRow.Cells[0].Value.ToString()));
                ChinhSuaThongTinNhanVien editEmpInfo = new ChinhSuaThongTinNhanVien(hopDongServices, loaiHopDongServices,
                    nhanVienServices, phongBanServices, thanhPhoServices, chucVuServices, capBacServices, bienCheServices,
                    thongTinTrinhDoServices, trinhDoServices, giaDinhServices, emp);
                editEmpInfo.OnClose += new OnClosingEmpModifier(InitRefreshGridView);
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
            var filterList = FilterGridView(fullEmpList);
            ReFormatCollumnGridView(filterList);
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            var filterList = FilterGridView(fullEmpList);
            ReFormatCollumnGridView(filterList);
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            try
            {
                var emp = nhanVienServices.GetEmpById(Convert.ToInt32(dataGridDanhSachNV.CurrentRow.Cells[0].Value.ToString()));
                ThongTinCaNhan formDetails = new ThongTinCaNhan(loaiHopDongServices, emp);
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
                var emp = nhanVienServices.GetEmpById(Convert.ToInt32(dataGridDanhSachNV.CurrentRow.Cells[0].Value.ToString()));
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
                var emp = nhanVienServices.GetEmpById(Convert.ToInt32(dataGridDanhSachNV.CurrentRow.Cells[0].Value.ToString()));
                ChinhSuaThongTinNhanVien editEmpInfo = new ChinhSuaThongTinNhanVien(hopDongServices, loaiHopDongServices,
                    nhanVienServices, phongBanServices, thanhPhoServices, chucVuServices, capBacServices, bienCheServices,
                    thongTinTrinhDoServices, trinhDoServices, giaDinhServices, emp);
                editEmpInfo.OnClose += new OnClosingEmpModifier(InitRefreshGridView);
                editEmpInfo.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Đăng Nhập Vào Chức Năng Này!", "Permission Denied!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Method Init

        private void InitGridView()
        {
            fullEmpList = nhanVienServices.GetAllEmployees();
            ReFormatCollumnGridView(fullEmpList);
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
            listPhongBan.AddRange(phongBanServices.GetAllPhongBan());
            cbPhongBan.DataSource = listPhongBan;
            cbPhongBan.DisplayMember = "tenPhongDoiToLoai";
            cbPhongBan.ValueMember = "idPhongDoiToLoai";
        }

        #endregion

        #region Method

        private List<int> MethodForEach(List<PhongDoiToLoaiTo> listData)
        {
            List<int> listPhongBan = new List<int>();
            foreach (var data in listData)
            {
                if (data.PhongDoiToLoaiTo1.Count != 0)
                {
                    listPhongBan.AddRange(MethodForEach(data.PhongDoiToLoaiTo1.ToList()));
                }
                else
                {
                    listPhongBan.Add(data.idPhongDoiToLoai);
                }
            }
            return listPhongBan;
        }


        private List<ThongTinNhanVIen> FilterGridView(List<ThongTinNhanVIen> empList)
        {
            if (empList.Count != 0)
            {
                if (!String.IsNullOrEmpty(txtMaNhanVien.Text.Trim()))
                    empList = empList.Where(emp => emp.MaNV.Contains(txtMaNhanVien.Text.Trim())).ToList();
                if (!String.IsNullOrEmpty(txtTenNhanVien.Text.Trim()))
                    empList = empList.Where(emp => emp.hoTen.Contains(txtTenNhanVien.Text.Trim())).ToList();
                //Filter by PhongBan
                if (Convert.ToInt32((cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai) != 0)
                {
                    var list = new List<int>();
                    if ((cbPhongBan.SelectedItem as PhongDoiToLoaiTo).PhongDoiToLoaiTo1.Count != 0)
                    {
                        var tempList = new List<ThongTinNhanVIen>();
                        list.Add((cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai);
                        list.AddRange(MethodForEach((cbPhongBan.SelectedItem as PhongDoiToLoaiTo).PhongDoiToLoaiTo1.ToList()));
                        foreach (var id in list)
                        {
                            tempList.AddRange(nhanVienServices.GetAllNhanVienByIdPhongBan(id));
                        }
                        empList = empList.Intersect(tempList).ToList();
                    }
                    else
                    {
                        empList = empList.Where(e => e.idPhongDoiToLoai == (cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai).ToList();
                    }
                }
            }
            return empList;
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
    }    
}
