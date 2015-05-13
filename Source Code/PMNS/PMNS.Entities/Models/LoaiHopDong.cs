using System;
using System.Collections.Generic;

namespace PMNS.Entities.Models
{
    public partial class LoaiHopDong
    {
        public LoaiHopDong()
        {
            this.HopDongLaoDongs = new List<HopDongLaoDong>();
        }

        public int idLoaiHopDong { get; set; }
        public string loaiHopDong1 { get; set; }
        public int idCha { get; set; }
        public virtual ICollection<HopDongLaoDong> HopDongLaoDongs { get; set; }
    }
}
