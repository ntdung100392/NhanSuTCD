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

namespace PMNS
{
    public partial class QuanLyBienChe : Form
    {
        protected readonly IBienCheServices _bienCheServices;
        public QuanLyBienChe(IBienCheServices bienCheServices)
        {
            this._bienCheServices = bienCheServices;
            InitializeComponent();
        }

        private BienChe updateBienChe = new BienChe();

        #region Form's Event
        private void QuanLyBienChe_Load(object sender, EventArgs e)
        {
            InitGridView();
        }

        private void btnThemBienChe_Click(object sender, EventArgs e)
        {
            if (_bienCheServices.FindBienChe(txtBienChe.Text.Trim(), txtMaBienChe.Text.Trim()) == null)
            {
                BienChe bienChe = new BienChe
                {
                    maBienChe = txtBienChe.Text.Trim(),
                    bienChe1 = txtMaBienChe.Text.Trim()
                };
                if (_bienCheServices.AddBienChe(bienChe))
                {
                    MessageBox.Show("Đã Thêm Biên Chế Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    InitGridView();
                    dataGridBienChe.Refresh();
                    txtBienChe.Clear();
                    txtMaBienChe.Clear();
                }
                else
                {
                    MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lỗi! Thông Tin Biên Chế Bị Trùng, Vui Lòng Kiểm Tra Lại!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaBienChe_Click(object sender, EventArgs e)
        {
            updateBienChe.bienChe1 = txtBienChe.Text.Trim();
            updateBienChe.maBienChe = txtMaBienChe.Text.Trim();
            if (_bienCheServices.UpdateBienChe(updateBienChe))
            {
                MessageBox.Show("Đã Sửa Biên Chế Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                InitGridView();
                dataGridBienChe.Refresh();
                txtBienChe.Clear();
                txtMaBienChe.Clear();
                updateBienChe = null;
            }
            else
            {
                MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridBienChe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBienChe = _bienCheServices.GetBienCheById(Convert.ToInt32(dataGridBienChe.CurrentRow.Cells[0].Value.ToString()));
            txtMaBienChe.Text = updateBienChe.maBienChe;
            txtBienChe.Text = updateBienChe.bienChe1;
        }

        #endregion

        #region Init

        public void InitGridView()
        {
            dataGridBienChe.DataSource = _bienCheServices.GetAllBienChe().OrderBy(x => x.maBienChe).ToList().Select(x =>
                new
                {
                    ID = x.idBienChe,
                    MaBienChe = x.maBienChe,
                    TenBienChe = x.bienChe1
                }).ToList();
            dataGridBienChe.Columns[0].Visible = false;
            dataGridBienChe.CurrentCell = null;
        }
  
        #endregion
    }
}
