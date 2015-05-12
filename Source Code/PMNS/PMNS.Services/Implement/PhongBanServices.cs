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
    public class PhongBanServices : Services<Phong>, IPhongBanServices
    {
        public PhongBanServices(IUnitOfWork unitOfWork)
            : base(unitOfWork) { }

        public List<Phong> GetAllPhongBan()
        {
            List<Phong> listPhongBan = unitOfWork.Repository<Phong>().GetAll().ToList();
            return listPhongBan;
        }
    }
}
