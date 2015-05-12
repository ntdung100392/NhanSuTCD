using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.Entities.Models;
using PMNS.DAL.Abstract;
using System.Data;

namespace PMNS.Services.Implement
{
    public class PhongBanServices : Services<C_Phong>, IPhongBanServices
    {
        public PhongBanServices(IUnitOfWork unitOfWork)
            : base(unitOfWork) { }

        public List<C_Phong> GetAllPhongBan()
        {
            List<C_Phong> listPhongBan = unitOfWork.Repository<C_Phong>().GetAll().ToList();
            return listPhongBan;
        }
    }
}
