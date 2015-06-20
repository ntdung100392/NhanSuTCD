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
    using PMNS.Services.Abstract;
    using PMNS.Entities.Models;
    using PMNS.Model;
    using PMNS.Services.Models;
    using PMNS.Controller;
    using System.IO;
    using OfficeOpenXml;

    #endregion

    public partial class DanhSachThongTin : Form
    {

        #region Constructor Or Destructor

        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThongTinServices _thongTinServices;
        private List<TD_DD_BN_TV> _listThongTin = new List<TD_DD_BN_TV>();
        protected readonly string _loaiThongTin;
        public DanhSachThongTin(INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IThongTinServices thongTinServices,
            string loaiThongTin)
        {
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._thongTinServices = thongTinServices;
            this._loaiThongTin = loaiThongTin;
            InitializeComponent();
        }

        #endregion

        #region Event Method

        private void DanhSachThongTin_Load(object sender, EventArgs e)
        {
            EventLoading();            
            InitMain();
        }

        private void EventLoading()
        {
            txtLenh.Text = _loaiThongTin;
            txtLenh.ReadOnly = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            var listData = SearchingFilterData(_listThongTin);
            ReformatDataGridView(listData);
        }

        private List<TD_DD_BN_TV> SearchingFilterData(List<TD_DD_BN_TV> filterList)
        {
            //Input list of data
            if (filterList.Count != 0)
            {
                //Filter with year
                if (Convert.ToInt32(comboNam.SelectedValue) != 0)
                    filterList = filterList.Where(x => x.namThucHien.Year == Convert.ToInt32(comboNam.SelectedValue)).ToList();
                //Filter with name
                if (!String.IsNullOrEmpty(txtTenNV.Text.Trim()))
                    filterList = filterList.Where(x => x.ThongTinNhanVIen.hoTen.Contains(txtTenNV.Text.Trim())).ToList();
                //Filter with PhongBan
                if ((comboBoxPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai != 0)
                    filterList = filterList.Where(x => x.ThongTinNhanVIen.idPhongDoiToLoai ==
                        (comboBoxPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai).ToList();
                //Filter with Months
                if (Convert.ToInt32(comboThang.SelectedValue) != 0)
                    filterList = filterList.Where(x => x.namThucHien.Month == Convert.ToInt32(comboThang.SelectedValue)).ToList();
                //Filter with Quater
                if (Convert.ToInt32(comboQuy.SelectedValue) != 4)
                    filterList = filterList.Where(x => x.namThucHien.Month >= (1 + 3 * Convert.ToInt32(comboQuy.SelectedValue))
                        && x.namThucHien.Month <= (3 + 3 * Convert.ToInt32(comboQuy.SelectedValue))).ToList();
            }
            return filterList;
        }

        private void comboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listData = SearchingFilterData(_listThongTin);
            ReformatDataGridView(listData);
        }

        private void comboBoxPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listData = SearchingFilterData(_listThongTin);
            ReformatDataGridView(listData);
        }

        private void comboQuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listData = SearchingFilterData(_listThongTin);
            ReformatDataGridView(listData);
        }

        private void comboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listData = SearchingFilterData(_listThongTin);
            ReformatDataGridView(listData);
        }

        private void btnInBieu_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert to datatable for export to excel
                DataTable dataList = ConverterMethod.ConvertDataGridViewToDataTable(dataGridThongTin);
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

        #endregion

        #region Init Method

        private void InitMain()
        {
            InitPhongBan();
            InitThang();
            InitQuy();
            InitNam();
            InitGridView();
        }

        private void InitGridView()
        {
            _listThongTin = _thongTinServices.GetAllThongTin().Where(x => x.noiDung.Equals(_loaiThongTin)).ToList();
            ReformatDataGridView(_listThongTin);
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
            comboBoxPhongBan.DataSource = listPhongBan;
            comboBoxPhongBan.DisplayMember = "tenPhongDoiToLoai";
            comboBoxPhongBan.ValueMember = "idPhongDoiToLoai";
        }

        private void InitNam()
        {
            List<ComboBoxItem> item = new List<ComboBoxItem>();
            ComboBoxItem init = new ComboBoxItem
            {
                Text = "Tất Cả",
                Value = 0
            };
            item.Add(init);
            for (int i = DateTime.Today.Year; i >= (DateTime.Today.Year - 20); i--)
            {
                ComboBoxItem year = new ComboBoxItem
                {
                    Text = i.ToString(),
                    Value = i
                };
                item.Add(year);
            }
            comboNam.DataSource = item;
            comboNam.DisplayMember = "Text";
            comboNam.ValueMember = "Value";
        }

        private void InitQuy()
        {
            List<ComboBoxItem> item = new List<ComboBoxItem> 
            {
                new ComboBoxItem { Text = "Tất Cả", Value = 4 },
                new ComboBoxItem { Text = "Quý 1", Value = 0 },
                new ComboBoxItem { Text = "Quý 2", Value = 1 },
                new ComboBoxItem { Text = "Quý 3", Value = 2 },
                new ComboBoxItem { Text = "Quý 4", Value = 3 }
            };
            comboQuy.DataSource = item;
            comboQuy.DisplayMember = "Text";
            comboQuy.ValueMember = "Value";
        }

        private void InitThang()
        {
            List<ComboBoxItem> item = new List<ComboBoxItem> 
            {
                new ComboBoxItem { Text = "Tất Cả", Value = 0 },
                new ComboBoxItem { Text = "Tháng 1", Value = 1 },
                new ComboBoxItem { Text = "Tháng 2", Value = 2 },
                new ComboBoxItem { Text = "Tháng 3", Value = 3 },
                new ComboBoxItem { Text = "Tháng 4", Value = 4 },
                new ComboBoxItem { Text = "Tháng 5", Value = 5 },
                new ComboBoxItem { Text = "Tháng 6", Value = 6 },
                new ComboBoxItem { Text = "Tháng 7", Value = 7 },
                new ComboBoxItem { Text = "Tháng 8", Value = 8 },
                new ComboBoxItem { Text = "Tháng 9", Value = 9 },
                new ComboBoxItem { Text = "Tháng 10", Value = 10 },
                new ComboBoxItem { Text = "Tháng 11", Value = 11 },
                new ComboBoxItem { Text = "Tháng 12", Value = 12 },
            };
            comboThang.DataSource = item;
            comboThang.DisplayMember = "Text";
            comboThang.ValueMember = "Value";
        }

        #endregion

        #region Method

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

        private void ReformatDataGridView(List<TD_DD_BN_TV> listData)
        {
            dataGridThongTin.DataSource = listData
                .Select(x => new
                {
                    id = x.idTDDDBNTV,
                    MaNhanVien = x.ThongTinNhanVIen.MaNV,
                    TenNhanVien = x.ThongTinNhanVIen.hoTen,
                    PhongBan = x.ThongTinNhanVIen.PhongDoiToLoaiTo.tenPhongDoiToLoai,
                    NguoiKyQuyetDinh = x.hoTenDD,
                    NamThucHien = x.namThucHien.Year,
                    NgayKy = (Convert.ToDateTime(x.ngayKyQD)).ToString("dd/MM/yyyy"),
                    NgayHieuLuc = (Convert.ToDateTime(x.ngayHieuLuc)).ToString("dd/MM/yyyy"),
                    SoQuyetDinh = x.soQuyetDinh,
                    ViTriCu = x.viTriCu,
                    ViTriMoi = x.viTriMoi
                }).ToList();
            dataGridThongTin.Columns[0].Visible = false;
            dataGridThongTin.CurrentCell = null;
        }

        #endregion
    }
}
