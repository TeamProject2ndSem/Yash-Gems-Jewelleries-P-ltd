using Microsoft.EntityFrameworkCore;

namespace JewelShopProject.Models
{
    public class DbContextJewel:DbContext
    {

        public DbContextJewel(DbContextOptions<DbContextJewel> options) : base(options)
        {

        }
        public DbSet<AdminLoginMst> adminLoginMsts { get; set; }
    }
}
