using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace keepaAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuyBoxEligibleOfferCounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyBoxEligibleOfferCounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Csvs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Csvs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FbaFees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickAndPackFee = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FbaFees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Timestamp = table.Column<long>(type: "bigint", nullable: false),
                    TokensLeft = table.Column<int>(type: "int", nullable: false),
                    RefillIn = table.Column<int>(type: "int", nullable: false),
                    RefillRate = table.Column<int>(type: "int", nullable: false),
                    TokenFlowReduction = table.Column<double>(type: "float", nullable: false),
                    TokensConsumed = table.Column<int>(type: "int", nullable: false),
                    ProcessingTimeInMs = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductResponses", x => x.Id);
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
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrackingSince = table.Column<int>(type: "int", nullable: false),
                    ListedSince = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    BuyBoxSellerIdHistory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRedirectASIN = table.Column<bool>(type: "bit", nullable: false),
                    IsSNS = table.Column<bool>(type: "bit", nullable: false),
                    LastRatingUpdate = table.Column<int>(type: "int", nullable: false),
                    EbayListingIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastEbayUpdate = table.Column<int>(type: "int", nullable: false),
                    LiveOffersOrder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NewPriceIsMAP = table.Column<bool>(type: "bit", nullable: false),
                    Coupon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailabilityAmazon = table.Column<int>(type: "int", nullable: false),
                    SalesRankReference = table.Column<int>(type: "int", nullable: false),
                    Launchpad = table.Column<bool>(type: "bit", nullable: false),
                    IsB2B = table.Column<bool>(type: "bit", nullable: false),
                    LastSoldUpdate = table.Column<int>(type: "int", nullable: false),
                    MonthlySold = table.Column<int>(type: "int", nullable: false),
                    BuyBoxEligibleOfferCounts = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompetitivePriceThreshold = table.Column<int>(type: "int", nullable: false),
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
                    ReferralFeePercent = table.Column<int>(type: "int", nullable: false),
                    ReferralFeePercentage = table.Column<double>(type: "float", nullable: false),
                    ProductResponseId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductResponses_ProductResponseId",
                        column: x => x.ProductResponseId,
                        principalTable: "ProductResponses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_UnitCounts_UnitCountId",
                        column: x => x.UnitCountId,
                        principalTable: "UnitCounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<long>(type: "bigint", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryTrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryTrees_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contributors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contributors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contributors_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Eans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eans_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Features_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FrequentlyBoughts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrequentlyBoughts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FrequentlyBoughts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HazardousMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aspect = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HazardousMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HazardousMaterials_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Languages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastSeen = table.Column<int>(type: "int", nullable: false),
                    OfferId = table.Column<int>(type: "int", nullable: false),
                    SellerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Condition = table.Column<int>(type: "int", nullable: false),
                    ConditionComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsPrime = table.Column<bool>(type: "bit", nullable: false),
                    IsMAP = table.Column<bool>(type: "bit", nullable: false),
                    IsShippable = table.Column<bool>(type: "bit", nullable: false),
                    IsAddonItem = table.Column<bool>(type: "bit", nullable: false),
                    IsPreorder = table.Column<bool>(type: "bit", nullable: false),
                    IsWarehouseDeal = table.Column<bool>(type: "bit", nullable: false),
                    IsScam = table.Column<bool>(type: "bit", nullable: false),
                    ShipsFromChina = table.Column<bool>(type: "bit", nullable: false),
                    IsAmazon = table.Column<bool>(type: "bit", nullable: false),
                    IsFBA = table.Column<bool>(type: "bit", nullable: false),
                    IsPrimeExcl = table.Column<bool>(type: "bit", nullable: false),
                    Coupon = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EligibilityRequirementDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BenefitDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PromotionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    DiscountPercent = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Promotions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesRankReferenceHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesRankReferenceHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesRankReferenceHistories_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesRanks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesRanks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesRanks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Upcs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Upcs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Upcs_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Variations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Asin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentAsin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VariationCSV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Variations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Variations_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CouponHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    OfferId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CouponHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CouponHistories_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OfferCsvs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    OfferId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfferCsvs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OfferCsvs_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StockCsvs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    OfferId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockCsvs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockCsvs_Offers_OfferId",
                        column: x => x.OfferId,
                        principalTable: "Offers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ProductId",
                table: "Categories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryTrees_ProductId",
                table: "CategoryTrees",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Contributors_ProductId",
                table: "Contributors",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CouponHistories_OfferId",
                table: "CouponHistories",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Eans_ProductId",
                table: "Eans",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Features_ProductId",
                table: "Features",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_FrequentlyBoughts_ProductId",
                table: "FrequentlyBoughts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_HazardousMaterials_ProductId",
                table: "HazardousMaterials",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_ProductId",
                table: "Languages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OfferCsvs_OfferId",
                table: "OfferCsvs",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ProductId",
                table: "Offers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductResponseId",
                table: "Products",
                column: "ProductResponseId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitCountId",
                table: "Products",
                column: "UnitCountId");

            migrationBuilder.CreateIndex(
                name: "IX_Promotions_ProductId",
                table: "Promotions",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesRankReferenceHistories_ProductId",
                table: "SalesRankReferenceHistories",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesRanks_ProductId",
                table: "SalesRanks",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_StockCsvs_OfferId",
                table: "StockCsvs",
                column: "OfferId");

            migrationBuilder.CreateIndex(
                name: "IX_Upcs_ProductId",
                table: "Upcs",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Variations_ProductId",
                table: "Variations",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyBoxEligibleOfferCounts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "CategoryTrees");

            migrationBuilder.DropTable(
                name: "Contributors");

            migrationBuilder.DropTable(
                name: "CouponHistories");

            migrationBuilder.DropTable(
                name: "Csvs");

            migrationBuilder.DropTable(
                name: "Eans");

            migrationBuilder.DropTable(
                name: "FbaFees");

            migrationBuilder.DropTable(
                name: "Features");

            migrationBuilder.DropTable(
                name: "FrequentlyBoughts");

            migrationBuilder.DropTable(
                name: "HazardousMaterials");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "OfferCsvs");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "SalesRankReferenceHistories");

            migrationBuilder.DropTable(
                name: "SalesRanks");

            migrationBuilder.DropTable(
                name: "StockCsvs");

            migrationBuilder.DropTable(
                name: "Upcs");

            migrationBuilder.DropTable(
                name: "Variations");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductResponses");

            migrationBuilder.DropTable(
                name: "UnitCounts");
        }
    }
}
