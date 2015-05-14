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
    public class DoiServices : Services<Doi>, IDoiServices
    {
        public DoiServices(IUnitOfWork unitOfWork) 
            : base(unitOfWork) { }

        public List<Doi> GetAllDoi()
        {
            List<Doi> listDoi = unitOfWork.Repository<Doi>().GetAll().ToList();
            return listDoi;
        }

        public List<Doi> GetDoiByPhongBanId(int id)
        {
            if (id != 0)
            {
                List<Doi> doi = unitOfWork.Repository<Doi>().Get(x=>x.idPhong==id).ToList();
                return doi;
            }
            return null;
        }
    }
}
