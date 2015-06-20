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
    using PMNS.Services.Abstract;
    using PMNS.Entities.Models;
    using PMNS.Services.Models;

    #endregion

    public partial class Dang_nhap : Form
    {
        #region Constructor Or Destructor
        protected readonly IBienCheServices _bienCheServices;
        protected readonly ICapBacServices _capBacServices;
        protected readonly IChucVuServices _chucVuServices;
        protected readonly IHopDongServices _hopDongServices;
        protected readonly IKhenThuongServices _khenThuongServices;
        protected readonly IKyLuatServices _kyLuatServices;
        protected readonly ILoaiHopDongServices _loaiHopDongServices;
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        protected readonly IThongTinGiaDinhServices _thongTinGiaDinhServices;
        protected readonly IThongTinServices _thongTinServices;
        protected readonly IThongTinTrinhDoServices _trinhDoServices;
        public Dang_nhap(IBienCheServices bienCheServices, ICapBacServices capBacServices, IChucVuServices chucVuServices,
            IHopDongServices hopDongServices, IKhenThuongServices khenThuongServices, IKyLuatServices kyLuatServices, ILoaiHopDongServices loaiHopDongServices,
            INhanVienServices nhanVienServices, IPhongBanServices phongBanServices, IThanhPhoServices thanhPhoServices, IThongTinGiaDinhServices thongTinGiaDinhServices,
            IThongTinServices thongTinServices, IThongTinTrinhDoServices trinhDoServices)
        {
            this._bienCheServices = bienCheServices;
            this._capBacServices = capBacServices;
            this._chucVuServices = chucVuServices;
            this._hopDongServices = hopDongServices;
            this._khenThuongServices = khenThuongServices;
            this._kyLuatServices = kyLuatServices;
            this._loaiHopDongServices = loaiHopDongServices;
            this._nhanVienServices = nhanVienServices;
            this._phongBanServices = phongBanServices;
            this._thanhPhoServices = thanhPhoServices;
            this._thongTinGiaDinhServices = thongTinGiaDinhServices;
            this._thongTinServices = thongTinServices;
            this._trinhDoServices = trinhDoServices;
            InitializeComponent();
        }
        #endregion

        #region Method Event

        private void Dang_nhap_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxX1;
        }
        private void buttonX2_Click(object sender, EventArgs e)
        {
            Dang_nhap.ActiveForm.Close();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxX1.Text.Trim()) || String.IsNullOrEmpty(textBoxX2.Text.Trim()))
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = textBoxX1.Text.Trim();
                string pass = textBoxX2.Text.Trim();
                string thongBao = _nhanVienServices.GetEmployeeByNameAndPass(name, pass);
                if (UserProfile.idNhanVien != 0)
                {
                    MessageBox.Show(thongBao, "Xin Chào", MessageBoxButtons.OK);
                    Menu form = new Menu(_bienCheServices, _capBacServices, _chucVuServices, _hopDongServices, _khenThuongServices, _kyLuatServices,
                        _loaiHopDongServices, _nhanVienServices, _phongBanServices, _thanhPhoServices, _thongTinGiaDinhServices, _thongTinServices, _trinhDoServices);
                    form.Show();
                    DanhSachNhanVien danhSachForm = new DanhSachNhanVien(_nhanVienServices, _phongBanServices, _thanhPhoServices, _chucVuServices,
                        _capBacServices, _bienCheServices, _loaiHopDongServices, _trinhDoServices, _thongTinGiaDinhServices);
                    danhSachForm.ShowDialog(this);
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
