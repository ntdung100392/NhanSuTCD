using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class TrinhDoMap : EntityTypeConfiguration<TrinhDo>
    {
        public TrinhDoMap()
        {
            // Primary Key
            this.HasKey(t => t.idTrinhDo);

            // Properties
            this.Property(t => t.vanHoa)
                .HasMaxLength(50);

            this.Property(t => t.loaiHinh)
                .HasMaxLength(50);

            this.Property(t => t.bangCapPhu_CC)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("TrinhDo");
            this.Property(t => t.idTrinhDo).HasColumnName("idTrinhDo");
            this.Property(t => t.idNhanVien).HasColumnName("idNhanVien");
            this.Property(t => t.vanHoa).HasColumnName("vanHoa");
            this.Property(t => t.trinhDo1).HasColumnName("trinhDo");
            this.Property(t => t.noiDaoTao).HasColumnName("noiDaoTao");
            this.Property(t => t.chuyenNganh).HasColumnName("chuyenNganh");
            this.Property(t => t.loaiHinh).HasColumnName("loaiHinh");
            this.Property(t => t.thoiGianTotNghiep).HasColumnName("thoiGianTotNghiep");
            this.Property(t => t.bangCapPhu_CC).HasColumnName("bangCapPhu_CC");

            // Relationships
            this.HasRequired(t => t.ThongTinNhanVIen)
                .WithMany(t => t.TrinhDoes)
                .HasForeignKey(d => d.idNhanVien);

        }
    }
}
