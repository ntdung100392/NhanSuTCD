using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PMNS.Entities.Models.Mapping;

namespace PMNS.Entities.Models
{
    public partial class NhanSuTCDContext : DbContext
    {
        static NhanSuTCDContext()
        {
            Database.SetInitializer<NhanSuTCDContext>(null);
        }

        public NhanSuTCDContext()
            : base("Name=NhanSuTCDContext")
        {
        }

        public DbSet<BienChe> BienChes { get; set; }
        public DbSet<CapBac> CapBacs { get; set; }
        public DbSet<ChucVu> ChucVus { get; set; }
        public DbSet<Doi> Dois { get; set; }
        public DbSet<HopDongLaoDong> HopDongLaoDongs { get; set; }
        public DbSet<KhenThuong> KhenThuongs { get; set; }
        public DbSet<KyLuat> KyLuats { get; set; }
        public DbSet<LoaiTo> LoaiToes { get; set; }
        public DbSet<Phong> Phongs { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TD_DD_BN_TV> TD_DD_BN_TV { get; set; }
        public DbSet<ThanhPho> ThanhPhoes { get; set; }
        public DbSet<ThongTinGiaDinh> ThongTinGiaDinhs { get; set; }
        public DbSet<ThongTinNhanVIen> ThongTinNhanVIens { get; set; }
        public DbSet<To> Toes { get; set; }
        public DbSet<TrinhDo> TrinhDoes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BienCheMap());
            modelBuilder.Configurations.Add(new CapBacMap());
            modelBuilder.Configurations.Add(new ChucVuMap());
            modelBuilder.Configurations.Add(new DoiMap());
            modelBuilder.Configurations.Add(new HopDongLaoDongMap());
            modelBuilder.Configurations.Add(new KhenThuongMap());
            modelBuilder.Configurations.Add(new KyLuatMap());
            modelBuilder.Configurations.Add(new LoaiToMap());
            modelBuilder.Configurations.Add(new PhongMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TD_DD_BN_TVMap());
            modelBuilder.Configurations.Add(new ThanhPhoMap());
            modelBuilder.Configurations.Add(new ThongTinGiaDinhMap());
            modelBuilder.Configurations.Add(new ThongTinNhanVIenMap());
            modelBuilder.Configurations.Add(new ToMap());
            modelBuilder.Configurations.Add(new TrinhDoMap());
        }
    }
}
