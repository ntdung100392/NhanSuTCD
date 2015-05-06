using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_ThongTinKhenThuongMap : EntityTypeConfiguration<C_ThongTinKhenThuong>
    {
        public C_ThongTinKhenThuongMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaNV);

            // Properties
            this.Property(t => t.C_MaNV)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.C_LoaiKhenThuong)
                .HasMaxLength(100);

            this.Property(t => t.C_CapKhenThuong)
                .HasMaxLength(100);

            this.Property(t => t.C_SoSoKhenThuong)
                .HasMaxLength(100);

            this.Property(t => t.C_NguoiKyKhenThuong)
                .HasMaxLength(100);

            this.Property(t => t.C_ThanhTichKhenThuong)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("_ThongTinKhenThuong");
            this.Property(t => t.C_MaNV).HasColumnName("_MaNV");
            this.Property(t => t.C_NamKhenThuong).HasColumnName("_NamKhenThuong");
            this.Property(t => t.C_LoaiKhenThuong).HasColumnName("_LoaiKhenThuong");
            this.Property(t => t.C_CapKhenThuong).HasColumnName("_CapKhenThuong");
            this.Property(t => t.C_SoSoKhenThuong).HasColumnName("_SoSoKhenThuong");
            this.Property(t => t.C_NguoiKyKhenThuong).HasColumnName("_NguoiKyKhenThuong");
            this.Property(t => t.C_ThanhTichKhenThuong).HasColumnName("_ThanhTichKhenThuong");
            this.Property(t => t.C_GhiChu).HasColumnName("_GhiChu");

            // Relationships
            this.HasRequired(t => t.C_ThongTinNguoiLaoDong)
                .WithOptional(t => t.C_ThongTinKhenThuong);

        }
    }
}
