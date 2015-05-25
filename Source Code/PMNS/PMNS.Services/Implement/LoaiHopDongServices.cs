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
    public class LoaiHopDongServices : Services<LoaiHopDong>, ILoaiHopDongServices
    {
        public LoaiHopDongServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}
