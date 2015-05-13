using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PMNS.Entities.Models;

namespace PMNS.Services.Abstract
{
    public interface ICapBacServices: IServices<CapBac>
    {
        bool AddCapBac(CapBac capBac);
        bool UpdateCapBac(CapBac capBacUpdate);
        string DeleteCapBac(CapBac capBacDelete);
    }
}
