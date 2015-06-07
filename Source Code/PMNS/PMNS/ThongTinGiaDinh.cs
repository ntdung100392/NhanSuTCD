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
    public partial class ThongTinGiaDinh : Form
    {
        #region Constructor Or Destructor
        protected readonly IThongTinGiaDinhServices _thongTinGiaDInhServices;
        private ThongTinNhanVIen _empDetails;
        public ThongTinGiaDinh(IThongTinGiaDinhServices thongTinGiaDinhServices, ThongTinNhanVIen empDetails)
        {
            this._thongTinGiaDInhServices = thongTinGiaDinhServices;
            this._empDetails = empDetails;
            InitializeComponent();
        }
        #endregion

        private void ThongTinGiaDinh_Load(object sender, EventArgs e)
        {
            if (_empDetails != null)
            {
                btnFunction.Text = "Sửa";
                PMNS.Entities.Models.ThongTinGiaDinh thongTin =
                    _thongTinGiaDInhServices.GetThongTinByNhanVienId(_empDetails.idNhanVien);
                txtMaNv.ReadOnly = true;
                txtMaNv.Text = _empDetails.MaNV;
                txtTenNv.ReadOnly = true;
                txtTenNv.Text = _empDetails.hoTen;
                txtNoiCongTac.ReadOnly = true;
                txtNoiCongTac.Text = _empDetails.noiCongTac;
            }
            else
            {
                btnFunction.Text = "Thêm";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
