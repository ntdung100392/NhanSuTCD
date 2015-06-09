﻿using System;
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
            IHopDongServices _hopDongServices = new HopDongServices(unitOfWork);
            ILoaiHopDongServices _loaiHopDongServices = new LoaiHopDongServices(unitOfWork);
            IKyLuatServices _kyLuatServices = new KyLuatServices(unitOfWork);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new REPORT(_bienCheServices, _capBacServices, _chucVuServices, _nhanVienServices, _phongBanServices, _thanhPhoServices));
            Application.Run(new ThongTinKyLuat(_nhanVienServices, _kyLuatServices));
        }
    }
}
