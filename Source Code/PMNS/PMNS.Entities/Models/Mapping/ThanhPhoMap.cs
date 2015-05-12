using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class ThanhPhoMap : EntityTypeConfiguration<ThanhPho>
    {
        public ThanhPhoMap()
        {
            // Primary Key
            this.HasKey(t => t.idThanhPho);

            // Properties
            this.Property(t => t.maTP)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.tenTP)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("ThanhPho");
            this.Property(t => t.idThanhPho).HasColumnName("idThanhPho");
            this.Property(t => t.maTP).HasColumnName("maTP");
            this.Property(t => t.tenTP).HasColumnName("tenTP");
        }
    }
}
