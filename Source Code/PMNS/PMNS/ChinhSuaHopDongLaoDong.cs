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

    #region Delegate

    public delegate void OnClosingContractModifier(bool close);

    #endregion

    public partial class ChinhSuaHopDongLaoDong : Form
    {
        #region Properties

        private HopDongLaoDong hopDongDetails = new HopDongLaoDong();
        public event OnClosingContractModifier OnClose;

        #endregion

        #region Constructor Or Destructor

        protected readonly IHopDongServices hopDongServices;
        protected readonly ILoaiHopDongServices loaiHopDongServices;
        protected readonly INhanVienServices nhanVienServices;

        public ChinhSuaHopDongLaoDong(IHopDongServices hopDongServices, ILoaiHopDongServices loaiHopDongServices,
            INhanVienServices nhanVienServices, HopDongLaoDong hopDongDetails)
        {
            this.hopDongServices = hopDongServices;
            this.loaiHopDongServices = loaiHopDongServices;
            this.nhanVienServices = nhanVienServices;
            this.hopDongDetails = hopDongDetails;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void ChinhSuaHopDongLaoDong_Load(object sender, EventArgs e)
        {
            InitMain();
        }

        protected virtual void FireEvent(bool close)
        {
            if (OnClose != null)
            {
                OnClose(close);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                this.hopDongDetails.idLoaiHopDong = Convert.ToInt32((cbLoaiHopDong.SelectedItem as LoaiHopDong).idLoaiHopDong);
                this.hopDongDetails.ngayBatDau = datetimeNgayBatDau.Value;
                this.hopDongDetails.ngayKetThuc = dateTimeNgayKetThuc.Value;
                this.hopDongDetails.nguoiBaoLanh_TTHDLD = txtNguoiBaoLanh.Text;
                this.hopDongDetails.soHopDong_TTHDLD = txtSoHopDong.Text;
                this.hopDongDetails.chucDanh = txtChucDanh.Text;
                this.hopDongDetails.ghiChu = txtGhiChu.Text;
                if (hopDongServices.UpdateHopDongLaoDong(this.hopDongDetails))
                {
                    MessageBox.Show("Đã Cập Nhật Thông Tin Thành Công!", "Thông Báo!", MessageBoxButtons.OK);
                    hopDongDetails = null;
                    FireEvent(true);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đã Có Lỗi Xảy Ra! Vui Lòng Kiểm Tra Lại Thông Tin!", "Lỗi!",
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
                    MessageBox.Show("Đã Có Lỗi Xảy Ra! Vui Lòng Kiểm Tra Lại Thông Tin!", "Lỗi!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FireEvent(true);
            this.Close();
        }

        #endregion

        #region Method DateTimePicker

        private void datetimeNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            datetimeNgayBatDau.Format = DateTimePickerFormat.Custom;
            datetimeNgayBatDau.CustomFormat = "dd/MM/yyyy";
            txtNgayBatDau.Text = datetimeNgayBatDau.Text;
        }

        private void dateTimeNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            dateTimeNgayKetThuc.Format = DateTimePickerFormat.Custom;
            dateTimeNgayKetThuc.CustomFormat = "dd/MM/yyyy";
            txtNgayKetThuc.Text = dateTimeNgayKetThuc.Text;
        }

        #endregion

        #region Method Init

        private void InitMain()
        {
            InitLoaiHopDong();
            InitDetails(this.hopDongDetails);
        }

        private void InitLoaiHopDong()
        {
            var listLoaiHopDong = loaiHopDongServices.GettAllLoaiHopDong().ToList();
            if (listLoaiHopDong.Count != 0)
            {
                foreach (var loaiHd in loaiHopDongServices.GettAllLoaiHopDong())
                {
                    if (loaiHd.idCha != 0 && loaiHd.idLoaiHopDong != 0)
                    {
                        foreach (var removeHd in listLoaiHopDong)
                        {
                            if (loaiHd.idCha == removeHd.idLoaiHopDong)
                            {
                                listLoaiHopDong.Remove(removeHd);
                                break;
                            }
                        }
                    }
                }
            }
            cbLoaiHopDong.DataSource = listLoaiHopDong;
            cbLoaiHopDong.DisplayMember = "loaiHopDong1";
            cbLoaiHopDong.ValueMember = "idLoaiHopDong";
        }

        private void InitDetails(HopDongLaoDong hopDongDetails)
        {
            if (hopDongDetails != null)
            {
                txtMaNv.Text = hopDongDetails.ThongTinNhanVIen.MaNV;
                txtTenNV.Text = hopDongDetails.ThongTinNhanVIen.hoTen;
                txtSoHopDong.Text = hopDongDetails.soHopDong_TTHDLD;
                txtNguoiBaoLanh.Text = hopDongDetails.nguoiBaoLanh_TTHDLD;
                txtChucDanh.Text = hopDongDetails.chucDanh;
                cbLoaiHopDong.SelectedValue = hopDongDetails.idLoaiHopDong;
                datetimeNgayBatDau.Value = hopDongDetails.ngayBatDau;
                dateTimeNgayKetThuc.Value = hopDongDetails.ngayKetThuc;
                txtGhiChu.Text = hopDongDetails.ghiChu;
            }
            else
            {
                MessageBox.Show("Không Tìm Thấy Thông Tin Hợp Đồng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FireEvent(true);
                this.Close();
            }
        }

        #endregion
    }
}
