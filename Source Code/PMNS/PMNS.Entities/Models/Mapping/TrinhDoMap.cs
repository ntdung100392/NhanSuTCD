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
            this.Property(t => t.TrinhDo1)
                .IsRequired()
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("TrinhDo");
            this.Property(t => t.idTrinhDo).HasColumnName("idTrinhDo");
            this.Property(t => t.TrinhDo1).HasColumnName("TrinhDo");
        }
    }
}
