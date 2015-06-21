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
    using PMNS.Controller;
    using PMNS.Entities.Models;
    using PMNS.Services.Abstract;
    using PMNS.Services.Models;
    using System.IO;
    using OfficeOpenXml;

    #endregion

    #region Delegate

    //public delegate void OnClosing(bool close);

    #endregion

    public partial class KiemTraHDLD : Form
    {
        #region

        private AutoCompleteStringCollection listMaNV = new AutoCompleteStringCollection();
        private AutoCompleteStringCollection listTenNV = new AutoCompleteStringCollection();
        private List<HopDongLaoDong> listHopDong = new List<HopDongLaoDong>();

        #endregion

        #region Constructor Or Destructor

        protected readonly IHopDongServices hopDongServices;
        protected readonly ILoaiHopDongServices loaiHopDongServices;
        protected readonly INhanVienServices nhanVienServices;
        public KiemTraHDLD(IHopDongServices hopDongServices, ILoaiHopDongServices loaiHopDongServices, INhanVienServices nhanVienServices)
        {
            this.hopDongServices = hopDongServices;
            this.loaiHopDongServices = loaiHopDongServices;
            this.nhanVienServices = nhanVienServices;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void KiemTraHDLD_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            InitMain();
        }

        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {
            var listHD = SearchingFilterData(this.listHopDong);
            ReformatColumnGridView(listHD);
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            var listHD = SearchingFilterData(this.listHopDong);
            ReformatColumnGridView(listHD);
        }

        private void btnInBieu_Click(object sender, EventArgs e)
        {
            try
            {
                //Convert to datatable for export to excel
                DataTable dataList = ConverterMethod.ConvertDataGridViewToDataTable(dataGridHDLD);
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (UserProfile.permission == 1)
            //{
                var hopDongDetails = hopDongServices.GetHopDongById(Convert.ToInt32(dataGridHDLD.CurrentRow.Cells[0].Value.ToString()));
                if (hopDongDetails != null)
                {
                    ChinhSuaHopDongLaoDong editContractForm = new ChinhSuaHopDongLaoDong(hopDongServices,
                        loaiHopDongServices, nhanVienServices, hopDongDetails);
                    editContractForm.OnClose += new OnClosingContractModifier(InitRefreshGridView);
                    editContractForm.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Vui Lòng Chọn Hợp Đồng Muốn Chỉnh Sửa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            //}
            //else
            //{
            //    MessageBox.Show("Bạn Không Có Quyền Đăng Nhập Vào Chức Năng Này!", "Permission Denied!",
            //        MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLoaiHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listHD = SearchingFilterData(this.listHopDong);
            ReformatColumnGridView(listHD);
        }

        private void txtNamBatDau_TextChanged(object sender, EventArgs e)
        {
            var listHD = SearchingFilterData(this.listHopDong);
            ReformatColumnGridView(listHD);
        }

        private void dataGridHDLD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
        }

        private void txtNamBatDau_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Allow numeric only
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Method Init

        private void InitMain()
        {
            InitAutoComplete("", "");
            InitLoaiHopDong();
            InitHopDong();
        }

        private void InitHopDong()
        {
            this.listHopDong = hopDongServices.GetAllHopDong();
            ReformatColumnGridView(listHopDong);
        }

        private void InitAutoComplete(string maNV, string tenNV)
        {
            listMaNV.AddRange(nhanVienServices.FindEmpByMaNV(maNV).ToArray());
            txtMaNv.AutoCompleteCustomSource = listMaNV;
            listTenNV.AddRange(nhanVienServices.FindEmpByName(tenNV).ToArray());
            txtTenNV.AutoCompleteCustomSource = listTenNV;
        }

        private void InitRefreshGridView(bool close)
        {
            InitHopDong();
            dataGridHDLD.Refresh();
            btnSua.Enabled = false;
        }

        private void InitLoaiHopDong()
        {
            LoaiHopDong firstItem = new LoaiHopDong { idLoaiHopDong = 0, idCha = 0, loaiHopDong1 = "Tất Cả", HopDongLaoDongs = null };
            var listLoaiHopDong = new List<LoaiHopDong>();
            listLoaiHopDong.Add(firstItem);
            listLoaiHopDong.AddRange(loaiHopDongServices.GettAllLoaiHopDong().ToList());
            if (listLoaiHopDong.Count != 0)
            {
                foreach (var loaiHd in loaiHopDongServices.GettAllLoaiHopDong())
                {
                    if (loaiHd.idCha != 0 && loaiHd.idLoaiHopDong != 0)
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

        private List<HopDongLaoDong> SearchingFilterData(List<HopDongLaoDong> dataList)
        {
            if (dataList.Count != 0)
            {
                if (!String.IsNullOrEmpty(txtNamBatDau.Text.Trim()))
                    dataList = dataList.Where(hd => hd.ngayBatDau.Year == Convert.ToInt32(txtNamBatDau.Text.Trim())).ToList();
                if (!String.IsNullOrEmpty(txtMaNv.Text.Trim()))
                    dataList = dataList.Where(hd => hd.ThongTinNhanVIen.MaNV.Equals(txtMaNv.Text.Trim())).ToList();
                if (!String.IsNullOrEmpty(txtTenNV.Text.Trim()))
                    dataList = dataList.Where(hd => hd.ThongTinNhanVIen.hoTen.Equals(txtTenNV.Text.Trim())).ToList();
                if ((cbLoaiHopDong.SelectedItem as LoaiHopDong).idLoaiHopDong != 0)
                    dataList = dataList.Where(hd => hd.idLoaiHopDong == Convert.ToInt32((cbLoaiHopDong.SelectedItem as LoaiHopDong)
                        .idLoaiHopDong)).ToList();
            }
            return dataList;
        }

        private void ReformatColumnGridView(List<HopDongLaoDong> listData)
        {
            dataGridHDLD.DataSource = listData.Select(x =>
                new
                {
                    STT = x.idHopDongLaoDong,
                    MaNhanVien = x.ThongTinNhanVIen.MaNV,
                    TenNhanVien = x.ThongTinNhanVIen.hoTen,
                    ChucDanh = x.chucDanh,
                    ThoiHan = x.LoaiHopDong.loaiHopDong1,
                    SoHopDong = x.soHopDong_TTHDLD,
                    NgayBatDau = x.ngayBatDau.ToString("dd/MM/yyyy"),
                    NgayKetThuc = x.ngayKetThuc.ToString("dd/MM/yyyy"),
                    NguoiBaoLanh = x.nguoiBaoLanh_TTHDLD,
                    GhiChu = x.ghiChu
                }).ToList();
            dataGridHDLD.Columns[0].Visible = false;
            dataGridHDLD.CurrentCell = null;
        }

        #endregion
    }
}