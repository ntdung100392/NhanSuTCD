using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class ToMap : EntityTypeConfiguration<To>
    {
        public ToMap()
        {
            // Primary Key
            this.HasKey(t => t.idTo);

            // Properties
            this.Property(t => t.maTo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tenTo)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("To");
            this.Property(t => t.idTo).HasColumnName("idTo");
            this.Property(t => t.idDoi).HasColumnName("idDoi");
            this.Property(t => t.maTo).HasColumnName("maTo");
            this.Property(t => t.tenTo).HasColumnName("tenTo");

            // Relationships
            this.HasRequired(t => t.Doi)
                .WithMany(t => t.Toes)
                .HasForeignKey(d => d.idDoi);

        }
    }
}
