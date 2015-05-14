using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class LoaiToMap : EntityTypeConfiguration<LoaiTo>
    {
        public LoaiToMap()
        {
            // Primary Key
            this.HasKey(t => t.idLoaiTo);

            // Properties
            this.Property(t => t.maLoaiTo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tenLoaiTo)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("LoaiTo");
            this.Property(t => t.idLoaiTo).HasColumnName("idLoaiTo");
            this.Property(t => t.idTo).HasColumnName("idTo");
            this.Property(t => t.maLoaiTo).HasColumnName("maLoaiTo");
            this.Property(t => t.tenLoaiTo).HasColumnName("tenLoaiTo");

            // Relationships
            this.HasRequired(t => t.To)
                .WithMany(t => t.LoaiToes)
                .HasForeignKey(d => d.idTo);

        }
    }
}
