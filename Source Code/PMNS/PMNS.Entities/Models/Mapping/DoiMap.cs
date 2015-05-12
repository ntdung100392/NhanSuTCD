using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class DoiMap : EntityTypeConfiguration<Doi>
    {
        public DoiMap()
        {
            // Primary Key
            this.HasKey(t => t.idDoi);

            // Properties
            this.Property(t => t.maDoi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tenDoi)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Doi");
            this.Property(t => t.idDoi).HasColumnName("idDoi");
            this.Property(t => t.idPhong).HasColumnName("idPhong");
            this.Property(t => t.maDoi).HasColumnName("maDoi");
            this.Property(t => t.tenDoi).HasColumnName("tenDoi");

            // Relationships
            this.HasRequired(t => t.Phong)
                .WithMany(t => t.Dois)
                .HasForeignKey(d => d.idPhong);

        }
    }
}
