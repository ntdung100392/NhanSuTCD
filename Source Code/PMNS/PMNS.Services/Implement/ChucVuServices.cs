using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.Entities.Models;
using PMNS.DAL.Abstract;

namespace PMNS.Services.Implement
{
    public class ChucVuServices : Services<ChucVu>, IChucVuServices
    {
        public ChucVuServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<ChucVu> GetAllChucVu()
        {
            List<ChucVu> listChucVu = unitOfWork.Repository<ChucVu>().GetAll().ToList();
            return listChucVu;
        }
    }
}
