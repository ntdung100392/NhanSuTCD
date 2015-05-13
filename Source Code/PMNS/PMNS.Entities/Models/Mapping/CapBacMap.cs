using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class CapBacMap : EntityTypeConfiguration<CapBac>
    {
        public CapBacMap()
        {
            // Primary Key
            this.HasKey(t => t.idCapBac);

            // Properties
            this.Property(t => t.maCapBac)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.capBac1)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CapBac");
            this.Property(t => t.idCapBac).HasColumnName("idCapBac");
            this.Property(t => t.maCapBac).HasColumnName("maCapBac");
            this.Property(t => t.capBac1).HasColumnName("capBac");
        }
    }
}
