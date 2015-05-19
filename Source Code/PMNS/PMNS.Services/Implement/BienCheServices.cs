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
    public class BienCheServices : Services<BienChe>, IBienCheServices
    {
        public BienCheServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<BienChe> GetAllBienChe()
        {
            return unitOfWork.Repository<BienChe>().GetAll().ToList();
        }

        public BienChe GetBienCheById(int id)
        {
            return unitOfWork.Repository<BienChe>().GetById(id);
        }

        public bool AddBienChe(BienChe bienChe)
        {
            if (bienChe != null)
            {
                try
                {
                    unitOfWork.Repository<BienChe>().Insert(bienChe);
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

        public bool UpdateBienChe(BienChe bienChe)
        {
            if (bienChe != null)
            {
                try
                {
                    unitOfWork.Repository<BienChe>().Update(bienChe);
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

        public BienChe FindBienChe(string nameBienChe, string maBienChe)
        {
            return unitOfWork.Repository<BienChe>().Get(
                x => x.bienChe1.Equals(nameBienChe) || x.maBienChe.Equals(maBienChe)).FirstOrDefault();
        }
    }
}
