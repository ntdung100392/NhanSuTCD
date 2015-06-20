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
    using PMNS.Services.Models;

    #endregion

    public partial class QuanLyChucVu : Form
    {
        #region Properties

        private ChucVu updateChucVu = new ChucVu();

        #endregion

        #region Constructor Or Destructor

        protected readonly IChucVuServices _chucVuServices;
        public QuanLyChucVu(IChucVuServices chucVuServices)
        {
            this._chucVuServices = chucVuServices;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void dataGridChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateChucVu = _chucVuServices.GetChucVuById(Convert.ToInt32(dataGridChucVu.CurrentRow.Cells[0].Value.ToString()));
            txtMaChucVu.Text = updateChucVu.MaChucVu;
            txtChucVu.Text = updateChucVu.ChucVu1;
            btnSuaChucVu.Enabled = true;
            btnThemChucVu.Enabled = false;
        }

        private void QuanLyChucVu_Load(object sender, EventArgs e)
        {
            btnSuaChucVu.Enabled = false;
            InitGridView();
        }

        private void btnThemChucVu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtChucVu.Text.Trim()) || String.IsNullOrEmpty(txtMaChucVu.Text.Trim()))
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
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
                        MessageBox.Show("Lỗi! Thông Tin Chức Vụ Bị Trùng, Vui Lòng Kiểm Tra Lại!", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Đã Có Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
        }

        private void btnSuaChucVu_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtChucVu.Text.Trim()) || String.IsNullOrEmpty(txtMaChucVu.Text.Trim()))
            {
                MessageBox.Show("Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (_chucVuServices.FindChucVu(txtChucVu.Text.Trim(), txtMaChucVu.Text.Trim()) == null)
                    {
                        updateChucVu.ChucVu1 = txtChucVu.Text.Trim();
                        updateChucVu.MaChucVu = txtMaChucVu.Text.Trim();
                        if (_chucVuServices.UpdateChucVu(updateChucVu))
                        {
                            MessageBox.Show("Đã Sửa Chức Vụ Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                            InitGridView();
                            dataGridChucVu.Refresh();
                            ClearAllText(this);
                            btnSuaChucVu.Enabled = false;
                            btnThemChucVu.Enabled = true;
                            updateChucVu = null;
                        }
                        else
                        {
                            MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lỗi! Thông Tin Chức Vụ Bị Trùng, Vui Lòng Kiểm Tra Lại!", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show("Đã Có Lỗi! Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
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

        #region Method Init

        public void InitGridView()
        {
            dataGridChucVu.DataSource = _chucVuServices.GetAllChucVu().OrderBy(x => x.MaChucVu).ToList().Select(
                x => new
                {
                    ID = x.idChucVu,
                    MaChucVu = x.MaChucVu,
                    ChucVu = x.ChucVu1,
                }).ToList();
            dataGridChucVu.Columns[0].Visible = false;
            dataGridChucVu.CurrentCell = null;
        }

        #endregion
    }
}
