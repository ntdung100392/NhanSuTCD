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
    public partial class QuanLyChucVu : Form
    {
        protected readonly IChucVuServices _chucVuServices;
        public QuanLyChucVu(IChucVuServices chucVuServices)
        {
            this._chucVuServices = chucVuServices;
            InitializeComponent();
        }

        private ChucVu updateChucVu = new ChucVu();

        #region Form's Event
        private void dataGridChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateChucVu = _chucVuServices.GetChucVuById(Convert.ToInt32(dataGridChucVu.CurrentRow.Cells[0].Value.ToString()));
            txtMaChucVu.Text = updateChucVu.MaChucVu;
            txtChucVu.Text = updateChucVu.ChucVu1;
        }

        private void QuanLyChucVu_Load(object sender, EventArgs e)
        {
            InitGridView();
        }

        private void btnThemChucVu_Click(object sender, EventArgs e)
        {
            if (_chucVuServices.FindChucVu(txtChucVu.Text.Trim(), txtMaChucVu.Text.Trim()) == null)
            {
                ChucVu chucVu = new ChucVu
                {
                    MaChucVu = txtChucVu.Text.Trim(),
                    ChucVu1 = txtMaChucVu.Text.Trim()
                };
                if (_chucVuServices.AddChucVu(chucVu))
                {
                    MessageBox.Show("Đã Thêm Chức Vụ Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    InitGridView();
                    dataGridChucVu.Refresh();
                    txtChucVu.Clear();
                    txtMaChucVu.Clear();
                }
                else
                {
                    MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi! Thông Tin Chức Vụ Bị Trùng, Vui Lòng Kiểm Tra Lại!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaChucVu_Click(object sender, EventArgs e)
        {
            updateChucVu.ChucVu1 = txtChucVu.Text.Trim();
            updateChucVu.MaChucVu = txtMaChucVu.Text.Trim();
            if (_chucVuServices.UpdateChucVu(updateChucVu))
            {
                MessageBox.Show("Đã Sửa Chức Vụ Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                InitGridView();
                dataGridChucVu.Refresh();
                txtChucVu.Clear();
                txtMaChucVu.Clear();
                updateChucVu = null;
            }
            else
            {
                MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Init
        public void InitGridView()
        {
            dataGridChucVu.DataSource = _chucVuServices.GetAllChucVu().OrderBy(x => x.MaChucVu).ToList().Select(
                x => new 
                { 
                    ID=x.idChucVu,
                    MaChucVu=x.MaChucVu,
                    BienChe=x.ChucVu1,
                });
            dataGridChucVu.Columns[0].Visible = false;
            dataGridChucVu.CurrentCell = null;
        }
        #endregion
    }
}
