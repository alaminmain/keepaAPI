using Microsoft.EntityFrameworkCore;

namespace keepaAPI.DBContext
{
    public class KeepaDbContext : DbContext
    {
        public KeepaDbContext(DbContextOptions<KeepaDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductResponse> ProductResponses { get; set; }
    }
}
