using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class KhenThuongMap : EntityTypeConfiguration<KhenThuong>
    {
        public KhenThuongMap()
        {
            // Primary Key
            this.HasKey(t => t.idKhenThuong);

            // Properties
            this.Property(t => t.loaiKhenThuong)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.capKhenThuong)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.soSoKhenThuong)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.nguoiKhenThuong)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.thanhTichKhenThuong)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("KhenThuong");
            this.Property(t => t.idKhenThuong).HasColumnName("idKhenThuong");
            this.Property(t => t.idNhanVien).HasColumnName("idNhanVien");
            this.Property(t => t.namKhenThuong).HasColumnName("namKhenThuong");
            this.Property(t => t.loaiKhenThuong).HasColumnName("loaiKhenThuong");
            this.Property(t => t.capKhenThuong).HasColumnName("capKhenThuong");
            this.Property(t => t.soSoKhenThuong).HasColumnName("soSoKhenThuong");
            this.Property(t => t.nguoiKhenThuong).HasColumnName("nguoiKhenThuong");
            this.Property(t => t.thanhTichKhenThuong).HasColumnName("thanhTichKhenThuong");
            this.Property(t => t.ghiChu).HasColumnName("ghiChu");

            // Relationships
            this.HasRequired(t => t.ThongTinNhanVIen)
                .WithMany(t => t.KhenThuongs)
                .HasForeignKey(d => d.idNhanVien);

        }
    }
}
