using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class ChucVu
    {
        public ChucVu()
        {
            this.ThongTinNhanVIens = new List<ThongTinNhanVIen>();
        }

        public int idChucVu { get; set; }
        public string MaChucVu { get; set; }
        public string ChucVu1 { get; set; }
        public virtual ICollection<ThongTinNhanVIen> ThongTinNhanVIens { get; set; }
    }
}
