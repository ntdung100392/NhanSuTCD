using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class ThongTinGiaDinhMap : EntityTypeConfiguration<ThongTinGiaDinh>
    {
        public ThongTinGiaDinhMap()
        {
            // Primary Key
            this.HasKey(t => t.idThongTinGiaDinh);

            // Properties
            this.Property(t => t.hoTenCha)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ngheNghiepCha)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.hoTenMe)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ngheNghiepMe)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.hoTenVoChong)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ngheNghiepVoChong)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.namSinhVoChong)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.hoTenCon)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ngheNghiepCon)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ThongTinGiaDinh");
            this.Property(t => t.idThongTinGiaDinh).HasColumnName("idThongTinGiaDinh");
            this.Property(t => t.idNhanVien).HasColumnName("idNhanVien");
            this.Property(t => t.hoTenCha).HasColumnName("hoTenCha");
            this.Property(t => t.namSinhCha).HasColumnName("namSinhCha");
            this.Property(t => t.ngheNghiepCha).HasColumnName("ngheNghiepCha");
            this.Property(t => t.hoTenMe).HasColumnName("hoTenMe");
            this.Property(t => t.namSinhMe).HasColumnName("namSinhMe");
            this.Property(t => t.ngheNghiepMe).HasColumnName("ngheNghiepMe");
            this.Property(t => t.hoTenVoChong).HasColumnName("hoTenVoChong");
            this.Property(t => t.ngheNghiepVoChong).HasColumnName("ngheNghiepVoChong");
            this.Property(t => t.namSinhVoChong).HasColumnName("namSinhVoChong");
            this.Property(t => t.hoTenCon).HasColumnName("hoTenCon");
            this.Property(t => t.namSinhCon).HasColumnName("namSinhCon");
            this.Property(t => t.ngheNghiepCon).HasColumnName("ngheNghiepCon");

            // Relationships
            this.HasRequired(t => t.ThongTinNhanVIen)
                .WithMany(t => t.ThongTinGiaDinhs)
                .HasForeignKey(d => d.idNhanVien);

        }
    }
}
