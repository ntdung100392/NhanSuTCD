using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class BienCheMap : EntityTypeConfiguration<BienChe>
    {
        public BienCheMap()
        {
            // Primary Key
            this.HasKey(t => t.idBienChe);

            // Properties
            this.Property(t => t.maBienChe)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.bienChe1)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BienChe");
            this.Property(t => t.idBienChe).HasColumnName("idBienChe");
            this.Property(t => t.maBienChe).HasColumnName("maBienChe");
            this.Property(t => t.bienChe1).HasColumnName("bienChe");
        }
    }
}
