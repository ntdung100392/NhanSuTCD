using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;
using PMNS.Entities.Models;

namespace PMNS.Services.Implement
{
    public class NguoiLaoDongServices : Service<C_ThongTinNguoiLaoDong>, INguoiLaoDongServices
    {

        public NguoiLaoDongServices(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        { }

        public C_ThongTinNguoiLaoDong GetEmployeeByNameAndPass(string name, string pass)
        {
            C_ThongTinNguoiLaoDong emp = unitOfWork.Repository<C_ThongTinNguoiLaoDong>().
                Get().Where(x => x.C_user.Equals(name) && x.C_Password.Equals(pass)).FirstOrDefault();
            if (emp == null)
            {
                emp = new C_ThongTinNguoiLaoDong();
                return emp;
            }
            return emp;
        }
    }
}
