using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class Phong
    {
        public Phong()
        {
            this.Dois = new List<Doi>();
            this.ThongTinNhanVIens = new List<ThongTinNhanVIen>();
        }

        public int idPhong { get; set; }
        public string maPhong { get; set; }
        public string tenPhong { get; set; }
        public virtual ICollection<Doi> Dois { get; set; }
        public virtual ICollection<ThongTinNhanVIen> ThongTinNhanVIens { get; set; }
    }
}
