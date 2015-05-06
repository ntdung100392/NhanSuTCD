using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_ThongTinHopDongLaoDongMap : EntityTypeConfiguration<C_ThongTinHopDongLaoDong>
    {
        public C_ThongTinHopDongLaoDongMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaNV);

            // Properties
            this.Property(t => t.C_MaNV)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.C_SoHopDong_TTHDLD)
                .HasMaxLength(20);

            this.Property(t => t.C_NguoiBaoLanh_TTHDLD)
                .HasMaxLength(50);

            this.Property(t => t.C_ChucDanh)
                .HasMaxLength(30);

            this.Property(t => t.C_HopDong)
                .HasMaxLength(20);

            this.Property(t => t.C_LoaiHopDong)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("_ThongTinHopDongLaoDong");
            this.Property(t => t.C_MaNV).HasColumnName("_MaNV");
            this.Property(t => t.C_SoHopDong_TTHDLD).HasColumnName("_SoHopDong_TTHDLD");
            this.Property(t => t.C_NguoiBaoLanh_TTHDLD).HasColumnName("_NguoiBaoLanh_TTHDLD");
            this.Property(t => t.C_ChucDanh).HasColumnName("_ChucDanh");
            this.Property(t => t.C_HopDong).HasColumnName("_HopDong");
            this.Property(t => t.C_LoaiHopDong).HasColumnName("_LoaiHopDong");
            this.Property(t => t.C_NgayBatDau).HasColumnName("_NgayBatDau");
            this.Property(t => t.C_NgayKetThuc).HasColumnName("_NgayKetThuc");
            this.Property(t => t.C_GhiChu).HasColumnName("_GhiChu");

            // Relationships
            this.HasRequired(t => t.C_ThongTinNguoiLaoDong)
                .WithOptional(t => t.C_ThongTinHopDongLaoDong);

        }
    }
}
