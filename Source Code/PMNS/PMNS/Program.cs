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
            INhanVienServices _nhanVienServices = new NhanVienServices(unitOfWork);
            IThanhPhoServices _thanhPhoServices = new ThanhPhoServices(unitOfWork);
            IChucVuServices _chucVuServices = new ChucVuServices(unitOfWork);
            ICapBacServices _capBacServices = new CapBacServices(unitOfWork);
            IBienCheServices _bienCheServices = new BienCheServices(unitOfWork);
            IThongTinServices _thongTinServices = new ThongTinServices(unitOfWork);
            IThongTinTrinhDoServices _trinhDoServices = new ThongTinTrinhDoServices(unitOfWork);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ThongTin_TuyenDung(_nhanVienServices, _thongTinServices, "Tuyển Dụng"));
<<<<<<< HEAD
            //Application.Run(new Menu(_nhanVienServices, _phongBanServices, _thanhPhoServices, _chucVuServices,
            //    _capBacServices, _bienCheServices));
            //Application.Run(new DanhSachNhanVien(_nhanVienServices, _phongBanServices, _thanhPhoServices, _chucVuServices,
            //    _capBacServices, _bienCheServices));
            Application.Run(new Thongtincanhan());
=======
            Application.Run(new Menu(_nhanVienServices, _phongBanServices, _thanhPhoServices, _chucVuServices,
                _capBacServices, _bienCheServices, _thongTinServices, _trinhDoServices));
            //Application.Run(new DanhSachNhanVien(_nhanVienServices, _phongBanServices, _thanhPhoServices, _chucVuServices,
            //    _capBacServices, _bienCheServices));
>>>>>>> e6d38c393c07c5c40f1be67b15026494bf4df535
        }
    }
}   
