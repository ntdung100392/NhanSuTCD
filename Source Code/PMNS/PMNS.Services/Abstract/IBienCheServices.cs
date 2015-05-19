using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface IBienCheServices : IServices<BienChe>
    {
        bool AddBienChe(BienChe bienChe);
        BienChe GetBienCheById(int id);
        List<BienChe> GetAllBienChe();
        bool UpdateBienChe(BienChe bienChe);
        BienChe FindBienChe(string nameBienChe, string maBienChe);
    }
}
