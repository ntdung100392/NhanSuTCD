using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class ChucVuMap : EntityTypeConfiguration<ChucVu>
    {
        public ChucVuMap()
        {
            // Primary Key
            this.HasKey(t => t.idChucVu);

            // Properties
            this.Property(t => t.MaChucVu)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ChucVu1)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("ChucVu");
            this.Property(t => t.idChucVu).HasColumnName("idChucVu");
            this.Property(t => t.MaChucVu).HasColumnName("MaChucVu");
            this.Property(t => t.ChucVu1).HasColumnName("ChucVu");
        }
    }
}
