using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PMNS.Services.Abstract;
using PMNS.Services.Implement;
using PMNS.DAL.Abstract;
using PMNS.DAL.Implement;

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
            INguoiLaoDongServices _nguoiLaoDongService = new NguoiLaoDongServices(unitOfWork);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dang_nhap(_nguoiLaoDongService));
        }
    }
}
