namespace PMNS
{
    #region References

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

    #endregion

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Implement Services

            IUnitOfWork unitOfWork = new UnitOfWork();
            IBienCheServices bienCheServices = new BienCheServices(unitOfWork);
            ICapBacServices capBacServices = new CapBacServices(unitOfWork);
            IChucVuServices chucVuServices = new ChucVuServices(unitOfWork);
            IHopDongServices hopDongServices = new HopDongServices(unitOfWork);
            IKhenThuongServices khenThuongServices = new KhenThuongServices(unitOfWork);
            IKyLuatServices kyLuatServices = new KyLuatServices(unitOfWork);
            ILoaiHopDongServices loaiHopDongServices = new LoaiHopDongServices(unitOfWork);
            INhanVienServices nhanVienServices = new NhanVienServices(unitOfWork);
            IPhongBanServices phongBanServices = new PhongBanServices(unitOfWork);
            IThanhPhoServices thanhPhoServices = new ThanhPhoServices(unitOfWork);
            IThongTinGiaDinhServices thongTinGiaDinhServices = new ThongTinGiaDinhServices(unitOfWork);
            IThongTinServices thongTinServices = new ThongTinServices(unitOfWork);
            IThongTinTrinhDoServices trinhDoServices = new ThongTinTrinhDoServices(unitOfWork);

            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Dang_nhap(bienCheServices, capBacServices, chucVuServices, hopDongServices, khenThuongServices,
            //    kyLuatServices, loaiHopDongServices, nhanVienServices, phongBanServices, thanhPhoServices, thongTinGiaDinhServices,
            //    thongTinServices, trinhDoServices));
            Application.Run(new REPORT(bienCheServices, capBacServices, chucVuServices, nhanVienServices, phongBanServices, thanhPhoServices, loaiHopDongServices));
        }
    }
}
