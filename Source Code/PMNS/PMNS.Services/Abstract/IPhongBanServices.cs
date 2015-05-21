using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Services.Abstract;
using PMNS.Entities.Models;
using PMNS.DAL.Abstract;

namespace PMNS.Services.Abstract
{
    public interface IPhongBanServices : IServices<PhongDoiToLoaiTo>
    {
        List<PhongDoiToLoaiTo> GetAllPhongBan();
        List<PhongDoiToLoaiTo> GetChildByParentId(int id);
    }
}
