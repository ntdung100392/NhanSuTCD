using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace PMNS.Entities.Models.Mapping
{
    public class C_ThongTinTrinhDoMap : EntityTypeConfiguration<C_ThongTinTrinhDo>
    {
        public C_ThongTinTrinhDoMap()
        {
            // Primary Key
            this.HasKey(t => t.C_MaNV);

            // Properties
            this.Property(t => t.C_MaNV)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.C_VanHoa)
                .HasMaxLength(50);

            this.Property(t => t.C_LoaiHinh)
                .HasMaxLength(50);

            this.Property(t => t.C_BangCapPhu_CC)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("_ThongTinTrinhDo");
            this.Property(t => t.C_MaNV).HasColumnName("_MaNV");
            this.Property(t => t.C_VanHoa).HasColumnName("_VanHoa");
            this.Property(t => t.C_TrinhDo).HasColumnName("_TrinhDo");
            this.Property(t => t.C_NoiDaoTao).HasColumnName("_NoiDaoTao");
            this.Property(t => t.C_ChuyenNganh).HasColumnName("_ChuyenNganh");
            this.Property(t => t.C_LoaiHinh).HasColumnName("_LoaiHinh");
            this.Property(t => t.C_ThoiGianTotNghiep).HasColumnName("_ThoiGianTotNghiep");
            this.Property(t => t.C_BangCapPhu_CC).HasColumnName("_BangCapPhu_CC");

            // Relationships
            this.HasRequired(t => t.C_ThongTinNguoiLaoDong)
                .WithOptional(t => t.C_ThongTinTrinhDo);

        }
    }
}
