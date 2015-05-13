using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class CapBac
    {
        public CapBac()
        {
            this.ThongTinNhanVIens = new List<ThongTinNhanVIen>();
        }

        public int idCapBac { get; set; }
        public string maCapBac { get; set; }
        public string capBac1 { get; set; }
        public virtual ICollection<ThongTinNhanVIen> ThongTinNhanVIens { get; set; }
    }
}
