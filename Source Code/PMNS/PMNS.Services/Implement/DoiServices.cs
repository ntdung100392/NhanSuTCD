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
    public class DoiServices : Services<C_Doi>, IDoiServices
    {
        public DoiServices(IUnitOfWork unitOfWork) 
            : base(unitOfWork) { }

        public List<C_Doi> GetAllDoi()
        {
            List<C_Doi> listDoi = unitOfWork.Repository<C_Doi>().GetAll().ToList();
            return listDoi;
        }
    }
}
