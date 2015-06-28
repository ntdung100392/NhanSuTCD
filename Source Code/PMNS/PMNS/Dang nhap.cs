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

    public partial class Dang_nhap : Form
    {
        #region Constructor Or Destructor

        protected readonly IBienCheServices bienCheServices;
        protected readonly ICapBacServices capBacServices;
        protected readonly IChucVuServices chucVuServices;
        protected readonly IHopDongServices hopDongServices;
        protected readonly IKhenThuongServices khenThuongServices;
        protected readonly IKyLuatServices kyLuatServices;
        protected readonly ILoaiHopDongServices loaiHopDongServices;
        protected readonly INhanVienServices nhanVienServices;
        protected readonly IPhongBanServices phongBanServices;
        protected readonly IThanhPhoServices thanhPhoServices;
        protected readonly IThongTinGiaDinhServices thongTinGiaDinhServices;
        protected readonly IThongTinServices thongTinServices;
        protected readonly IThongTinTrinhDoServices thongTinTrinhDoServices;
        protected readonly ITrinhDoServices trinhDoServices;

        public Dang_nhap(IBienCheServices bienCheServices, ICapBacServices capBacServices, IChucVuServices chucVuServices,
            IHopDongServices hopDongServices, IKhenThuongServices khenThuongServices, IKyLuatServices kyLuatServices, ILoaiHopDongServices loaiHopDongServices,
            INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IThanhPhoServices thanhPhoServices, IThongTinGiaDinhServices thongTinGiaDinhServices,
            IThongTinServices thongTinServices, IThongTinTrinhDoServices thongTinTrinhDoServices, ITrinhDoServices trinhDoServices)
        {
            this.bienCheServices = bienCheServices;
            this.capBacServices = capBacServices;
            this.chucVuServices = chucVuServices;
            this.hopDongServices = hopDongServices;
            this.khenThuongServices = khenThuongServices;
            this.kyLuatServices = kyLuatServices;
            this.loaiHopDongServices = loaiHopDongServices;
            this.nhanVienServices = nhanVienServices;
            this.phongBanServices = phongBanServices;
            this.thanhPhoServices = thanhPhoServices;
            this.thongTinGiaDinhServices = thongTinGiaDinhServices;
            this.thongTinServices = thongTinServices;
            this.thongTinTrinhDoServices = thongTinTrinhDoServices;
            this.trinhDoServices = trinhDoServices;
            InitializeComponent();
        }

        #endregion

        #region Method Event

        private void Dang_nhap_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserName;
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserName.Text.Trim()) || String.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = txtUserName.Text.Trim();
                string pass = txtPassword.Text.Trim();
                string thongBao = nhanVienServices.GetEmployeeByNameAndPass(name, pass);
                if (UserProfile.idNhanVien != 0)
                {
                    Menu menu = new Menu(bienCheServices, capBacServices, chucVuServices, hopDongServices, khenThuongServices, kyLuatServices,
                        loaiHopDongServices, nhanVienServices, phongBanServices, thanhPhoServices, thongTinGiaDinhServices, thongTinServices, thongTinTrinhDoServices,
                        trinhDoServices);
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(thongBao, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxX2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonX1.PerformClick();
            }
        }

        #endregion
    }
}
