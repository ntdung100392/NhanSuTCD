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

        protected readonly INhanVienServices nhanVienServices;
        protected readonly IThongTinGiaDinhServices thongTinGiaDinhServices;
        public ThongTinGiaDinh(INhanVienServices nhanVienServices, IThongTinGiaDinhServices thongTinGiaDinhServices, ThongTinNhanVIen empDetails)
        {
            this.nhanVienServices = nhanVienServices;
            this.thongTinGiaDinhServices = thongTinGiaDinhServices;
            this.empDetails = empDetails;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void ThongTinGiaDinh_Load(object sender, EventArgs e)
        {
            InitDetails();
            if (empDetails.ThongTinGiaDinhs.Count != 0)
            {
                btnFunction.Text = "Sửa";
                txtHoTenCha.Text = empDetails.ThongTinGiaDinhs.FirstOrDefault().hoTenCha;
                datetimeNgaySinhCha.Value = empDetails.ThongTinGiaDinhs.FirstOrDefault().namSinhCha;
                txtNgheNghiepCha.Text = empDetails.ThongTinGiaDinhs.FirstOrDefault().ngheNghiepCha;
                txtHoTenMe.Text = empDetails.ThongTinGiaDinhs.FirstOrDefault().hoTenMe;
                dateTimeNgaySinhMe.Value = empDetails.ThongTinGiaDinhs.FirstOrDefault().namSinhMe;
                txtNgheNghiepMe.Text = empDetails.ThongTinGiaDinhs.FirstOrDefault().ngheNghiepMe;
                txtHoTenVoChong.Text = empDetails.ThongTinGiaDinhs.FirstOrDefault().hoTenVoChong;
                txtNgheNghiepVoChong.Text = empDetails.ThongTinGiaDinhs.FirstOrDefault().ngheNghiepVoChong;
                datetimeNgaySinhCV.Value = Convert.ToDateTime(empDetails.ThongTinGiaDinhs.FirstOrDefault().namSinhVoChong);
                txtConCai.Text = empDetails.ThongTinGiaDinhs.FirstOrDefault().thongTinConCai;
            }
            else
            {
                MessageBox.Show("Nhân Viên Này Chưa Có Thông Tin Gia Đình! Vui Lòng Thêm Thông Tin!", "Thông Báo!", MessageBoxButtons.OK);
                btnFunction.Text = "Thêm";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            if (empDetails.ThongTinGiaDinhs.Count != 0)
            {
                try
                {
                    empDetails.ThongTinGiaDinhs.FirstOrDefault().hoTenCha = txtHoTenCha.Text;
                    empDetails.ThongTinGiaDinhs.FirstOrDefault().namSinhCha = datetimeNgaySinhCha.Value;
                    empDetails.ThongTinGiaDinhs.FirstOrDefault().ngheNghiepCha = txtNgheNghiepCha.Text;
                    empDetails.ThongTinGiaDinhs.FirstOrDefault().hoTenMe = txtHoTenMe.Text;
                    empDetails.ThongTinGiaDinhs.FirstOrDefault().namSinhMe = dateTimeNgaySinhMe.Value;
                    empDetails.ThongTinGiaDinhs.FirstOrDefault().ngheNghiepMe = txtNgheNghiepMe.Text;
                    empDetails.ThongTinGiaDinhs.FirstOrDefault().hoTenVoChong = txtHoTenVoChong.Text;
                    empDetails.ThongTinGiaDinhs.FirstOrDefault().ngheNghiepVoChong = txtNgheNghiepVoChong.Text;
                    empDetails.ThongTinGiaDinhs.FirstOrDefault().namSinhVoChong = datetimeNgaySinhCV.Value;
                    empDetails.ThongTinGiaDinhs.FirstOrDefault().thongTinConCai = txtConCai.Text;
                    thongTinGiaDinhServices.CommitThongTinGiaDinh();
                    MessageBox.Show("Đã Chỉnh Sửa Thông Tin Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                    this.Close();
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
                    var familyInfo = new Entities.Models.ThongTinGiaDinh
                    {
                        hoTenCha = txtHoTenCha.Text,
                        namSinhCha = datetimeNgaySinhCha.Value,
                        ngheNghiepCha = txtNgheNghiepCha.Text,
                        hoTenMe = txtHoTenMe.Text,
                        namSinhMe = dateTimeNgaySinhMe.Value,
                        ngheNghiepMe = txtNgheNghiepMe.Text,
                        hoTenVoChong = txtHoTenVoChong.Text,
                        namSinhVoChong = datetimeNgaySinhCV.Value,
                        ngheNghiepVoChong = txtNgheNghiepVoChong.Text,
                        thongTinConCai = txtConCai.Text
                    };
                    empDetails.ThongTinGiaDinhs.Add(familyInfo);
                    thongTinGiaDinhServices.CommitThongTinGiaDinh();
                    MessageBox.Show("Đã Thêm Thông Tin Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                    this.Close();
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

        #region Method Init

        private void InitDetails()
        {
            txtMaNv.ReadOnly = true;
            txtMaNv.Text = empDetails.MaNV;
            txtTenNv.ReadOnly = true;
            txtTenNv.Text = empDetails.hoTen;
            txtNoiCongTac.ReadOnly = true;
            txtNoiCongTac.Text = empDetails.noiCongTac;
        }

        #endregion

        #region DateTime Picker Method

        private void datetimeNgaySinhCV_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgaySinhCV.Format = DateTimePickerFormat.Custom;
            datetimeNgaySinhCV.CustomFormat = "dd/MM/yyyy";
            txtNgaySinhCV.Text = datetimeNgaySinhCV.Text;
        }

        private void datetimeNgaySinhCha_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgaySinhCha.Format = DateTimePickerFormat.Custom;
            datetimeNgaySinhCha.CustomFormat = "dd/MM/yyyy";
            txtNgaySinhCha.Text = datetimeNgaySinhCha.Text;
        }

        private void dateTimeNgaySinhMe_ValueChanged(object sender, EventArgs e)
        {
            dateTimeNgaySinhMe.Format = DateTimePickerFormat.Custom;
            dateTimeNgaySinhMe.CustomFormat = "dd/MM/yyyy";
            txtNgaySinhMe.Text = dateTimeNgaySinhMe.Text;
        }

        #endregion
    }
}
