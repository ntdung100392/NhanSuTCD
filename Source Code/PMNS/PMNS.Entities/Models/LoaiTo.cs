using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class LoaiTo
    {
        public LoaiTo()
        {
            this.Toes = new List<To>();
        }

        public int idLoaiTo { get; set; }
        public string maLoaiTo { get; set; }
        public string tenLoaiTo { get; set; }
        public virtual ICollection<To> Toes { get; set; }
    }
}
