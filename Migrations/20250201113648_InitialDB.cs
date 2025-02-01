using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keepaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitCounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitValue = table.Column<double>(type: "float", nullable: false),
                    UnitType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitCounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Upcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upcs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DomainId = table.Column<byte>(type: "tinyint", nullable: false),
                    ParentAsin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariationCSV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImagesCSV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RootCategory = table.Column<long>(type: "bigint", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackingSince = table.Column<int>(type: "int", nullable: false),
                    ListedSince = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ProductGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Binding = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfItems = table.Column<int>(type: "int", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    PublicationDate = table.Column<int>(type: "int", nullable: false),
                    ReleaseDate = table.Column<int>(type: "int", nullable: false),
                    Features = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PackageHeight = table.Column<int>(type: "int", nullable: false),
                    PackageLength = table.Column<int>(type: "int", nullable: false),
                    PackageWidth = table.Column<int>(type: "int", nullable: false),
                    PackageWeight = table.Column<int>(type: "int", nullable: false),
                    PackageQuantity = table.Column<int>(type: "int", nullable: false),
                    ItemHeight = table.Column<int>(type: "int", nullable: false),
                    ItemLength = table.Column<int>(type: "int", nullable: false),
                    ItemWidth = table.Column<int>(type: "int", nullable: false),
                    ItemWeight = table.Column<int>(type: "int", nullable: false),
                    IsAdultProduct = table.Column<bool>(type: "bit", nullable: false),
                    IsEligibleForTradeIn = table.Column<bool>(type: "bit", nullable: false),
                    IsEligibleForSuperSaverShipping = table.Column<bool>(type: "bit", nullable: false),
                    BuyBoxPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsRedirectASIN = table.Column<bool>(type: "bit", nullable: false),
                    IsSNS = table.Column<bool>(type: "bit", nullable: false),
                    LastRatingUpdate = table.Column<int>(type: "int", nullable: false),
                    EbayListingIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastEbayUpdate = table.Column<int>(type: "int", nullable: false),
                    FrequentlyBoughtTogether = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewPriceIsMAP = table.Column<bool>(type: "bit", nullable: false),
                    AvailabilityAmazon = table.Column<int>(type: "int", nullable: false),
                    SalesRankReference = table.Column<int>(type: "int", nullable: false),
                    SalesRanks = table.Column<int>(type: "int", nullable: false),
                    Launchpad = table.Column<bool>(type: "bit", nullable: false),
                    IsB2B = table.Column<bool>(type: "bit", nullable: false),
                    LastSoldUpdate = table.Column<int>(type: "int", nullable: false),
                    MonthlySold = table.Column<int>(type: "int", nullable: false),
                    CompetitivePriceThreshold = table.Column<int>(type: "int", nullable: false),
                    HazardousMaterials = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsHeatSensitive = table.Column<bool>(type: "bit", nullable: false),
                    UrlSlug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitCountId = table.Column<int>(type: "int", nullable: false),
                    ItemForm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemTypeKeyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SafetyWarning = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TargetAudienceKeyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Scent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OffersSuccessful = table.Column<bool>(type: "bit", nullable: false),
                    G = table.Column<int>(type: "int", nullable: false),
                    CategoryTree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReferralFeePercent = table.Column<int>(type: "int", nullable: false),
                    ReferralFeePercentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_UnitCounts_UnitCountId",
                        column: x => x.UnitCountId,
                        principalTable: "UnitCounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ean",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ProductForBrandTraderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ean", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ean_Products_ProductForBrandTraderId",
                        column: x => x.ProductForBrandTraderId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Upc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ProductForBrandTraderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upc", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Upc_Products_ProductForBrandTraderId",
                        column: x => x.ProductForBrandTraderId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Variations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asin = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    ParentAsin = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    VariationCSV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductForBrandTraderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variations_Products_ProductForBrandTraderId",
                        column: x => x.ProductForBrandTraderId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ean_ProductForBrandTraderId",
                table: "Ean",
                column: "ProductForBrandTraderId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitCountId",
                table: "Products",
                column: "UnitCountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Upc_ProductForBrandTraderId",
                table: "Upc",
                column: "ProductForBrandTraderId");

            migrationBuilder.CreateIndex(
                name: "IX_Variations_ProductForBrandTraderId",
                table: "Variations",
                column: "ProductForBrandTraderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ean");

            migrationBuilder.DropTable(
                name: "Eans");

            migrationBuilder.DropTable(
                name: "Upc");

            migrationBuilder.DropTable(
                name: "Upcs");

            migrationBuilder.DropTable(
                name: "Variations");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "UnitCounts");
        }
    }
}
