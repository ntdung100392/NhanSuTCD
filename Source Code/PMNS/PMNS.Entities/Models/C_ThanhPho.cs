using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_ThanhPho
    {
        public C_ThanhPho()
        {
            this.C_ThongTinNguoiLaoDong = new List<C_ThongTinNguoiLaoDong>();
        }

        public string C_MaTP { get; set; }
        public string C_TenTP { get; set; }
        public virtual ICollection<C_ThongTinNguoiLaoDong> C_ThongTinNguoiLaoDong { get; set; }
    }
}
