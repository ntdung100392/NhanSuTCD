using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class C_LoaiTo
    {
        public C_LoaiTo()
        {
            this.C_ThongTinNguoiLaoDong = new List<C_ThongTinNguoiLaoDong>();
        }

        public string C_MaLoaiTo { get; set; }
        public string C_MaTo { get; set; }
        public string C_TenLoaiTo { get; set; }
        public virtual C_To C_To { get; set; }
        public virtual ICollection<C_ThongTinNguoiLaoDong> C_ThongTinNguoiLaoDong { get; set; }
    }
}
