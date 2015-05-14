using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMNS.Services.Abstract;
using PMNS.Services.Implement;
using PMNS.DAL.Abstract;
using PMNS.DAL.Implement;
using PMNS.Services.Models;

namespace PMNS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnitOfWork unitOfWork = new UnitOfWork();
            IPhongBanServices _phongBanServices = new PhongBanServices(unitOfWork);
            IDoiServices _doiServices = new DoiServices(unitOfWork);
            INhanVienServices _nhanVienServices = new NhanVienServices(unitOfWork);
            IToServices _toServices = new ToServices(unitOfWork);
            ILoaiToServices _loaiToServices = new LoaiToServices(unitOfWork);
            IThanhPhoServices _thanhPhoServices = new ThanhPhoServices(unitOfWork);
            IChucVuServices _chucVuServices = new ChucVuServices(unitOfWork);
            ICapBacServices _capBacServices = new CapBacServices(unitOfWork);
            IBienCheServices _bienCheServices = new BienCheServices(unitOfWork);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Dang_nhap(_nhanVienServices, _phongBanServices));
            //if (UserLogin.permission == 1)
            //{
            //Application.Run(new ThemNV(_nhanVienServices, _phongBanServices, _doiServices, _toServices, _loaiToServices, 
            ////    _thanhPhoServices, _chucVuServices));
            //Application.Run(new ThemNV(_nhanVienServices, _phongBanServices, _doiServices, _toServices, _loaiToServices,
            //        _thanhPhoServices, _chucVuServices, _capBacServices, _bienCheServices));
            Application.Run(new QuanLyCapBac(_capBacServices));
            //}
            //else
            //{
            //    MessageBox.Show("Bạn Không Có Quyền Sử Dụng Chức Năng Này", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    Application.Run(new Dang_nhap(_nhanVienServices, _phongBanServices, _doiServices, _toServices, _loaiToServices, 
            //        _thanhPhoServices, _chucVuServices));
            //}
        }
    }
}
