namespace PMNS
{
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
    using PMNS.Services.Models;

    public partial class QuanLyLoaiTrinhDo : Form
    {
        #region Properties

        private TrinhDo updateTrinhDo = new TrinhDo();

        #endregion

        #region Constructor Or Destructor

        protected readonly ITrinhDoServices trinhDoServices;

        public QuanLyLoaiTrinhDo(ITrinhDoServices trinhDoServices)
        {
            this.trinhDoServices = trinhDoServices;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void QuanLyLoaiTrinhDo_Load(object sender, EventArgs e)
        {
            btnSuaTrinhDo.Enabled = false;
            InitGridView();
        }

        private void btnThemTrinhDo_Click(object sender, EventArgs e)
        {
            try
            {
                TrinhDo trinhDo = new TrinhDo
                {
                    TrinhDo1 = txtTrinhDo.Text.Trim()
                };
                if (trinhDoServices.AddTrinhDo(trinhDo))
                {
                    MessageBox.Show("Đã Thêm Trình Độ Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    InitGridView();
                    dataGridTrinhDo.Refresh();
                    txtTrinhDo.Text = "";
                }
                else
                {
                    MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
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

        private void btnSuaTrinhDo_Click(object sender, EventArgs e)
        {
            try
            {
                updateTrinhDo.TrinhDo1 = txtTrinhDo.Text.Trim();
                if (trinhDoServices.UpdateTrinhDo(updateTrinhDo))
                {
                    MessageBox.Show("Đã Sửa Trình Độ Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                    InitGridView();
                    dataGridTrinhDo.Refresh();
                    updateTrinhDo = null;
                    txtTrinhDo.Text = "";
                    btnSuaTrinhDo.Enabled = false;
                    btnThemTrinhDo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Lỗi! Vui Lòng Kiểm Tra Lại Thông Tin Đầu Vào!", "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (InvalidOperationException ex)
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

        private void dataGridTrinhDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updateTrinhDo = trinhDoServices.GetTrinhDoById(Convert.ToInt32(dataGridTrinhDo.CurrentRow.Cells[0].Value.ToString()));
            txtTrinhDo.Text = updateTrinhDo.TrinhDo1;
            btnSuaTrinhDo.Enabled = true;
            btnThemTrinhDo.Enabled = false;
        }

        #endregion

        #region Method Init

        private void InitGridView()
        {
            dataGridTrinhDo.DataSource = trinhDoServices.GetAllTrinhDo().Select(td =>
                new
                {
                    MaTrinhDo = td.idTrinhDo,
                    LoaiTrinhDo = td.TrinhDo1
                }).ToList();
            dataGridTrinhDo.CurrentCell = null;
        }

        #endregion
    }
}
