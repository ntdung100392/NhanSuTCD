using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_ThongTinGiaDinhMap : EntityTypeConfiguration<C_ThongTinGiaDinh>
    {
        public C_ThongTinGiaDinhMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaNV);

            // Properties
            this.Property(t => t.C_HoTenCha)
                .HasMaxLength(100);

            this.Property(t => t.C_NgheNghiepCha)
                .HasMaxLength(100);

            this.Property(t => t.C_HoTenMe)
                .HasMaxLength(100);

            this.Property(t => t.C_NgheNghiepMe)
                .HasMaxLength(100);

            this.Property(t => t.C_HoTenVoChong)
                .HasMaxLength(100);

            this.Property(t => t.C_NgheNghiepVoChong)
                .HasMaxLength(100);

            this.Property(t => t.C_HoTenCon)
                .HasMaxLength(100);

            this.Property(t => t.C_NgheNghiepCon)
                .HasMaxLength(100);

            this.Property(t => t.C_MaNV)
                .IsRequired()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("_ThongTinGiaDinh");
            this.Property(t => t.C_HoTenCha).HasColumnName("_HoTenCha");
            this.Property(t => t.C_NgheNghiepCha).HasColumnName("_NgheNghiepCha");
            this.Property(t => t.C_NamSinhCha).HasColumnName("_NamSinhCha");
            this.Property(t => t.C_HoTenMe).HasColumnName("_HoTenMe");
            this.Property(t => t.C_NgheNghiepMe).HasColumnName("_NgheNghiepMe");
            this.Property(t => t.C_NamSinhMe).HasColumnName("_NamSinhMe");
            this.Property(t => t.C_HoTenVoChong).HasColumnName("_HoTenVoChong");
            this.Property(t => t.C_NgheNghiepVoChong).HasColumnName("_NgheNghiepVoChong");
            this.Property(t => t.C_NamSinhVoChong).HasColumnName("_NamSinhVoChong");
            this.Property(t => t.C_HoTenCon).HasColumnName("_HoTenCon");
            this.Property(t => t.C_NamSinhCon).HasColumnName("_NamSinhCon");
            this.Property(t => t.C_NgheNghiepCon).HasColumnName("_NgheNghiepCon");
            this.Property(t => t.C_MaNV).HasColumnName("_MaNV");

            // Relationships
            this.HasRequired(t => t.C_ThongTinNguoiLaoDong)
                .WithOptional(t => t.C_ThongTinGiaDinh);

        }
    }
}
