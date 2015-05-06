using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_ToMap : EntityTypeConfiguration<C_To>
    {
        public C_ToMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaTo);

            // Properties
            this.Property(t => t.C_MaTo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.C_MaDoi)
                .HasMaxLength(50);

            this.Property(t => t.C_TenTo)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("_To");
            this.Property(t => t.C_MaTo).HasColumnName("_MaTo");
            this.Property(t => t.C_MaDoi).HasColumnName("_MaDoi");
            this.Property(t => t.C_TenTo).HasColumnName("_TenTo");

            // Relationships
            this.HasOptional(t => t.C_Doi)
                .WithMany(t => t.C_To)
                .HasForeignKey(d => d.C_MaDoi);

        }
    }
}
