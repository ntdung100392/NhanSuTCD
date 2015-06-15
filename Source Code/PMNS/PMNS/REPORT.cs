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
using System.IO;
using OfficeOpenXml;

namespace PMNS
{
    public partial class REPORT : Form
    {

        #region Constructor Or Destructor

        protected readonly IBienCheServices _bienCheServices;
        protected readonly ICapBacServices _capBacServices;
        protected readonly IChucVuServices _chucVuServices;
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        private List<ThongTinNhanVIen> empReportList = new List<ThongTinNhanVIen>();
        public REPORT(IBienCheServices bienCheServices, ICapBacServices capBacServices, IChucVuServices chucVuServices, INhanVienServices nhanVienServices,
            IPhongBanServices phongBanServices, IThanhPhoServices thanhPhoServices)
        {
            this._bienCheServices = bienCheServices;
            this._capBacServices = capBacServices;
            this._chucVuServices = chucVuServices;
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._thanhPhoServices = thanhPhoServices;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void REPORT_Load(object sender, EventArgs e)
        {
            EventLoading();
            InitMain();
        }

        private void EventLoading()
        {
            comboGioiTinh.Enabled = false;
            comboDoTuoi.Enabled = false;
            comboBienChe.Enabled = false;
            comboPhongBan.Enabled = false;
            comboCapBac.Enabled = false;
            comboChucVu.Enabled = false;
            comboLoaiHD.Enabled = false;
            comboNoiO.Enabled = false;
            comboTrinhDo.Enabled = false;
            txtNamVaoCang.Enabled = false;
            txtTongQuanSo.ReadOnly = true;
            txtNam.ReadOnly = true;
            txtNu.ReadOnly = true;
            txtQuanSoPhongBan.ReadOnly = true;
        }

        private void cboxGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxGioiTinh.Checked == true)
            {
                comboGioiTinh.Enabled = true;
            }
            else
            {
                comboGioiTinh.Enabled = false;
            }
        }

        private void cboxDoTuoi_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxDoTuoi.Checked == true)
            {
                comboDoTuoi.Enabled = true;
            }
            else
            {
                comboDoTuoi.Enabled = false;
            }
        }

        private void cboxBienChe_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxBienChe.Checked == true)
            {
                comboBienChe.Enabled = true;
            }
            else
            {
                comboBienChe.Enabled = false;
            }
        }

        private void cboxPhongBan_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxPhongBan.Checked == true)
            {
                comboPhongBan.Enabled = true;
            }
            else
            {
                comboPhongBan.Enabled = false;
            }
        }

        private void cboxCapBac_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxCapBac.Checked == true)
            {
                comboCapBac.Enabled = true;
            }
            else
            {
                comboCapBac.Enabled = false;
            }
        }

        private void cboxChucVu_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxChucVu.Checked == true)
            {
                comboChucVu.Enabled = true;
            }
            else
            {
                comboChucVu.Enabled = false;
            }
        }

        private void cboxLoaiHD_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxLoaiHD.Checked == true)
            {
                comboLoaiHD.Enabled = true;
            }
            else
            {
                comboLoaiHD.Enabled = false;
            }
        }

        private void cboxNoiO_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxNoiO.Checked == true)
            {
                comboNoiO.Enabled = true;
            }
            else
            {
                comboNoiO.Enabled = false;
            }
        }

        private void cboxTrinhDo_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxTrinhDo.Checked == true)
            {
                comboTrinhDo.Enabled = true;
            }
            else
            {
                comboTrinhDo.Enabled = false;
            }
        }

        private void cboxNamVaoCang_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxNamVaoCang.Checked == true)
            {
                txtNamVaoCang.Enabled = true;
            }
            else
            {
                txtNamVaoCang.Enabled = false;
            }
        }

        #endregion

        #region Method Init Data

        private void InitMain()
        {
            InitNhanVien();
            InitReportNumberOfEmp();
            InitPhongBan();
            InitBienChe();
            InitChucVu();
            InitThanhPho();
            InitTreeView();
        }

        private void InitNhanVien()
        {
            ReformatDataGridView(_nhanVienServices.GetAllEmployees());
            empReportList = _nhanVienServices.GetAllEmployees();
        }

        private void InitBienChe()
        {
            comboBienChe.DataSource = _bienCheServices.GetAllBienChe();
            comboBienChe.ValueMember = "idBienChe";
            comboBienChe.DisplayMember = "bienChe1";
            comboBienChe.SelectedIndex = -1;
        }

        private void InitChucVu()
        {
            comboChucVu.DataSource = _chucVuServices.GetAllChucVu();
            comboChucVu.DisplayMember = "ChucVu1";
            comboChucVu.ValueMember = "idChucVu";
            comboChucVu.SelectedIndex = -1;
        }

        private void InitPhongBan()
        {
            comboPhongBan.DataSource = _phongBanServices.GetAllPhongBan();
            comboPhongBan.DisplayMember = "tenPhongDoiToLoai";
            comboPhongBan.ValueMember = "idPhongDoiToLoai";
            comboPhongBan.SelectedIndex = -1;

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

        private void InitThanhPho()
        {
            comboNoiO.DataSource = _thanhPhoServices.GetAllThanhPho();
            comboNoiO.DisplayMember = "tenTP";
            comboNoiO.ValueMember = "idThanhPho";
            comboNoiO.SelectedIndex = -1;
        }

        private void InitReportNumberOfEmp()
        {
            var empList = _nhanVienServices.GetAllEmployees();
            txtTongQuanSo.Text = empList.Count.ToString();
            txtNam.Text = empList.Where(x => x.gioiTinh == 1).ToList().Count.ToString();
            txtNu.Text = empList.Where(x => x.gioiTinh == 0).ToList().Count.ToString();
        }

        private void InitTreeView()
        {
            var listPhongBanCha = _phongBanServices.GetAllPhongBan().Where(x => x.idCha == 0).ToList();
            foreach (var phongBan in listPhongBanCha)
            {
                int i = 0;
                phongBanTreeView.Nodes.Add(phongBan.tenPhongDoiToLoai);
                if (phongBan.PhongDoiToLoaiTo1.ToList().Count != 0)
                {
                    phongBanTreeView.Nodes[i].Nodes.Add(AddChildNode(phongBan.PhongDoiToLoaiTo1.ToList()));
                }
                i++;
            }
        }

        #endregion

        #region Report Event

        private void comboGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBienChe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCapBac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboLoaiHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboNoiO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboTrinhDo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNamVaoCang_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtNamVaoCang.Text.Trim()))
            {

            }
            else
            {
                int year = Convert.ToInt32(txtNamVaoCang.Text.Trim());
                ReformatDataGridView(empReportList.Where(x => x.ngayVaoCang.Value.Year == year).ToList());
            }

        }

        private void btnInBieu_Click(object sender, EventArgs e)
        {

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

        private void phongBanTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

        }
        #endregion

        #region Method
        
        private TreeNode AddChildNode(List<PhongDoiToLoaiTo> child)
        {
            TreeNode node = new TreeNode();
            for (int i = 0; i < child.Count; i++)
            {
                if (child[i].PhongDoiToLoaiTo1.Count != 0)
                {
                    node.Nodes[i].Nodes.Add(AddChildNode(child[i].PhongDoiToLoaiTo1.ToList()));
                }
                else
                {
                    node.Nodes.Add(child[i].tenPhongDoiToLoai);
                }
            }
            return node;
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
            gridDanhsachNVReport.DataSource = rawList.OrderBy(x => x.hoTen).ToList().Select(x =>
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
            gridDanhsachNVReport.Columns[0].Visible = false;
            gridDanhsachNVReport.CurrentCell = null;
        }

        #endregion
    }
}
