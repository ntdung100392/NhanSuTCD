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
using PMNS.Model;

namespace PMNS
{
    public partial class QuanLyPhongBan : Form
    {
        protected readonly IPhongBanServices _phongBanServices;
        private PhongDoiToLoaiTo updatePhongBan = new PhongDoiToLoaiTo();
        public QuanLyPhongBan(IPhongBanServices phongBanServices)
        {
            this._phongBanServices = phongBanServices;
            InitializeComponent();
        }

        private void QuanLyPhongBan_Load(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            cbPhongBan.DropDownStyle = ComboBoxStyle.DropDownList;
            InitPhongBanComboBox();
            InitGridView();
        }

        private void dataGridPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            updatePhongBan = _phongBanServices.GetPhongBanById(Convert.ToInt32(dataGridPhongBan.CurrentRow.Cells[0].Value.ToString()));
            txtMaPB.Text = updatePhongBan.maPhongDoiToLoai;
            txtTenPB.Text = updatePhongBan.tenPhongDoiToLoai;
            cbPhongBan.SelectedValue = updatePhongBan.idCha;
            btnAdd.Enabled = false;
            btnSua.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenPB.Text.Trim()) || String.IsNullOrEmpty(txtMaPB.Text.Trim()))
            {
                MessageBox.Show("Thông Tin Chưa Đầy Đủ!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_phongBanServices.FindPhongBanByNameAndCode(txtMaPB.Text.Trim(), txtTenPB.Text.Trim()) == null)
                {
                    PhongDoiToLoaiTo insertPhongBan = new PhongDoiToLoaiTo
                    {
                        idCha = (cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai,
                        maPhongDoiToLoai = txtMaPB.Text.Trim(),
                        tenPhongDoiToLoai = txtTenPB.Text.Trim()
                    };
                    if (_phongBanServices.AddPhongBan(insertPhongBan))
                    {
                        MessageBox.Show("Đã Thêm Phòng Ban Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                        InitGridView();
                        dataGridPhongBan.Refresh();
                        ClearAllText(this);
                    }
                    else
                    {
                        MessageBox.Show("Đã Có Lỗi Xảy Ra! Vui Lòng Kiểm Tra Lại Thông Tin!", "Error!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thông Tin Phòng Ban Đã Có Trong Dữ Liệu!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTenPB.Text.Trim()) || String.IsNullOrEmpty(txtMaPB.Text.Trim()))
            {
                MessageBox.Show("Thông Tin Chưa Đầy Đủ!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_phongBanServices.FindPhongBanByNameAndCode(txtMaPB.Text.Trim(), txtTenPB.Text.Trim()) == null)
                {
                    updatePhongBan.idCha = (cbPhongBan.SelectedItem as PhongDoiToLoaiTo).idPhongDoiToLoai;
                    updatePhongBan.maPhongDoiToLoai = txtMaPB.Text.Trim();
                    updatePhongBan.tenPhongDoiToLoai = txtTenPB.Text.Trim();
                    if (_phongBanServices.UpdatePhongBan(updatePhongBan))
                    {
                        MessageBox.Show("Đã Chỉnh Sử Thông Tin Phòng Ban Thành Công!", "Thông Báo", MessageBoxButtons.OK);
                        InitGridView();
                        dataGridPhongBan.Refresh();
                        btnSua.Enabled = false;
                        btnAdd.Enabled = true;
                        ClearAllText(this);
                        updatePhongBan = null;
                    }
                    else
                    {
                        MessageBox.Show("Đã Có Lỗi Xảy Ra! Vui Lòng Kiểm Tra Lại Thông Tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Thông Tin Phòng Ban Chỉnh Sửa Bị Trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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

        #region Init
        private void InitGridView()
        {
            var phongBanList = _phongBanServices.GetAllPhongBan();
            List<PhongBanModel> listPhongBanModel = new List<PhongBanModel>();
            foreach (var phongBanEntity in phongBanList)
            {
                PhongBanModel phongBanModel = new PhongBanModel();
                phongBanModel.idPhongDoiToLoai = phongBanEntity.idPhongDoiToLoai;
                phongBanModel.maPhongDoiToLoai = phongBanEntity.maPhongDoiToLoai;
                phongBanModel.tenPhongDoiToLoai = phongBanEntity.tenPhongDoiToLoai;
                if (phongBanEntity.idCha == 0)
                {
                    phongBanModel.trucThuoc = "Không Có";
                }
                else
                {
                    phongBanModel.trucThuoc = _phongBanServices.GetPhongBanById(phongBanEntity.idCha).tenPhongDoiToLoai;
                }
                listPhongBanModel.Add(phongBanModel);
            }
            dataGridPhongBan.DataSource = listPhongBanModel.OrderBy(x => x.maPhongDoiToLoai).ToList().Select(x =>
                new
                {
                    Id = x.idPhongDoiToLoai,
                    MaPhongBan = x.maPhongDoiToLoai,
                    TenPhongBan = x.tenPhongDoiToLoai,
                    TrucThuoc = x.trucThuoc
                }).ToList();
            dataGridPhongBan.Columns[0].Visible = false;
            dataGridPhongBan.CurrentCell = null;
        }

        private void InitPhongBanComboBox()
        {
            List<PhongDoiToLoaiTo> listPhongBan = new List<PhongDoiToLoaiTo>();
            PhongDoiToLoaiTo khongTrucThuocItem = new PhongDoiToLoaiTo
            {
                tenPhongDoiToLoai = "Không Có",
                idPhongDoiToLoai = 0
            };
            listPhongBan.Add(khongTrucThuocItem);
            listPhongBan.AddRange(_phongBanServices.GetAllPhongBan());
            cbPhongBan.DataSource = listPhongBan;
            cbPhongBan.DisplayMember = "tenPhongDoiToLoai";
            cbPhongBan.ValueMember = "idPhongDoiToLoai";
        }
        #endregion
    }
}
