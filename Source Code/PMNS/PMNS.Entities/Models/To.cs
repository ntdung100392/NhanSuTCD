using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class To
    {
        public To()
        {
            this.ThongTinNhanVIens = new List<ThongTinNhanVIen>();
        }

        public int idTo { get; set; }
        public int idDoi { get; set; }
        public int idLoaiTo { get; set; }
        public string maTo { get; set; }
        public string tenTo { get; set; }
        public virtual Doi Doi { get; set; }
        public virtual LoaiTo LoaiTo { get; set; }
        public virtual ICollection<ThongTinNhanVIen> ThongTinNhanVIens { get; set; }
    }
}
