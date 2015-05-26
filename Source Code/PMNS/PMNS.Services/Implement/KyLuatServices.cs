using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;
using PMNS.DAL.Abstract;
using PMNS.Services.Abstract;

namespace PMNS.Services.Implement
{
    public class KyLuatServices : Services<KyLuat>, IKyLuatServices
    {
        public KyLuatServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }
    }
}
