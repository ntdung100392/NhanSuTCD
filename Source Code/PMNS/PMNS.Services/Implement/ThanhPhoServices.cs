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
    public class ThanhPhoServices : Services<C_ThanhPho>, IThanhPhoServices
    {
        public ThanhPhoServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<C_ThanhPho> GetAllThanhPho()
        {
            List<C_ThanhPho> listThanhPho = unitOfWork.Repository<C_ThanhPho>().GetAll().ToList();
            return listThanhPho;
        }
    }
}
