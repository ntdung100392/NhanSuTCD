using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMNS.Business
{
    public class NguoiLaoDongBusiness
    {
        NhanSuTCDEntities context = new NhanSuTCDEntities();

        public bool Delete()
        {
            return true;
        }

        public C_ThongTinNguoiLaoDong Get()
        {
            C_ThongTinNguoiLaoDong nld = new C_ThongTinNguoiLaoDong();
            context.C_ThongTinNguoiLaoDong.Add(nld);
            context.SaveChanges();
            return nld;
        }

        public bool Insert()
        {
            C_ThongTinNguoiLaoDong nld = new C_ThongTinNguoiLaoDong();
            try
            {                
                context.C_ThongTinNguoiLaoDong.Add(nld);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Update()
        {
            C_ThongTinNguoiLaoDong nld = new C_ThongTinNguoiLaoDong();
        }
    }
}
