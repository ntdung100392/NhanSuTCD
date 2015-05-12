using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class KyLuatMap : EntityTypeConfiguration<KyLuat>
    {
        public KyLuatMap()
        {
            // Primary Key
            this.HasKey(t => t.idKyLuat);

            // Properties
            this.Property(t => t.loaiKyLuat)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.capKyLuat)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.soQuyetDinhKyLuat)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.nguoiKyQuyetDinh)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.hanhViBiKyLuat)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("KyLuat");
            this.Property(t => t.idKyLuat).HasColumnName("idKyLuat");
            this.Property(t => t.idNhanVien).HasColumnName("idNhanVien");
            this.Property(t => t.ngayKyLuat).HasColumnName("ngayKyLuat");
            this.Property(t => t.loaiKyLuat).HasColumnName("loaiKyLuat");
            this.Property(t => t.capKyLuat).HasColumnName("capKyLuat");
            this.Property(t => t.soQuyetDinhKyLuat).HasColumnName("soQuyetDinhKyLuat");
            this.Property(t => t.nguoiKyQuyetDinh).HasColumnName("nguoiKyQuyetDinh");
            this.Property(t => t.hanhViBiKyLuat).HasColumnName("hanhViBiKyLuat");
            this.Property(t => t.ghiChu).HasColumnName("ghiChu");

            // Relationships
            this.HasRequired(t => t.ThongTinNhanVIen)
                .WithMany(t => t.KyLuats)
                .HasForeignKey(d => d.idNhanVien);

        }
    }
}
