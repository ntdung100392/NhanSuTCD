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
    public class CapBacServices : Services<CapBac>, ICapBacServices
    {
        public CapBacServices(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public List<CapBac> GetAllCapBac()
        {
            return unitOfWork.Repository<CapBac>().GetAll().ToList();
        }

        public bool AddCapBac(CapBac capBac)
        {
            if (capBac != null)
            {
                try
                {
                    unitOfWork.Repository<CapBac>().Insert(capBac);
                    unitOfWork.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return false;
        }

        public bool UpdateCapBac(CapBac capBacUpdate)
        {
            if (capBacUpdate != null)
            {
                try
                {
                    unitOfWork.Repository<CapBac>().Update(capBacUpdate);
                    unitOfWork.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            return false;
        }

        public CapBac FindCapBac(string nameCapBac, string maCapBac)
        {
            return unitOfWork.Repository<CapBac>().Get(
                x => x.capBac1.Equals(nameCapBac) || x.maCapBac.Equals(maCapBac)).FirstOrDefault();
        }

        public CapBac GetCapBacById(int id)
        {
            return unitOfWork.Repository<CapBac>().GetById(id);
        }
    }
}
