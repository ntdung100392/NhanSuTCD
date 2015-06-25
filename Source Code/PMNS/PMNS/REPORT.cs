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
    using PMNS.Controller;
    using PMNS.Services.Models;
    using PMNS.Model;
    using System.IO;
    using OfficeOpenXml;

    #endregion

    public partial class REPORT : Form
    {

        #region Properties

        private List<ThongTinNhanVIen> _empReportList = new List<ThongTinNhanVIen>();

        #endregion

        #region Constructor Or Destructor

        protected readonly IBienCheServices _bienCheServices;
        protected readonly ICapBacServices _capBacServices;
        protected readonly IChucVuServices _chucVuServices;
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        protected readonly ILoaiHopDongServices _loaiHopDongServices;
        public REPORT(IBienCheServices bienCheServices, ICapBacServices capBacServices, IChucVuServices chucVuServices, INhanVienServices nhanVienServices,
            IPhongBanServices phongBanServices, IThanhPhoServices thanhPhoServices, ILoaiHopDongServices loaiHopDongServices)
        {
            this._bienCheServices = bienCheServices;
            this._capBacServices = capBacServices;
            this._chucVuServices = chucVuServices;
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._thanhPhoServices = thanhPhoServices;
            this._loaiHopDongServices = loaiHopDongServices;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void REPORT_Load(object sender, EventArgs e)
        {
            InitMain();
            EventLoading();
        }

        private void EventLoading()
        {
            txtTongQuanSo.ReadOnly = true;
            txtNam.ReadOnly = true;
            txtNu.ReadOnly = true;
            txtQuanSoPhongBan.ReadOnly = true;
        }

        #endregion

        #region Method Init Data

        private void InitMain()
        {
            InitGioiTinh();
            InitDoTuoiLon();
            InitDoTuoiNho();
            InitBienChe();
            InitPhongBan();
            InitTongKetPhongBan();
            InitCapBac();
            InitChucVu();
            InitLoaiHopDong();
            InitThanhPho();
            InitNhanVien();
            InitReportNumberOfEmp();
        }

        private void InitNhanVien()
        {
            ReformatDataGridView(_nhanVienServices.GetAllEmployees());
            _empReportList = _nhanVienServices.GetAllEmployees();
        }

        private void InitBienChe()
        {
            BienChe firstItem = new BienChe { idBienChe = 0, maBienChe = "All", bienChe1 = "Tất Cả", ThongTinNhanVIens = null };
            List<BienChe> listBienChe = new List<BienChe>();
            listBienChe.Add(firstItem);
            listBienChe.AddRange(_bienCheServices.GetAllBienChe());
            comboBienChe.DataSource = listBienChe;
            comboBienChe.ValueMember = "idBienChe";
            comboBienChe.DisplayMember = "bienChe1";
        }

        private void InitChucVu()
        {
            ChucVu firstItem = new ChucVu { idChucVu = 0, MaChucVu = "All", ChucVu1 = "Tất Cả", ThongTinNhanVIens = null };
            List<ChucVu> listChucVu = new List<ChucVu>();
            listChucVu.Add(firstItem);
            listChucVu.AddRange(_chucVuServices.GetAllChucVu());
            comboChucVu.DataSource = listChucVu;
            comboChucVu.DisplayMember = "ChucVu1";
            comboChucVu.ValueMember = "idChucVu";
        }

        private void InitCapBac()
        {
            CapBac firstItem = new CapBac { idCapBac = 0, maCapBac = "All", capBac1 = "Tất Cả", ThongTinNhanVIens = null };
            List<CapBac> listCapBac = new List<CapBac>();
            listCapBac.Add(firstItem);
            listCapBac.AddRange(_capBacServices.GetAllCapBac());
            comboCapBac.DataSource = listCapBac;
            comboCapBac.DisplayMember = "capBac1";
            comboCapBac.ValueMember = "idCapBac";
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
            comboTongKetPhongBan.DataSource = listPhongBan;
            comboTongKetPhongBan.DisplayMember = "tenPhongDoiToLoai";
            comboTongKetPhongBan.ValueMember = "idPhongDoiToLoai";
        }

        private void InitLoaiHopDong()
        {
            LoaiHopDong firstItem = new LoaiHopDong { idLoaiHopDong = 0, idCha = 0, loaiHopDong1 = "Tất Cả", HopDongLaoDongs = null };
            var listLoaiHopDong = _loaiHopDongServices.GettAllLoaiHopDong();
            if (listLoaiHopDong.Count != 0)
            {
                foreach (var loaiHd in _loaiHopDongServices.GettAllLoaiHopDong())
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
            listLoaiHopDong.Add(firstItem);
            comboLoaiHD.DataSource = listLoaiHopDong.OrderBy(hd => hd.idLoaiHopDong).ToList();
            comboLoaiHD.DisplayMember = "loaiHopDong1";
            comboLoaiHD.ValueMember = "idLoaiHopDong";
        }

        private void InitGioiTinh()
        {
            List<ComboBoxItem> listGioiTinh = new List<ComboBoxItem>();
            listGioiTinh.Add(new ComboBoxItem { Text = "Tất Cả", Value = 2 });
            listGioiTinh.Add(new ComboBoxItem { Text = "Nam", Value = 0 });
            listGioiTinh.Add(new ComboBoxItem { Text = "Nữ", Value = 1 });
            comboGioiTinh.DataSource = listGioiTinh;
            comboGioiTinh.DisplayMember = "Text";
            comboGioiTinh.ValueMember = "Value";
        }

        private void InitTongKetPhongBan()
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
            comboPhongBan.DataSource = listPhongBan;
            comboPhongBan.DisplayMember = "tenPhongDoiToLoai";
            comboPhongBan.ValueMember = "idPhongDoiToLoai";
        }

        private void InitThanhPho()
        {
            ThanhPho firstItem = new ThanhPho { idThanhPho = 0, maTP = "All", tenTP = "Tất Cả", ThongTinNhanVIens = null };
            List<ThanhPho> listThanhPho = new List<ThanhPho>();
            listThanhPho.Add(firstItem);
            listThanhPho.AddRange(_thanhPhoServices.GetAllThanhPho());
            comboNoiO.DataSource = listThanhPho;
            comboNoiO.DisplayMember = "tenTP";
            comboNoiO.ValueMember = "idThanhPho";
        }

        private void InitReportNumberOfEmp()
        {
            var empList = _nhanVienServices.GetAllEmployees();
            txtTongQuanSo.Text = empList.Count.ToString();
            txtNam.Text = empList.Where(x => x.gioiTinh == 0).ToList().Count.ToString();
            txtNu.Text = empList.Where(x => x.gioiTinh == 1).ToList().Count.ToString();
        }

        private void InitDoTuoiNho()
        {
            List<ComboBoxItem> listItem = new List<ComboBoxItem>();
            ComboBoxItem firstItem = new ComboBoxItem { Text = "Tất Cả", Value = 0 };
            listItem.Add(firstItem);
            for (int i = 18; i <= 65; i++)
            {
                ComboBoxItem item = new ComboBoxItem { Text = i.ToString(), Value = i };
                listItem.Add(item);
            }
            comboDoTuoiNho.DataSource = listItem;
            comboDoTuoiNho.DisplayMember = "Text";
            comboDoTuoiNho.ValueMember = "Value";
        }

        private void InitDoTuoiLon()
        {
            List<ComboBoxItem> listItem = new List<ComboBoxItem>();
            ComboBoxItem firstItem = new ComboBoxItem { Text = "Tất Cả", Value = 0 };
            listItem.Add(firstItem);
            for (int i = 19; i <= 65; i++)
            {
                ComboBoxItem item = new ComboBoxItem { Text = i.ToString(), Value = i };
                listItem.Add(item);
            }
            comboDoTuoiLon.DataSource = listItem;
            comboDoTuoiLon.DisplayMember = "Text";
            comboDoTuoiLon.ValueMember = "Value";
        }

        #endregion

        #region Report Event

        private void comboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterList = SearchingFilterData(_empReportList);
            ReformatDataGridView(filterList);
        }

        private void comboBienChe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterList = SearchingFilterData(_empReportList);
            ReformatDataGridView(filterList);
        }

        private void comboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterList = SearchingFilterData(_empReportList);
            ReformatDataGridView(filterList);
        }

        private void comboCapBac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterList = SearchingFilterData(_empReportList);
            ReformatDataGridView(filterList);
        }

        private void comboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterList = SearchingFilterData(_empReportList);
            ReformatDataGridView(filterList);
        }

        private void comboLoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterList = SearchingFilterData(_empReportList);
            ReformatDataGridView(filterList);
        }

        private void comboNoiO_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterList = SearchingFilterData(_empReportList);
            ReformatDataGridView(filterList);
        }

        private void comboTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var filterList = SearchingFilterData(_empReportList);
            ReformatDataGridView(filterList);
        }

        private void txtNamVaoCang_TextChanged(object sender, EventArgs e)
        {
            var filterList = SearchingFilterData(_empReportList);
            ReformatDataGridView(filterList);
        }

        private void txtTenNhanVien_TextChanged(object sender, EventArgs e)
        {
            var filterList = SearchingFilterData(_empReportList);
            ReformatDataGridView(filterList);
        }

        private void comboDoTuoiNho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboDoTuoiNho.Text) && !String.IsNullOrEmpty(comboDoTuoiLon.Text))
            {
                if (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) > Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value))
                {
                    if (Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value) == 65 && Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) == 65)
                    {
                        comboDoTuoiNho.Text = (65 - 1).ToString();

                    }
                    else if (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) == 65 && 
                        Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) > Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value))
                    {
                        comboDoTuoiLon.Text = (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value)).ToString();
                    }
                    else if (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) != 0 && 
                        Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value) != 0 && 
                        Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) > Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value))
                    {
                        comboDoTuoiNho.Text = (Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value) - 1).ToString();
                    }
                    else
                    {
                        comboDoTuoiLon.Text = (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) + 1).ToString();
                    }
                }
                var filterList = SearchingFilterData(_empReportList);
                ReformatDataGridView(filterList);
            }
        }

        private void comboDoTuoiLon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(comboDoTuoiNho.Text) && !String.IsNullOrEmpty(comboDoTuoiLon.Text))
            {
                if (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) > Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value))
                {
                    if (Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value) == 65 && Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) == 65)
                    {
                        comboDoTuoiNho.Text = (65 - 1).ToString();

                    }
                    else if (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) == 65 && 
                        Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) > Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value))
                    {
                        comboDoTuoiLon.Text = (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value)).ToString();
                    }
                    else if (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) != 0 &&
                        Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value) != 0 &&
                        Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) > Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value))
                    {
                        comboDoTuoiNho.Text = (Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value) - 1).ToString();
                    }
                    else
                    {
                        comboDoTuoiLon.Text = (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) + 1).ToString();
                    }
                }
                var filterList = SearchingFilterData(_empReportList);
                ReformatDataGridView(filterList);
            }
        }

        private void btnInBieu_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert to datatable for export to excel
                DataTable dataList = ConverterMethod.ConvertDataGridViewToDataTable(datagridReport);
                if (dataList.Rows.Count != 0)
                {
                    ExportToExcel(dataList);
                }
                else
                {
                    MessageBox.Show("Không Có Thông Tin Để Trích Xuất", "Thông Báo!", MessageBoxButtons.OK);
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
                    MessageBox.Show("Trích Xuất Excel Không Thành Công!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboTongKetPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((comboTongKetPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai == 0)
            {
                txtQuanSoPhongBan.Text = _nhanVienServices.GetAllEmployees().Count.ToString();
            }
            else
            {
                txtQuanSoPhongBan.Text = _nhanVienServices.GetAllNhanVienByIdPhongBan(
                    (comboTongKetPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai).Count.ToString();
            }
        }

        private void txtNamVaoCang_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow numeric only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            comboGioiTinh.SelectedIndex = 0;
            comboDoTuoiNho.SelectedIndex = 0;
            comboBienChe.SelectedIndex = 0;
            comboPhongBan.SelectedIndex = 0;
            comboCapBac.SelectedIndex = 0;
            comboChucVu.SelectedIndex = 0;
            comboLoaiHD.SelectedIndex = 0;
            comboNoiO.SelectedIndex = 0;
            //comboTrinhDo.SelectedIndex = 0;
            txtNamVaoCang.Text = "";
            txtTenNhanVien.Text = "";
        }

        #endregion

        #region Method

        private List<ThongTinNhanVIen> SearchingFilterData(List<ThongTinNhanVIen> empList)
        {
            if (empList.Count != 0)
            {
                //Filter by name
                if (!String.IsNullOrEmpty(txtTenNhanVien.Text.Trim()))
                    empList = empList.Where(e => e.hoTen.Contains(txtTenNhanVien.Text.Trim())).ToList();
                //Filter by sex
                if (Convert.ToInt32((comboGioiTinh.SelectedItem as ComboBoxItem).Value) != 2)
                    empList = empList.Where(e => e.gioiTinh == Convert.ToInt32((comboGioiTinh.SelectedItem as ComboBoxItem).Value)).ToList();
                //Filter by age
                if (Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem).Value) != 0)
                    empList = empList.Where(e => e.namSinh.Year <= (DateTime.Now.Year - Convert.ToInt32((comboDoTuoiNho.SelectedItem as ComboBoxItem)
                        .Value))).ToList();
                if (Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem).Value) != 0)
                    empList = empList.Where(e => e.namSinh.Year >= (DateTime.Now.Year - Convert.ToInt32((comboDoTuoiLon.SelectedItem as ComboBoxItem)
                        .Value))).ToList();
                //Filter by BienChe
                if (Convert.ToInt32((comboBienChe.SelectedItem as BienChe).idBienChe) != 0)
                    empList = empList.Where(e => e.idBienChe == Convert.ToInt32((comboBienChe.SelectedItem as BienChe).idBienChe)).ToList();
                //Filter by PhongBan
                if (Convert.ToInt32((comboPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai) != 0)
                    empList = empList.Where(e => e.idPhongDoiToLoai == Convert.ToInt32((comboPhongBan.SelectedItem as PhongDoiToLoaiTo)
                        .idPhongDoiToLoai)).ToList();
                //Filter by CapBac
                if (Convert.ToInt32((comboCapBac.SelectedItem as CapBac).idCapBac) != 0)
                    empList = empList.Where(e => e.idCapBac == Convert.ToInt32((comboCapBac.SelectedItem as CapBac).idCapBac)).ToList();
                //Filter by ChucVu
                if (Convert.ToInt32((comboChucVu.SelectedItem as ChucVu).idChucVu) != 0)
                    empList = empList.Where(e => e.idChucVu == Convert.ToInt32((comboChucVu.SelectedItem as ChucVu).idChucVu)).ToList();
                //Filter by LoaiHopDong
                if (Convert.ToInt32((comboLoaiHD.SelectedItem as LoaiHopDong).idLoaiHopDong) != 0)
                    empList = empList.Where(e => e.HopDongLaoDongs.OrderByDescending(hd => hd.ngayBatDau).FirstOrDefault()
                        .idLoaiHopDong == Convert.ToInt32((comboLoaiHD.SelectedItem as LoaiHopDong).idLoaiHopDong)).ToList();
                //Filter by Living Place
                if (Convert.ToInt32((comboNoiO.SelectedItem as ThanhPho).idThanhPho) != 0)
                    empList = empList.Where(e => e.idTP == Convert.ToInt32((comboNoiO.SelectedItem as ThanhPho).idThanhPho)).ToList();
                //Filter by NamVaoCang
                if (!String.IsNullOrEmpty(txtNamVaoCang.Text.Trim()))
                    empList = empList.Where(e => e.ngayVaoCang.Value.Year == Convert.ToInt32(txtNamVaoCang.Text.Trim())).ToList();
            }
            return empList;
        }

        private void ExportToExcel(DataTable dataList)
        {
            var dia = new System.Windows.Forms.SaveFileDialog();
            dia.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dia.Filter = "Excel Worksheets (*.xlsx)|*.xlsx|xls file (*.xls)|*.xls|All files (*.*)|*.*";
            if (dia.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                var excel = new ExcelPackage();
                var ws = excel.Workbook.Worksheets.Add("worksheet-name");
                // you can also use LoadFromCollection with an `IEnumerable<SomeType>`
                ws.Cells["A1"].LoadFromDataTable(dataList, true, OfficeOpenXml.Table.TableStyles.Light1);
                ws.Cells[ws.Dimension.Address.ToString()].AutoFitColumns();

                using (var file = File.Create(dia.FileName))
                {
                    excel.SaveAs(file);
                    MessageBox.Show("Trích Xuất Excel Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                }
            }
        }

        private void ReformatDataGridView(List<ThongTinNhanVIen> rawList)
        {
            datagridReport.DataSource = rawList.OrderBy(x => x.MaNV).ToList().Select(x =>
                new
                {
                    MaNV = x.MaNV,
                    HoTen = x.hoTen,
                    NamSinh = x.namSinh.ToString("dd/MM/yyyy"),
                    SoDienThoai = x.soDienThoaiDiDong,
                    TinhTrangHonNhan = x.tinhTrangHonNhan,
                    CongViecDangLam = x.CongViecDangLam,
                    NoiCongTac = x.noiCongTac,
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
            datagridReport.Columns[0].Visible = false;
            datagridReport.CurrentCell = null;
        }

        #endregion
    }
}
