using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class BienChe
    {
        public BienChe()
        {
            this.ThongTinNhanVIens = new List<ThongTinNhanVIen>();
        }

        public int idBienChe { get; set; }
        public string maBienChe { get; set; }
        public string bienChe1 { get; set; }
        public virtual ICollection<ThongTinNhanVIen> ThongTinNhanVIens { get; set; }
    }
}
