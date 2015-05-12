using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class Doi
    {
        public Doi()
        {
            this.Toes = new List<To>();
        }

        public int idDoi { get; set; }
        public int idPhong { get; set; }
        public string maDoi { get; set; }
        public string tenDoi { get; set; }
        public virtual Phong Phong { get; set; }
        public virtual ICollection<To> Toes { get; set; }
    }
}
