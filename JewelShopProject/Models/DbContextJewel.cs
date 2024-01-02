using Microsoft.EntityFrameworkCore;
using JewelShopProject.Models;

namespace JewelShopProject.Models
{
    public class DbContextJewel:DbContext
    {

        public DbContextJewel(DbContextOptions<DbContextJewel> options) : base(options)
        {

        }
        public DbSet<AdminLoginMst> adminLoginMsts { get; set; }
        public DbSet<JewelShopProject.Models.BrandMst>? BrandMst { get; set; }
        public DbSet<JewelShopProject.Models.DimInfoMst>? DimInfoMst { get; set; }

        
        public DbSet<CartList> cartLists{ get; set; }
        public DbSet<CatMst> catMsts{ get; set; }
        public DbSet<CertifyMst> certifyMsts{ get; set; }
        public DbSet<DimMst> dimMsts{ get; set; }

        public DbSet<DimQltyMst> dimQltySubMsts{ get; set; }
        public DbSet<GoldKrtMst> goldKrtMsts{ get; set; }
        public DbSet<Inquiry> inquiries{ get; set; }
        //public DbSet<ItemMst> itemMsts{ get; set; }
        public DbSet<JewelTypeMst> jewelTypeMsts{ get; set; }
         public DbSet<ProdMst> prodMsts { get; set; }
        public DbSet<StoneMst> stoneMsts { get; set; }
        public DbSet<UserRegMst> userRegMsts { get; set; }
    }
}
