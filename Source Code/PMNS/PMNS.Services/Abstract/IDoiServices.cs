using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface IDoiServices : IServices<Doi>
    {
        List<Doi> GetAllDoi();
        List<Doi> GetDoiByPhongBanId(int id);
    }
}
