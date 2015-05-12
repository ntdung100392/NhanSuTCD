using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class HopDongLaoDongMap : EntityTypeConfiguration<HopDongLaoDong>
    {
        public HopDongLaoDongMap()
        {
            // Primary Key
            this.HasKey(t => t.idHopDongLaoDong);

            // Properties
            this.Property(t => t.soHopDong_TTHDLD)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.nguoiBaoLanh_TTHDLD)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.chucDanh)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.idLoaiHopDong)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HopDongLaoDong");
            this.Property(t => t.idHopDongLaoDong).HasColumnName("idHopDongLaoDong");
            this.Property(t => t.idNhanVien).HasColumnName("idNhanVien");
            this.Property(t => t.soHopDong_TTHDLD).HasColumnName("soHopDong_TTHDLD");
            this.Property(t => t.nguoiBaoLanh_TTHDLD).HasColumnName("nguoiBaoLanh_TTHDLD");
            this.Property(t => t.chucDanh).HasColumnName("chucDanh");
            this.Property(t => t.idLoaiHopDong).HasColumnName("idLoaiHopDong");
            this.Property(t => t.ngayBatDau).HasColumnName("ngayBatDau");
            this.Property(t => t.ngayKetThuc).HasColumnName("ngayKetThuc");
            this.Property(t => t.ghiChu).HasColumnName("ghiChu");

            // Relationships
            this.HasRequired(t => t.ThongTinNhanVIen)
                .WithMany(t => t.HopDongLaoDongs)
                .HasForeignKey(d => d.idNhanVien);

        }
    }
}
