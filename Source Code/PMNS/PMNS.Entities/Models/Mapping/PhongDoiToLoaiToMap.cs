using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class PhongDoiToLoaiToMap : EntityTypeConfiguration<PhongDoiToLoaiTo>
    {
        public PhongDoiToLoaiToMap()
        {
            // Primary Key
            this.HasKey(t => t.idPhongDoiToLoai);

            // Properties
            this.Property(t => t.maPhongDoiToLoai)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.tenPhongDoiToLoai)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PhongDoiToLoaiTo");
            this.Property(t => t.idPhongDoiToLoai).HasColumnName("idPhongDoiToLoai");
            this.Property(t => t.maPhongDoiToLoai).HasColumnName("maPhongDoiToLoai");
            this.Property(t => t.tenPhongDoiToLoai).HasColumnName("tenPhongDoiToLoai");
            this.Property(t => t.idCha).HasColumnName("idCha");

            // Relationships
            this.HasRequired(t => t.PhongDoiToLoaiTo2)
                .WithMany(t => t.PhongDoiToLoaiTo1)
                .HasForeignKey(d => d.idCha);

        }
    }
}
