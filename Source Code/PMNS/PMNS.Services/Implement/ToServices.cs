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
    public class ToServices : Services<To>, IToServices
    {
        public ToServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<To> GetAllTo()
        {
            List<To> listTo = unitOfWork.Repository<To>().GetAll().ToList();
            return listTo;
        }
    }
}
