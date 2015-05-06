using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using PMNS.Entities.Models.Mapping;

namespace PMNS.Entities.Models
{
    public partial class WebNhanSuContext : DbContext
    {
        static WebNhanSuContext()
        {
            Database.SetInitializer<WebNhanSuContext>(null);
        }

        public WebNhanSuContext()
            : base("Name=WebNhanSuContext")
        {
        }

        public DbSet<C_Doi> C_Doi { get; set; }
        public DbSet<C_LoaiTo> C_LoaiTo { get; set; }
        public DbSet<C_Phong> C_Phong { get; set; }
        public DbSet<C_ThanhPho> C_ThanhPho { get; set; }
        public DbSet<C_ThongTinGiaDinh> C_ThongTinGiaDinh { get; set; }
        public DbSet<C_ThongTinHopDongLaoDong> C_ThongTinHopDongLaoDong { get; set; }
        public DbSet<C_ThongTinKhenThuong> C_ThongTinKhenThuong { get; set; }
        public DbSet<C_ThongTinKyLuat> C_ThongTinKyLuat { get; set; }
        public DbSet<C_ThongTinNguoiLaoDong> C_ThongTinNguoiLaoDong { get; set; }
        public DbSet<C_ThongTinTrinhDo> C_ThongTinTrinhDo { get; set; }
        public DbSet<C_To> C_To { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<TD_DD_BN_TV> TD_DD_BN_TV { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new C_DoiMap());
            modelBuilder.Configurations.Add(new C_LoaiToMap());
            modelBuilder.Configurations.Add(new C_PhongMap());
            modelBuilder.Configurations.Add(new C_ThanhPhoMap());
            modelBuilder.Configurations.Add(new C_ThongTinGiaDinhMap());
            modelBuilder.Configurations.Add(new C_ThongTinHopDongLaoDongMap());
            modelBuilder.Configurations.Add(new C_ThongTinKhenThuongMap());
            modelBuilder.Configurations.Add(new C_ThongTinKyLuatMap());
            modelBuilder.Configurations.Add(new C_ThongTinNguoiLaoDongMap());
            modelBuilder.Configurations.Add(new C_ThongTinTrinhDoMap());
            modelBuilder.Configurations.Add(new C_ToMap());
            modelBuilder.Configurations.Add(new sysdiagramMap());
            modelBuilder.Configurations.Add(new TD_DD_BN_TVMap());
        }
    }
}
