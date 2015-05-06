using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_DoiMap : EntityTypeConfiguration<C_Doi>
    {
        public C_DoiMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaDoi);

            // Properties
            this.Property(t => t.C_MaDoi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.C_MaPhong)
                .HasMaxLength(50);

            this.Property(t => t.C_TenDoi)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("_Doi");
            this.Property(t => t.C_MaDoi).HasColumnName("_MaDoi");
            this.Property(t => t.C_MaPhong).HasColumnName("_MaPhong");
            this.Property(t => t.C_TenDoi).HasColumnName("_TenDoi");

            // Relationships
            this.HasOptional(t => t.C_Phong)
                .WithMany(t => t.C_Doi)
                .HasForeignKey(d => d.C_MaPhong);

        }
    }
}
