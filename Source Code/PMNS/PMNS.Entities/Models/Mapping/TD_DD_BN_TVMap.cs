using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class TD_DD_BN_TVMap : EntityTypeConfiguration<TD_DD_BN_TV>
    {
        public TD_DD_BN_TVMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaDDTDBNTV);

            // Properties
            this.Property(t => t.C_MaNV)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.C_HoTenDD)
                .HasMaxLength(50);

            this.Property(t => t.C_NoiDung)
                .HasMaxLength(20);

            this.Property(t => t.C_DienLaoDong)
                .HasMaxLength(100);

            this.Property(t => t.C_DienHuongLuong)
                .HasMaxLength(50);

            this.Property(t => t.C_SoQuyetDinh)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TD-DD-BN-TV");
            this.Property(t => t.C_MaDDTDBNTV).HasColumnName("_MaDDTDBNTV");
            this.Property(t => t.C_MaNV).HasColumnName("_MaNV");
            this.Property(t => t.C_HoTenDD).HasColumnName("_HoTenDD");
            this.Property(t => t.C_NoiDung).HasColumnName("_NoiDung");
            this.Property(t => t.C_NamThucHien).HasColumnName("_NamThucHien");
            this.Property(t => t.C_ViTriCu).HasColumnName("_ViTriCu");
            this.Property(t => t.C_ViTriMoi).HasColumnName("_ViTriMoi");
            this.Property(t => t.C_DienLaoDong).HasColumnName("_DienLaoDong");
            this.Property(t => t.C_DienHuongLuong).HasColumnName("_DienHuongLuong");
            this.Property(t => t.C_SoQuyetDinh).HasColumnName("_SoQuyetDinh");
            this.Property(t => t.C_NgayKyQD).HasColumnName("_NgayKyQD");
            this.Property(t => t.C_NgayHieuLuc).HasColumnName("_NgayHieuLuc");
            this.Property(t => t.C_GhiChu).HasColumnName("_GhiChu");

            // Relationships
            this.HasRequired(t => t.C_ThongTinNguoiLaoDong)
                .WithMany(t => t.TD_DD_BN_TV)
                .HasForeignKey(d => d.C_MaNV);

        }
    }
}
