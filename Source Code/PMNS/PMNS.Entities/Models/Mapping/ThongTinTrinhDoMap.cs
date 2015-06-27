using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class ThongTinTrinhDoMap : EntityTypeConfiguration<ThongTinTrinhDo>
    {
        public ThongTinTrinhDoMap()
        {
            // Primary Key
            this.HasKey(t => t.idThongTinTrinhDo);

            // Properties
            this.Property(t => t.noiDaoTao)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.chuyenNganh)
                .IsRequired()
                .HasMaxLength(150);

            this.Property(t => t.loaiHinh)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.bangCapPhu_CC)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("ThongTinTrinhDo");
            this.Property(t => t.idThongTinTrinhDo).HasColumnName("idThongTinTrinhDo");
            this.Property(t => t.idNhanVien).HasColumnName("idNhanVien");
            this.Property(t => t.idTrinhDo).HasColumnName("idTrinhDo");
            this.Property(t => t.noiDaoTao).HasColumnName("noiDaoTao");
            this.Property(t => t.chuyenNganh).HasColumnName("chuyenNganh");
            this.Property(t => t.loaiHinh).HasColumnName("loaiHinh");
            this.Property(t => t.thoiGianTotNghiep).HasColumnName("thoiGianTotNghiep");
            this.Property(t => t.bangCapPhu_CC).HasColumnName("bangCapPhu_CC");

            // Relationships
            this.HasRequired(t => t.ThongTinNhanVIen)
                .WithMany(t => t.ThongTinTrinhDoes)
                .HasForeignKey(d => d.idNhanVien);
            this.HasRequired(t => t.TrinhDo)
                .WithMany(t => t.ThongTinTrinhDoes)
                .HasForeignKey(d => d.idTrinhDo);

        }
    }
}
