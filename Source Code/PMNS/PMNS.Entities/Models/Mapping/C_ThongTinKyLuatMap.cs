using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_ThongTinKyLuatMap : EntityTypeConfiguration<C_ThongTinKyLuat>
    {
        public C_ThongTinKyLuatMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaNV);

            // Properties
            this.Property(t => t.C_MaNV)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.C_LoaiKyLuat)
                .HasMaxLength(150);

            this.Property(t => t.C_CapKyLuat)
                .HasMaxLength(100);

            this.Property(t => t.C_SoQuyetDinhKyLuat)
                .HasMaxLength(50);

            this.Property(t => t.C_NguoiKyQuyetDinh)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("_ThongTinKyLuat");
            this.Property(t => t.C_MaNV).HasColumnName("_MaNV");
            this.Property(t => t.C_ThangNamKyLuat).HasColumnName("_ThangNamKyLuat");
            this.Property(t => t.C_LoaiKyLuat).HasColumnName("_LoaiKyLuat");
            this.Property(t => t.C_CapKyLuat).HasColumnName("_CapKyLuat");
            this.Property(t => t.C_SoQuyetDinhKyLuat).HasColumnName("_SoQuyetDinhKyLuat");
            this.Property(t => t.C_NguoiKyQuyetDinh).HasColumnName("_NguoiKyQuyetDinh");
            this.Property(t => t.C_HanhViBiKyLuat).HasColumnName("_HanhViBiKyLuat");
            this.Property(t => t.C_GhiChu).HasColumnName("_GhiChu");

            // Relationships
            this.HasRequired(t => t.C_ThongTinNguoiLaoDong)
                .WithOptional(t => t.C_ThongTinKyLuat);

        }
    }
}
