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

namespace PMNS
{
    public partial class QuanLyCapBac : Form
    {
        protected readonly ICapBacServices _capBacServices;
        public QuanLyCapBac(ICapBacServices capBacServices)
        {
            this._capBacServices = capBacServices;
            InitializeComponent();
        }
        static CapBac updateTemp;
        #region Init Data
        public void InitGridView()
        {
            dataGridCapBac.DataSource = _capBacServices.GetAllCapBac().ToList().OrderBy(x => x.maCapBac).Select(x =>
                new
                {
                    ID = x.idCapBac,
                    MaCapBac = x.maCapBac,
                    CapBac = x.capBac1
                }).ToList();
            dataGridCapBac.Columns[0].Visible = false;
        }
        #endregion

        #region Form's Event
        private void btnThemCapBac_Click(object sender, EventArgs e)
        {
            if (_capBacServices.FindCapBac(txtCapBac.Text.Trim(), txtMaCapBac.Text.Trim()) == null)
            {
                CapBac capBac = new CapBac
                {
                    maCapBac = txtMaCapBac.Text.Trim(),
                    capBac1 = txtCapBac.Text.Trim()
                };
                if (_capBacServices.AddCapBac(capBac))
                {
                    MessageBox.Show("Đã Thêm Cấp Bậc Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    InitGridView();
                    dataGridCapBac.Refresh();
                    txtCapBac.Clear();
                    txtMaCapBac.Clear();
                }
                else
                {
                    MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi! Thông Tin Cấp Bậc Bị Trùng, Vui Lòng Kiểm Tra Lại!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void QuanLyCapBac_Load(object sender, EventArgs e)
        {
            InitGridView();
            dataGridCapBac.CurrentCell = null;
        }
        private void dataGridCapBac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateTemp = _capBacServices.GetCapBacById(Convert.ToInt32(dataGridCapBac.CurrentRow.Cells[0].Value.ToString()));
            txtMaCapBac.Text = updateTemp.maCapBac;
            txtCapBac.Text = updateTemp.capBac1;
        }

        private void btnSuaCapBac_Click(object sender, EventArgs e)
        {
            updateTemp.capBac1 = txtCapBac.Text.Trim();
            updateTemp.maCapBac = txtMaCapBac.Text.Trim();
            if (_capBacServices.UpdateCapBac(updateTemp))
            {
                MessageBox.Show("Đã Sửa Cấp Bậc Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                InitGridView();
                dataGridCapBac.Refresh();
                txtCapBac.Clear();
                txtMaCapBac.Clear();
            }
            else
            {
                MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
