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
    public class LoaiToServices : Services<LoaiTo>, ILoaiToServices
    {
        public LoaiToServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<LoaiTo> GetAllLoaiTo()
        {
            List<LoaiTo> listLoaiTo = unitOfWork.Repository<LoaiTo>().GetAll().ToList();
            return listLoaiTo;
        }
    }
}
