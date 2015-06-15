using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace PMNS.Controller
{
    public class ConverterMethod
    {
        public static DataTable ConvertDataGridViewToDataTable(DataGridView dataGrid, int minRow = 0)
        {
            DataTable dt = new DataTable();

            // Header columns
            foreach (DataGridViewColumn column in dataGrid.Columns)
            {
                DataColumn dc = new DataColumn(column.Name.ToString());
                dt.Columns.Add(dc);
            }

            // Data cells
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                DataGridViewRow row = dataGrid.Rows[i];
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dataGrid.Columns.Count; j++)
                {
                    dr[j] = (row.Cells[j].Value == null) ? "" : row.Cells[j].Value.ToString();
                }
                dt.Rows.Add(dr);
            }

            // Related to the bug arround min size when using ExcelLibrary for export
            for (int i = dataGrid.Rows.Count; i < minRow; i++)
            {
                DataRow dr = dt.NewRow();
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    dr[j] = "  ";
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
    }
}
