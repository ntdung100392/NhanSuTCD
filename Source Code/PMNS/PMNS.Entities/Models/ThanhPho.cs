using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class ThanhPho
    {
        public ThanhPho()
        {
            this.ThongTinNhanVIens = new List<ThongTinNhanVIen>();
        }

        public int idThanhPho { get; set; }
        public string maTP { get; set; }
        public string tenTP { get; set; }
        public virtual ICollection<ThongTinNhanVIen> ThongTinNhanVIens { get; set; }
    }
}
