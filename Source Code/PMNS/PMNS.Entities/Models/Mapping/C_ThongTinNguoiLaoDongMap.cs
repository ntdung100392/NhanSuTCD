using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_ThongTinNguoiLaoDongMap : EntityTypeConfiguration<C_ThongTinNguoiLaoDong>
    {
        public C_ThongTinNguoiLaoDongMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaNV);

            // Properties
            this.Property(t => t.C_MaNV)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.C_MaPhongBan)
                .HasMaxLength(50);

            this.Property(t => t.C_MaDoi)
                .HasMaxLength(50);

            this.Property(t => t.C_MaLoaiTo)
                .HasMaxLength(50);

            this.Property(t => t.C_MaTo)
                .HasMaxLength(50);

            this.Property(t => t.C_user)
                .HasMaxLength(20);

            this.Property(t => t.C_Password)
                .HasMaxLength(50);

            this.Property(t => t.C_PhanQuyen)
                .IsRequired()
                .HasMaxLength(8);

            this.Property(t => t.C_BienChe)
                .HasMaxLength(50);

            this.Property(t => t.C_CapBac)
                .HasMaxLength(50);

            this.Property(t => t.C_ChucVu)
                .HasMaxLength(50);

            this.Property(t => t.C_MaChucVu)
                .HasMaxLength(50);

            this.Property(t => t.C_HoTen)
                .HasMaxLength(100);

            this.Property(t => t.C_GioiTinh)
                .HasMaxLength(8);

            this.Property(t => t.C_CMND)
                .HasMaxLength(20);

            this.Property(t => t.C_NoiCapCMND)
                .HasMaxLength(50);

            this.Property(t => t.C_SDTNha)
                .HasMaxLength(20);

            this.Property(t => t.C_SDTDD)
                .HasMaxLength(20);

            this.Property(t => t.C_NguoiBaoLanh)
                .HasMaxLength(50);

            this.Property(t => t.C_MoiQuanHeNBL)
                .HasMaxLength(100);

            this.Property(t => t.C_TinhTrangHonNhan)
                .HasMaxLength(100);

            this.Property(t => t.C_MaTP)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("_ThongTinNguoiLaoDong");
            this.Property(t => t.C_MaNV).HasColumnName("_MaNV");
            this.Property(t => t.C_MaPhongBan).HasColumnName("_MaPhongBan");
            this.Property(t => t.C_MaDoi).HasColumnName("_MaDoi");
            this.Property(t => t.C_MaLoaiTo).HasColumnName("_MaLoaiTo");
            this.Property(t => t.C_MaTo).HasColumnName("_MaTo");
            this.Property(t => t.C_user).HasColumnName("_user");
            this.Property(t => t.C_Password).HasColumnName("_Password");
            this.Property(t => t.C_PhanQuyen).HasColumnName("_PhanQuyen");
            this.Property(t => t.C_BienChe).HasColumnName("_BienChe");
            this.Property(t => t.C_CapBac).HasColumnName("_CapBac");
            this.Property(t => t.C_ChucVu).HasColumnName("_ChucVu");
            this.Property(t => t.C_MaChucVu).HasColumnName("_MaChucVu");
            this.Property(t => t.C_CongViecDangLam).HasColumnName("_CongViecDangLam");
            this.Property(t => t.C_HoTen).HasColumnName("_HoTen");
            this.Property(t => t.C_GioiTinh).HasColumnName("_GioiTinh");
            this.Property(t => t.C_NamSinh).HasColumnName("_NamSinh");
            this.Property(t => t.C_NguyenQuan).HasColumnName("_NguyenQuan");
            this.Property(t => t.C_NoiOHienNay).HasColumnName("_NoiOHienNay");
            this.Property(t => t.C_HoKhau).HasColumnName("_HoKhau");
            this.Property(t => t.C_CMND).HasColumnName("_CMND");
            this.Property(t => t.C_NgayCapCMND).HasColumnName("_NgayCapCMND");
            this.Property(t => t.C_NoiCapCMND).HasColumnName("_NoiCapCMND");
            this.Property(t => t.C_SDTNha).HasColumnName("_SDTNha");
            this.Property(t => t.C_SDTDD).HasColumnName("_SDTDD");
            this.Property(t => t.C_NguoiBaoLanh).HasColumnName("_NguoiBaoLanh");
            this.Property(t => t.C_MoiQuanHeNBL).HasColumnName("_MoiQuanHeNBL");
            this.Property(t => t.C_NoiCongTac).HasColumnName("_NoiCongTac");
            this.Property(t => t.C_NgayVaoCang).HasColumnName("_NgayVaoCang");
            this.Property(t => t.C_NamVaoST).HasColumnName("_NamVaoST");
            this.Property(t => t.C_NgayNhapNgu).HasColumnName("_NgayNhapNgu");
            this.Property(t => t.C_TinhTrangHonNhan).HasColumnName("_TinhTrangHonNhan");
            this.Property(t => t.C_HinhAnhCaNhan).HasColumnName("_HinhAnhCaNhan");
            this.Property(t => t.C_MaTP).HasColumnName("_MaTP");

            // Relationships
            this.HasOptional(t => t.C_Doi)
                .WithMany(t => t.C_ThongTinNguoiLaoDong)
                .HasForeignKey(d => d.C_MaDoi);
            this.HasOptional(t => t.C_LoaiTo)
                .WithMany(t => t.C_ThongTinNguoiLaoDong)
                .HasForeignKey(d => d.C_MaLoaiTo);
            this.HasOptional(t => t.C_Phong)
                .WithMany(t => t.C_ThongTinNguoiLaoDong)
                .HasForeignKey(d => d.C_MaPhongBan);
            this.HasOptional(t => t.C_ThanhPho)
                .WithMany(t => t.C_ThongTinNguoiLaoDong)
                .HasForeignKey(d => d.C_MaTP);
            this.HasOptional(t => t.C_To)
                .WithMany(t => t.C_ThongTinNguoiLaoDong)
                .HasForeignKey(d => d.C_MaTo);

        }
    }
}
