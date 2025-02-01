using keepaAPI.Structs;
using Microsoft.EntityFrameworkCore;

namespace keepaAPI.DBContext
{
    public class KeepaDbContext : DbContext
    {
        public KeepaDbContext(DbContextOptions<KeepaDbContext> options) : base(options) { }

        public DbSet<ProductForBrandTrader> Products { get; set; }
        public DbSet<Upc> Upcs { get; set; }
        public DbSet<Ean> Eans { get; set; }
        public DbSet<Variation> Variations { get; set; }
        public DbSet<UnitCount> UnitCounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductForBrandTrader>()
                .HasMany(p => p.UpcList)
                .WithOne()
                .HasForeignKey("ProductForBrandTraderId");

            modelBuilder.Entity<ProductForBrandTrader>()
                .HasMany(p => p.EanList)
                .WithOne()
                .HasForeignKey("ProductForBrandTraderId");

            modelBuilder.Entity<ProductForBrandTrader>()
                .HasMany(p => p.Variations)
                .WithOne()
                .HasForeignKey("ProductForBrandTraderId");

            modelBuilder.Entity<ProductForBrandTrader>()
                .HasOne(p => p.UnitCount)
                .WithOne()
                .HasForeignKey<ProductForBrandTrader>("UnitCountId");

            base.OnModelCreating(modelBuilder);
        }
    }
}
