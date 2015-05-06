using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_PhongMap : EntityTypeConfiguration<C_Phong>
    {
        public C_PhongMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaPhong);

            // Properties
            this.Property(t => t.C_MaPhong)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.C_TenPhong)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("_Phong");
            this.Property(t => t.C_MaPhong).HasColumnName("_MaPhong");
            this.Property(t => t.C_TenPhong).HasColumnName("_TenPhong");
        }
    }
}
