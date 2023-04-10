using MangoServices.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MangoServices.ProductAPI.DBContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
