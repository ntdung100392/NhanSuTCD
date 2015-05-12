using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class PhongMap : EntityTypeConfiguration<Phong>
    {
        public PhongMap()
        {
            // Primary Key
            this.HasKey(t => t.idPhong);

            // Properties
            this.Property(t => t.maPhong)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tenPhong)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Phong");
            this.Property(t => t.idPhong).HasColumnName("idPhong");
            this.Property(t => t.maPhong).HasColumnName("maPhong");
            this.Property(t => t.tenPhong).HasColumnName("tenPhong");
        }
    }
}
