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
            IBienCheServices _bienCheServices = new BienCheServices(unitOfWork);
            ICapBacServices _capBacServices = new CapBacServices(unitOfWork);
            IChucVuServices _chucVuServices = new ChucVuServices(unitOfWork);
            IHopDongServices _hopDongServices = new HopDongServices(unitOfWork);
            IKhenThuongServices _khenThuongServices = new KhenThuongServices(unitOfWork);
            IKyLuatServices _kyLuatServices = new KyLuatServices(unitOfWork);
            ILoaiHopDongServices _loaiHopDongServices = new LoaiHopDongServices(unitOfWork);
            INhanVienServices _nhanVienServices = new NhanVienServices(unitOfWork);
            IPhongBanServices _phongBanServices = new PhongBanServices(unitOfWork);
            IThanhPhoServices _thanhPhoServices = new ThanhPhoServices(unitOfWork);
            IThongTinGiaDinhServices _thongTinGiaDinhServices = new ThongTinGiaDinhServices(unitOfWork);
            IThongTinServices _thongTinServices = new ThongTinServices(unitOfWork);
            IThongTinTrinhDoServices _trinhDoServices = new ThongTinTrinhDoServices(unitOfWork);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new REPORT(_bienCheServices, _capBacServices, _chucVuServices, _nhanVienServices, _phongBanServices, _thanhPhoServices));
            //Application.Run(new Dang_nhap(_bienCheServices, _capBacServices, _chucVuServices, _hopDongServices, _khenThuongServices, _kyLuatServices,
            //            _loaiHopDongServices, _nhanVienServices, _phongBanServices, _thanhPhoServices, _thongTinGiaDinhServices, _thongTinServices, _trinhDoServices));
            Application.Run(new Menu(_bienCheServices, _capBacServices, _chucVuServices, _hopDongServices, _khenThuongServices, _kyLuatServices,
                        _loaiHopDongServices, _nhanVienServices, _phongBanServices, _thanhPhoServices, _thongTinGiaDinhServices, _thongTinServices, _trinhDoServices));
        }
    }
}
