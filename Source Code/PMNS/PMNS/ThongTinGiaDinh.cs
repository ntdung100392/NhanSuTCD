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

    public partial class ThongTinGiaDinh : Form
    {
        #region Properties

        private ThongTinNhanVIen empDetails;

        #endregion

        #region Constructor Or Destructor

        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IThongTinGiaDinhServices _thongTinGiaDInhServices;
        public ThongTinGiaDinh(INhanVienServices nhanVienServices, IThongTinGiaDinhServices thongTinGiaDinhServices, ThongTinNhanVIen empDetails)
        {
            this._nhanVienServices = nhanVienServices;
            this._thongTinGiaDInhServices = thongTinGiaDinhServices;
            this.empDetails = empDetails;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void ThongTinGiaDinh_Load(object sender, EventArgs e)
        {
            if (empDetails != null)
            {
                btnFunction.Text = "Sửa";
                PMNS.Entities.Models.ThongTinGiaDinh thongTin =
                    _thongTinGiaDInhServices.GetThongTinByNhanVienId(empDetails.idNhanVien);
                txtMaNv.ReadOnly = true;
                txtMaNv.Text = empDetails.MaNV;
                txtTenNv.ReadOnly = true;
                txtTenNv.Text = empDetails.hoTen;
                txtNoiCongTac.ReadOnly = true;
                txtNoiCongTac.Text = empDetails.noiCongTac;
            }
            else
            {
                MessageBox.Show("Nhân Viên Này Chưa Có Thông Tin Học Vấn! Vui Lòng Thêm Thông Tin!","Thông Báo!",MessageBoxButtons.OK);
                btnFunction.Text = "Thêm";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (empDetails != null)
            {
                try
                {
                    PMNS.Entities.Models.ThongTinGiaDinh updateThongTin =
                        _thongTinGiaDInhServices.GetThongTinByNhanVienId(empDetails.idNhanVien);
                    updateThongTin.hoTenCha = txtHoTenCha.Text;
                    updateThongTin.namSinhCha = Convert.ToDateTime(txtNamSinhCha.Text);
                    updateThongTin.ngheNghiepCha = txtNgheNghiepCha.Text;
                    updateThongTin.hoTenMe = txtHoTenMe.Text;
                    updateThongTin.namSinhMe = Convert.ToDateTime(txtNamSinhMe.Text);
                    updateThongTin.ngheNghiepMe = txtNgheNghiepMe.Text;
                    updateThongTin.thongTinConCai = txtConCai.Text;
                    if (_thongTinGiaDInhServices.UpdateThongTinGiaDinh(updateThongTin))
                    {
                        MessageBox.Show("Đã Chỉnh Sửa Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                try
                {
                    PMNS.Entities.Models.ThongTinGiaDinh addThongTin = new Entities.Models.ThongTinGiaDinh
                    {
                        idNhanVien = _nhanVienServices.GetEmpByMaNV(txtMaNv.Text).idNhanVien,
                        hoTenCha = txtHoTenCha.Text,
                        namSinhCha = Convert.ToDateTime(txtNamSinhCha.Text),
                        ngheNghiepCha = txtNgheNghiepCha.Text,
                        hoTenMe = txtHoTenMe.Text,
                        namSinhMe = Convert.ToDateTime(txtNamSinhMe.Text),
                        ngheNghiepMe = txtNgheNghiepMe.Text,
                        thongTinConCai = txtConCai.Text
                    };
                    if (_thongTinGiaDInhServices.AddThongTinGiaDinh(addThongTin))
                    {
                        MessageBox.Show("Đã Thêm Thông Tin Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng Kiểm Tra Thông Tin Đầu Vào!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion
    }
}
