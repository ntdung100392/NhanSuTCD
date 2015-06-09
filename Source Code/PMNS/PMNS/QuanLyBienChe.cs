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

        #region Constructor Or Destructor
        protected readonly IBienCheServices _bienCheServices;
        private BienChe updateBienChe = new BienChe();
        public QuanLyBienChe(IBienCheServices bienCheServices)
        {
            this._bienCheServices = bienCheServices;
            InitializeComponent();
        }
        #endregion

        #region Form's Event
        private void QuanLyBienChe_Load(object sender, EventArgs e)
        {
            btnSuaBienChe.Enabled = false;
            InitGridView();
        }

        private void btnThemBienChe_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtBienChe.Text.Trim()) || String.IsNullOrEmpty(txtMaBienChe.Text.Trim()))
                {
                    MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (_bienCheServices.FindBienChe(txtBienChe.Text.Trim(), txtMaBienChe.Text.Trim()) == null)
                    {
                        BienChe bienChe = new BienChe
                        {
                            bienChe1 = txtBienChe.Text.Trim(),
                            maBienChe = txtMaBienChe.Text.Trim()
                        };
                        if (_bienCheServices.AddBienChe(bienChe))
                        {
                            MessageBox.Show("Đã Thêm Biên Chế Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                            InitGridView();
                            dataGridBienChe.Refresh();
                            ClearAllText(this);
                        }
                        else
                        {
                            MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi! Thông Tin Biên Chế Bị Trùng, Vui Lòng Kiểm Tra Lại!", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                        
        }

        private void btnSuaBienChe_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtBienChe.Text.Trim()) || String.IsNullOrEmpty(txtMaBienChe.Text.Trim()))
                {
                    MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    updateBienChe.bienChe1 = txtBienChe.Text.Trim();
                    updateBienChe.maBienChe = txtMaBienChe.Text.Trim();
                    if (_bienCheServices.UpdateBienChe(updateBienChe))
                    {
                        MessageBox.Show("Đã Sửa Biên Chế Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                        InitGridView();
                        dataGridBienChe.Refresh();
                        ClearAllText(this);
                        updateBienChe = null;
                        btnSuaBienChe.Enabled = false;
                        btnThemBienChe.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                        
        }

        private void dataGridBienChe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBienChe = _bienCheServices.GetBienCheById(Convert.ToInt32(dataGridBienChe.CurrentRow.Cells[0].Value.ToString()));
            txtMaBienChe.Text = updateBienChe.maBienChe;
            txtBienChe.Text = updateBienChe.bienChe1;
            btnSuaBienChe.Enabled = true;
            btnThemBienChe.Enabled = false;
        }

        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
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
