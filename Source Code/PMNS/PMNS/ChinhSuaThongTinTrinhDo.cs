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

    using PMNS.Entities.Models;
    using PMNS.Services.Abstract;
    using PMNS.Services.Models;

    public partial class ChinhSuaThongTinTrinhDo : Form
    {
        #region Properties

        private ThongTinNhanVIen empDetails;

        #endregion

        #region Constructor Or Destructor

        protected readonly IThongTinTrinhDoServices thongTinTrinhDoServices;
        protected readonly ITrinhDoServices trinhDoServices;

        public ChinhSuaThongTinTrinhDo(IThongTinTrinhDoServices thongTinTrinhDoServices, ITrinhDoServices trinhDoServices,
            ThongTinNhanVIen empDetails)
        {
            this.thongTinTrinhDoServices = thongTinTrinhDoServices;
            this.trinhDoServices = trinhDoServices;
            this.empDetails = empDetails;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void ChinhSuaThongTinTrinhDo_Load(object sender, EventArgs e)
        {
            InitData();
            if (empDetails.ThongTinTrinhDoes.Count != 0)
            {
                var info = empDetails.ThongTinTrinhDoes.FirstOrDefault();
                cbTrinhDo.SelectedValue = info.idTrinhDo;
                txtNoiDaoTao.Text = info.noiDaoTao;
                datetimeTotNghiep.Value = info.thoiGianTotNghiep;
                txtChuyenNganh.Text = info.chuyenNganh;
                txtLoaiHinh.Text = info.loaiHinh;
                txtChungChi.Text = info.bangCapPhu_CC;
                btnFunction.Text = "Sửa";
            }
            else
            {
                MessageBox.Show("Nhân Viên Này Chưa Cập Nhật Thông Tin Học Vấn. Vui Lòng Thêm Thông Tin.",
                    "Thông Báo!", MessageBoxButtons.OK);
                btnFunction.Text = "Thêm";
            }
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (empDetails.ThongTinTrinhDoes.Count != 0)
            {
                try
                {
                    empDetails.ThongTinTrinhDoes.FirstOrDefault().idTrinhDo = Convert.ToInt32((cbTrinhDo.SelectedItem as TrinhDo).idTrinhDo);
                    empDetails.ThongTinTrinhDoes.FirstOrDefault().loaiHinh = txtLoaiHinh.Text.Trim();
                    empDetails.ThongTinTrinhDoes.FirstOrDefault().noiDaoTao = txtNoiDaoTao.Text.Trim();
                    empDetails.ThongTinTrinhDoes.FirstOrDefault().thoiGianTotNghiep = datetimeTotNghiep.Value;
                    empDetails.ThongTinTrinhDoes.FirstOrDefault().chuyenNganh = txtChuyenNganh.Text.Trim();
                    empDetails.ThongTinTrinhDoes.FirstOrDefault().bangCapPhu_CC = txtChungChi.Text.Trim();
                    thongTinTrinhDoServices.CommitThongTinTrinhDo();
                    MessageBox.Show("Đã Chỉnh Sửa Thông Tin Thành Công!", "Thành Công!", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (InvalidOperationException ex)
                {
                    if (UserProfile.permission == 1)
                    {
                        MessageBox.Show(ex.ToString(), "Lỗi!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã Có Lỗi Xảy Ra! Vui Lòng Kiểm Tra Lại Thông Tin!", "Lỗi!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                try
                {
                    var trinhDoInfo = new PMNS.Entities.Models.ThongTinTrinhDo
                    {
                        idTrinhDo = Convert.ToInt32((cbTrinhDo.SelectedItem as TrinhDo).idTrinhDo),
                        loaiHinh = txtLoaiHinh.Text.Trim(),
                        noiDaoTao = txtNoiDaoTao.Text.Trim(),
                        thoiGianTotNghiep = datetimeTotNghiep.Value,
                        chuyenNganh = txtChuyenNganh.Text.Trim(),
                        bangCapPhu_CC = txtChungChi.Text.Trim()
                    };
                    empDetails.ThongTinTrinhDoes.Add(trinhDoInfo);
                    thongTinTrinhDoServices.CommitThongTinTrinhDo();
                    MessageBox.Show("Đã Thêm Thông Tin Thành Công!", "Thành Công!", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (InvalidOperationException ex)
                {
                    if (UserProfile.permission == 1)
                    {
                        MessageBox.Show(ex.ToString(), "Lỗi!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Đã Có Lỗi Xảy Ra! Vui Lòng Kiểm Tra Lại Thông Tin!", "Lỗi!"
                            , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Method Init

        private void InitData()
        {
            txtMaNV.ReadOnly = true;
            txtTenNV.ReadOnly = true;
            txtMaNV.Text = empDetails.MaNV;
            txtTenNV.Text = empDetails.hoTen;
            InitLoaiTrinhDo();
        }

        private void InitLoaiTrinhDo()
        {
            cbTrinhDo.DataSource = trinhDoServices.GetAllTrinhDo();
            cbTrinhDo.DisplayMember = "TrinhDo1";
            cbTrinhDo.ValueMember = "idTrinhDo";
        }

        #endregion

        #region Method DatetimePicker

        private void datetimeTotNghiep_ValueChanged_1(object sender, EventArgs e)
        {
            datetimeTotNghiep.Format = DateTimePickerFormat.Custom;
            datetimeTotNghiep.CustomFormat = "dd/MM/yyyy";
            txtThoiGianTotNghiep.Text = datetimeTotNghiep.Text;
        }

        #endregion
    }
}
