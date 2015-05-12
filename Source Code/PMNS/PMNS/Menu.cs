using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMNS.Entities.Models;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;

namespace PMNS
{
    public partial class Menu : Form
    {
        protected readonly IPhongBanServices _phongBanServices;
        protected readonly IDoiServices _doiServices;
        protected readonly IToServices _toServices;
        protected readonly ILoaiToServices _loaiToServices;
        protected readonly IThanhPhoServices _thanhPhoServices;
        public Menu(IPhongBanServices phongBanServices, IDoiServices doiServices, IToServices toServices, ILoaiToServices loaiToServices, IThanhPhoServices thanhPhoServices)
        {
            this._doiServices = doiServices;
            this._phongBanServices = phongBanServices;
            this._toServices = toServices;
            this._loaiToServices = loaiToServices;
            this._thanhPhoServices = thanhPhoServices;
            InitializeComponent();
        }
        public void Form1_Load(object sender, EventArgs e)
        {

        }
        public void thêmNhânViênMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemNV ThemNV = new ThemNV(_phongBanServices, _doiServices, _toServices, _loaiToServices, _thanhPhoServices);
            ThemNV.Show();
        }

        private void chỉnhSửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChinhSuaThongTin formChinhsưa = new ChinhSuaThongTin();
            formChinhsưa.Show();
        }
    }
}
