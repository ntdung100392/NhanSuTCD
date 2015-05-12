using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface ILoaiToServices : IServices<C_LoaiTo>
    {
        List<C_LoaiTo> GetAllLoaiTo();
    }
}
