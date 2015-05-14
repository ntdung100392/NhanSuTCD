using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class To
    {
        public To()
        {
            this.LoaiToes = new List<LoaiTo>();
            this.ThongTinNhanVIens = new List<ThongTinNhanVIen>();
        }

        public int idTo { get; set; }
        public int idDoi { get; set; }
        public string maTo { get; set; }
        public string tenTo { get; set; }
        public virtual Doi Doi { get; set; }
        public virtual ICollection<LoaiTo> LoaiToes { get; set; }
        public virtual ICollection<ThongTinNhanVIen> ThongTinNhanVIens { get; set; }
    }
}
