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
            return unitOfWork.Repository<ChucVu>().GetAll().ToList();
        }

        public ChucVu GetChucVuById(int id)
        {
            return unitOfWork.Repository<ChucVu>().GetById(id);
        }

        public bool AddChucVu(ChucVu chucVu)
        {
            if (chucVu != null)
            {
                try
                {
                    unitOfWork.Repository<ChucVu>().Insert(chucVu);
                    unitOfWork.Commit();
                    return true;
                }
                catch (InvalidOperationException e)
                {
                    throw e;
                }
            }
            return false;
        }

        public bool UpdateChucVu(ChucVu chucVu)
        {
            if (chucVu != null)
            {
                try
                {
                    unitOfWork.Repository<ChucVu>().Update(chucVu);
                    unitOfWork.Commit();
                    return true;
                }
                catch (InvalidOperationException e)
                {
                    throw e;
                }
            }
            return false;
        }

        public ChucVu FindChucVu(string nameChucVu, string maChucVu)
        {
            return unitOfWork.Repository<ChucVu>().Get(
                x => x.ChucVu1.Equals(nameChucVu) || x.MaChucVu.Equals(maChucVu)).FirstOrDefault();
        }
    }
}
