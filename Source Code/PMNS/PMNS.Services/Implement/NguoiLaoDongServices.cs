using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;
using PMNS.Entities.Models;
using PMNS.Services.Implement;

namespace PMNS.Services.Implement
{
    public class NguoiLaoDongServices : INguoiLaoDongServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public NguoiLaoDongServices(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public C_ThongTinNguoiLaoDong GetEmployeeByNameAndPass(string name, string pass)
        {
            C_ThongTinNguoiLaoDong emp = _unitOfWork.Repository<C_ThongTinNguoiLaoDong>().
                Get().Where(x => x.C_user.Equals(name) && x.C_Password.Equals(pass)).FirstOrDefault();
            return emp;
        }
    }
}
