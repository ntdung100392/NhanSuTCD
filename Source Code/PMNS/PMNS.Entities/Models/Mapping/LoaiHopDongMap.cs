using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class LoaiHopDongMap : EntityTypeConfiguration<LoaiHopDong>
    {
        public LoaiHopDongMap()
        {
            // Primary Key
            this.HasKey(t => t.idLoaiHopDong);

            // Properties
            this.Property(t => t.loaiHopDong1)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("LoaiHopDong");
            this.Property(t => t.idLoaiHopDong).HasColumnName("idLoaiHopDong");
            this.Property(t => t.loaiHopDong1).HasColumnName("loaiHopDong");
            this.Property(t => t.idCha).HasColumnName("idCha");
        }
    }
}
