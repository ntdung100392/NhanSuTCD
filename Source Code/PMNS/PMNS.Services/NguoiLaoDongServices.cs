using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities;

namespace PMNS.Services
{
    public class NguoiLaoDongServices
    {
        public void Insert()
        {
            using (var context = new NhanSuTCDEntities())
            {
                var nld = new C_ThongTinNguoiLaoDong();
                context.C_ThongTinNguoiLaoDong.Add(nld);
                context.SaveChanges();
            }            
        }
    }
}
