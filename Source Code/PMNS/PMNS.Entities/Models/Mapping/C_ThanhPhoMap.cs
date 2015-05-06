using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_ThanhPhoMap : EntityTypeConfiguration<C_ThanhPho>
    {
        public C_ThanhPhoMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaTP);

            // Properties
            this.Property(t => t.C_MaTP)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.C_TenTP)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("_ThanhPho");
            this.Property(t => t.C_MaTP).HasColumnName("_MaTP");
            this.Property(t => t.C_TenTP).HasColumnName("_TenTP");
        }
    }
}
