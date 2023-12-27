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
    }
}
