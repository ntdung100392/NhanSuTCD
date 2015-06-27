namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;

    public interface IBienCheServices
    {
        bool AddBienChe(BienChe bienChe);
        BienChe GetBienCheById(int id);
        List<BienChe> GetAllBienChe();
        bool UpdateBienChe(BienChe bienChe);
        BienChe FindBienChe(string nameBienChe, string maBienChe);
    }
}
