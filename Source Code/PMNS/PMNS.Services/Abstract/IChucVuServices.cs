using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface IChucVuServices : IServices<ChucVu>
    {
        List<ChucVu> GetAllChucVu();
        ChucVu GetChucVuById(int id);
        bool AddChucVu(ChucVu chucVu);
        bool UpdateChucVu(ChucVu chucVu);
        ChucVu FindChucVu(string nameChucVu, string maChucVu);
    }
}
