using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;
using PMNS.Services.Abstract;
using PMNS.DAL.Abstract;

namespace PMNS.Services.Implement
{
    public class ToServices : Services<C_To>, IToServices
    {
        public ToServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<C_To> GetAllTo()
        {
            List<C_To> listTo = unitOfWork.Repository<C_To>().GetAll().ToList();
            return listTo;
        }
    }
}
