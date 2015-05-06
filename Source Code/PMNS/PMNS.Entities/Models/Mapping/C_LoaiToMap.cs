using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_LoaiToMap : EntityTypeConfiguration<C_LoaiTo>
    {
        public C_LoaiToMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaLoaiTo);

            // Properties
            this.Property(t => t.C_MaLoaiTo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.C_MaTo)
                .HasMaxLength(50);

            this.Property(t => t.C_TenLoaiTo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("_LoaiTo");
            this.Property(t => t.C_MaLoaiTo).HasColumnName("_MaLoaiTo");
            this.Property(t => t.C_MaTo).HasColumnName("_MaTo");
            this.Property(t => t.C_TenLoaiTo).HasColumnName("_TenLoaiTo");

            // Relationships
            this.HasOptional(t => t.C_To)
                .WithMany(t => t.C_LoaiTo)
                .HasForeignKey(d => d.C_MaTo);

        }
    }
}
