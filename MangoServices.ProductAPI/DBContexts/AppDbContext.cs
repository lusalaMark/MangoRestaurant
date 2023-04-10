using Microsoft.EntityFrameworkCore;

namespace MangoServices.ProductAPI.DBContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
