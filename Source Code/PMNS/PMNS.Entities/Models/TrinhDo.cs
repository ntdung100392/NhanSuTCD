using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class TrinhDo
    {
        public TrinhDo()
        {
            this.ThongTinTrinhDoes = new List<ThongTinTrinhDo>();
        }

        public int idTrinhDo { get; set; }
        public string TrinhDo1 { get; set; }
        public virtual ICollection<ThongTinTrinhDo> ThongTinTrinhDoes { get; set; }
    }
}
