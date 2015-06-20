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

    public partial class KiemTraHDLD : Form
    {

        #region Constructor Or Destructor

        public KiemTraHDLD()
        {
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void KiemTraHDLD_Load(object sender, EventArgs e)
        {

        }

        private void txtMaNv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {

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

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbLoaiHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxNamBatDau_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbKhongThoiHan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbCoThoiHan_CheckedChanged(object sender, EventArgs e)
        {

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

        #endregion
    }
}