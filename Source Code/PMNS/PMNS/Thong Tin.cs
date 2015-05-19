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
    public partial class ThongTin_TuyenDung : Form
    {
        protected readonly INhanVienServices _nhanVienServices;
        protected readonly IThongTinServices _thongTinServices;
        public ThongTin_TuyenDung(INhanVienServices nhanVienServices,IThongTinServices thongTinServices)
        {
            this._nhanVienServices = nhanVienServices;
            this._thongTinServices = thongTinServices;
            InitializeComponent();
        }

        #region Form's Event
        private void ThongTin_TuyenDung_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        

        #region Init

        #endregion
    }
}
