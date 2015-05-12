using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class TD_DD_BN_TVMap : EntityTypeConfiguration<TD_DD_BN_TV>
    {
        public TD_DD_BN_TVMap()
        {
            // Primary Key
            this.HasKey(t => t.idTDDDBNTV);

            // Properties
            this.Property(t => t.hoTenDD)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.noiDung)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.dienLaoDong)
                .HasMaxLength(100);

            this.Property(t => t.dienHuongLuong)
                .HasMaxLength(50);

            this.Property(t => t.soQuyetDinh)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TD-DD-BN-TV");
            this.Property(t => t.idTDDDBNTV).HasColumnName("idTDDDBNTV");
            this.Property(t => t.idNhanVien).HasColumnName("idNhanVien");
            this.Property(t => t.hoTenDD).HasColumnName("hoTenDD");
            this.Property(t => t.noiDung).HasColumnName("noiDung");
            this.Property(t => t.namThucHien).HasColumnName("namThucHien");
            this.Property(t => t.viTriCu).HasColumnName("viTriCu");
            this.Property(t => t.viTriMoi).HasColumnName("viTriMoi");
            this.Property(t => t.dienLaoDong).HasColumnName("dienLaoDong");
            this.Property(t => t.dienHuongLuong).HasColumnName("dienHuongLuong");
            this.Property(t => t.soQuyetDinh).HasColumnName("soQuyetDinh");
            this.Property(t => t.ngayKyQD).HasColumnName("ngayKyQD");
            this.Property(t => t.ngayHieuLuc).HasColumnName("ngayHieuLuc");
            this.Property(t => t.ghiChu).HasColumnName("ghiChu");

            // Relationships
            this.HasRequired(t => t.ThongTinNhanVIen)
                .WithMany(t => t.TD_DD_BN_TV)
                .HasForeignKey(d => d.idNhanVien);

        }
    }
}
