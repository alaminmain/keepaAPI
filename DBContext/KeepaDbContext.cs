using Microsoft.EntityFrameworkCore;

public class KeepaDbContext : DbContext
{
    public KeepaDbContext(DbContextOptions<KeepaDbContext> options) : base(options) { }

    public DbSet<ProductResponse> ProductResponses { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Offer> Offers { get; set; }
    public DbSet<Upc> Upcs { get; set; }
    public DbSet<Ean> Eans { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Contributor> Contributors { get; set; }
    public DbSet<Feature> Features { get; set; }
    public DbSet<Csv> Csvs { get; set; }
    public DbSet<OfferCsv> OfferCsvs { get; set; }
    public DbSet<StockCsv> StockCsvs { get; set; }
    public DbSet<CouponHistory> CouponHistories { get; set; }
    public DbSet<Promotion> Promotions { get; set; }
    public DbSet<Variation> Variations { get; set; }
    public DbSet<FbaFees> FbaFees { get; set; }
    public DbSet<SalesRank> SalesRanks { get; set; }
    public DbSet<SalesRankReferenceHistory> SalesRankReferenceHistories { get; set; }
    public DbSet<BuyBoxEligibleOfferCount> BuyBoxEligibleOfferCounts { get; set; }
    public DbSet<HazardousMaterial> HazardousMaterials { get; set; }
    public DbSet<UnitCount> UnitCounts { get; set; }
    public DbSet<CategoryTree> CategoryTrees { get; set; }
    public DbSet<FrequentlyBought> FrequentlyBoughts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure ProductResponse and Product relationship
        modelBuilder.Entity<ProductResponse>()
            .HasMany(pr => pr.Products)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and Offer relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.Offers)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and Upc relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.UpcList)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and Ean relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.EanList)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and Category relationship
        //modelBuilder.Entity<Product>()
        //    .HasMany(p => p.Categories)
        //    .WithOne()
        //    .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and Language relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.Languages)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and Contributor relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.Contributors)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and Feature relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.Features)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and Csv relationship
        //modelBuilder.Entity<Product>()
        //    .HasMany(p => p.Csv)
        //    .WithOne()
        //    .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and LiveOffersOrder relationship
        //modelBuilder.Entity<Product>()
        //    .HasMany(p => p.LiveOffersOrder)
        //    .WithOne()
        //    .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and FrequentlyBoughtTogether relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.FrequentlyBoughtTogether)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and Promotion relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.Promotions)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and Variation relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.Variations)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and SalesRank relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.SalesRanks)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and SalesRankReferenceHistory relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.SalesRankReferenceHistory)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and BuyBoxEligibleOfferCount relationship
        //modelBuilder.Entity<Product>()
        //    .HasMany(p => p.BuyBoxEligibleOfferCounts)
        //    .WithOne()
        //    .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and HazardousMaterial relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.HazardousMaterials)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and UnitCount relationship
        //modelBuilder.Entity<Product>()
        //    .HasOne(p => p.UnitCount)
        //    .WithOne()
        //    .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and CategoryTree relationship
        modelBuilder.Entity<Product>()
            .HasMany(p => p.CategoryTree)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Product and FbaFees relationship
        //modelBuilder.Entity<Product>()
        //    .HasOne(p => p.FbaFees)
        //    .WithOne()
        //    .OnDelete(DeleteBehavior.Cascade);

        // Configure Offer and OfferCsv relationship
        modelBuilder.Entity<Offer>()
            .HasMany(o => o.OfferCSV)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Offer and StockCsv relationship
        modelBuilder.Entity<Offer>()
            .HasMany(o => o.StockCSV)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

        // Configure Offer and CouponHistory relationship
        modelBuilder.Entity<Offer>()
            .HasMany(o => o.CouponHistory)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);
    }
}
