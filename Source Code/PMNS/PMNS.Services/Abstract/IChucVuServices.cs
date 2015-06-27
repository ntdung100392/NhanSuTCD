namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;
    using PMNS.Infrastructures;

    public interface IChucVuServices
    {
        List<ChucVu> GetAllChucVu();
        ChucVu GetChucVuById(int id);
        bool AddChucVu(ChucVu chucVu);
        bool UpdateChucVu(ChucVu chucVu);
        ChucVu FindChucVu(string nameChucVu, string maChucVu);
    }
}
