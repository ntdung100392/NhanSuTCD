namespace PMNS.Services.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using PMNS.Entities.Models;
    using PMNS.Infrastructures;

    public interface ICapBacServices
    {
        List<CapBac> GetAllCapBac();
        bool AddCapBac(CapBac capBac);
        bool UpdateCapBac(CapBac capBacUpdate);
        CapBac FindCapBac(string nameCapBac, string maCapBac);
        CapBac GetCapBacById(int id);
    }
}
