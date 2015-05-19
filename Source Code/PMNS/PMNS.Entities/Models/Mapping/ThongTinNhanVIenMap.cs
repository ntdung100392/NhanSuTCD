using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class ThongTinNhanVIenMap : EntityTypeConfiguration<ThongTinNhanVIen>
    {
        public ThongTinNhanVIenMap()
        {
            // Primary Key
            this.HasKey(t => t.idNhanVien);

            // Properties
            this.Property(t => t.MaNV)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.userName)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.password)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.hoTen)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CMND)
                .HasMaxLength(50);

            this.Property(t => t.noiCapCMND)
                .HasMaxLength(50);

            this.Property(t => t.soDienThoaiNha)
                .HasMaxLength(50);

            this.Property(t => t.soDienThoaiDiDong)
                .HasMaxLength(50);

            this.Property(t => t.nguoiBaoLanh)
                .HasMaxLength(50);

            this.Property(t => t.moiQuanHeBaoLanh)
                .HasMaxLength(50);

            this.Property(t => t.tinhTrangHonNhan)
                .HasMaxLength(100);

            this.Property(t => t.hinhAnhCaNhan)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("ThongTinNhanVIen");
            this.Property(t => t.idNhanVien).HasColumnName("idNhanVien");
            this.Property(t => t.MaNV).HasColumnName("MaNV");
            this.Property(t => t.idPhong).HasColumnName("idPhong");
            this.Property(t => t.userName).HasColumnName("userName");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.permission).HasColumnName("permission");
            this.Property(t => t.idBienChe).HasColumnName("idBienChe");
            this.Property(t => t.idCapBac).HasColumnName("idCapBac");
            this.Property(t => t.idChucVu).HasColumnName("idChucVu");
            this.Property(t => t.idTP).HasColumnName("idTP");
            this.Property(t => t.CongViecDangLam).HasColumnName("CongViecDangLam");
            this.Property(t => t.hoTen).HasColumnName("hoTen");
            this.Property(t => t.gioiTinh).HasColumnName("gioiTinh");
            this.Property(t => t.namSinh).HasColumnName("namSinh");
            this.Property(t => t.nguyenQuan).HasColumnName("nguyenQuan");
            this.Property(t => t.noiOHienNay).HasColumnName("noiOHienNay");
            this.Property(t => t.hoKhau).HasColumnName("hoKhau");
            this.Property(t => t.CMND).HasColumnName("CMND");
            this.Property(t => t.ngayCapCMND).HasColumnName("ngayCapCMND");
            this.Property(t => t.noiCapCMND).HasColumnName("noiCapCMND");
            this.Property(t => t.soDienThoaiNha).HasColumnName("soDienThoaiNha");
            this.Property(t => t.soDienThoaiDiDong).HasColumnName("soDienThoaiDiDong");
            this.Property(t => t.nguoiBaoLanh).HasColumnName("nguoiBaoLanh");
            this.Property(t => t.moiQuanHeBaoLanh).HasColumnName("moiQuanHeBaoLanh");
            this.Property(t => t.noiCongTac).HasColumnName("noiCongTac");
            this.Property(t => t.ngayVaoCang).HasColumnName("ngayVaoCang");
            this.Property(t => t.namVaoSongThan).HasColumnName("namVaoSongThan");
            this.Property(t => t.ngayNhapNgu).HasColumnName("ngayNhapNgu");
            this.Property(t => t.tinhTrangHonNhan).HasColumnName("tinhTrangHonNhan");
            this.Property(t => t.hinhAnhCaNhan).HasColumnName("hinhAnhCaNhan");
            this.Property(t => t.idTo).HasColumnName("idTo");
            this.Property(t => t.idDoi).HasColumnName("idDoi");
            this.Property(t => t.idLoaiTo).HasColumnName("idLoaiTo");

            // Relationships
            this.HasRequired(t => t.BienChe)
                .WithMany(t => t.ThongTinNhanVIens)
                .HasForeignKey(d => d.idBienChe);
            this.HasRequired(t => t.CapBac)
                .WithMany(t => t.ThongTinNhanVIens)
                .HasForeignKey(d => d.idCapBac);
            this.HasRequired(t => t.ChucVu)
                .WithMany(t => t.ThongTinNhanVIens)
                .HasForeignKey(d => d.idChucVu);
            this.HasRequired(t => t.Phong)
                .WithMany(t => t.ThongTinNhanVIens)
                .HasForeignKey(d => d.idPhong);
            this.HasRequired(t => t.ThanhPho)
                .WithMany(t => t.ThongTinNhanVIens)
                .HasForeignKey(d => d.idTP);

        }
    }
}
