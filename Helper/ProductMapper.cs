using keepaAPI.Structs;

namespace keepaAPI.Helper
{
    public static class ProductMapper
    {
        public static ProductForBrandTrader MapToProductForBrandTrader(Structs.ProductRawClasses.Product product)
        {
            var BuyBoxPrice =Convert.ToDecimal(product.Stats.BuyBoxPrice)/100;
            var Rating = Convert.ToDecimal(product.Stats.Current[16])/10;
            var Ranking = product.Stats.Current[3];
            
            return new ProductForBrandTrader
            {
                Asin = product.Asin,
                DomainId = (byte)(product.DomainId ?? 0),
                ParentAsin = product.ParentAsin,
                VariationCSV = product.VariationCSV,
                UpcList = product.UpcList?.Select(upc => new keepaAPI.Structs.Upc { Value = upc }).ToList(),
                EanList = product.EanList?.Select(ean => new keepaAPI.Structs.Ean { Value = ean }).ToList(),
                ImagesCSV = product.ImagesCSV,
                RootCategory = product.RootCategory ?? 0,
                Manufacturer = product.Manufacturer,
                Title = product.Title,
                TrackingSince = product.TrackingSince ?? 0,
                ListedSince = product.ListedSince ?? 0,
                Brand = product.Brand,
                ProductGroup = product.ProductGroup,
                PartNumber = product.PartNumber,
                Model = product.Model,
                Color = product.Color,
                Size = product.Size,
                Edition = product.Edition?.ToString(),
                
                Author = product.Author,
                Binding = product.Binding,
                NumberOfItems = product.NumberOfItems ?? 0,
                NumberOfPages = product.NumberOfPages ?? 0,
                PublicationDate = product.PublicationDate ?? 0,
                ReleaseDate = product.ReleaseDate ?? 0,
                Features = product.Features != null ? string.Join(", ", product.Features) : null,
                Description = product.Description,
                PackageHeight = product.PackageHeight ?? 0,
                PackageLength = product.PackageLength ?? 0,
                PackageWidth = product.PackageWidth ?? 0,
                PackageWeight = product.PackageWeight ?? 0,
                PackageQuantity = product.PackageQuantity ?? 0,
                ItemHeight = product.ItemHeight ?? 0,
                ItemLength = product.ItemLength ?? 0,
                ItemWidth = product.ItemWidth ?? 0,
                ItemWeight = product.ItemWeight ?? 0,
                IsAdultProduct = product.IsAdultProduct ?? false,
                IsEligibleForTradeIn = product.IsEligibleForTradeIn ?? false,
                IsEligibleForSuperSaverShipping = product.IsEligibleForSuperSaverShipping ?? false,
                FrequentlyBoughtTogether = product.FrequentlyBoughtTogether != null ? string.Join(", ", product.FrequentlyBoughtTogether) : null,
                NewPriceIsMAP = product.NewPriceIsMAP ?? false,
                AvailabilityAmazon = product.AvailabilityAmazon ?? 0,
                Variations = product.Variations?.Select(v => new Variation
                {
                    Asin = v.Asin,
                    //Attributes = v.Attributes?.Select(a => new Attribute
                    //{
                    //    Dimension = a.Dimension,
                    //    Value = a.Value
                    //}).ToList()
                }).ToList(),
                BuyBoxPrice = BuyBoxPrice,
                SalesRankReference = product.SalesRankReference ?? 0,
                Launchpad = product.Launchpad ?? false,
                IsB2B = product.IsB2B ?? false,
                LastSoldUpdate = product.LastSoldUpdate ?? 0,
                MonthlySold = product.MonthlySold ?? 0,
                CompetitivePriceThreshold = product.CompetitivePriceThreshold ?? 0,
                HazardousMaterials = product.HazardousMaterials != null ? string.Join(", ", product.HazardousMaterials.Select(h => h.Value)) : null,
                IsHeatSensitive = product.IsHeatSensitive ?? false,
                UrlSlug = product.UrlSlug,
                Ingredients = product.Ingredients,
                UnitCount = product.UnitCount != null ? new UnitCount
                {
                    UnitValue = product.UnitCount.UnitValue ?? 0,
                    UnitType = product.UnitCount.UnitType
                } : null,
                ItemForm = product.ItemForm,
                ItemTypeKeyword = product.ItemTypeKeyword,
                SafetyWarning = product.SafetyWarning,
                TargetAudienceKeyword = product.TargetAudienceKeyword,
                Style = product.Style,
                Scent = product.Scent,
                OffersSuccessful = product.OffersSuccessful ?? false,
                G = product.G ?? 0,
                CategoryTree = product.CategoryTree != null ? string.Join(", ", product.CategoryTree.Select(c => c.Name)) : null,
                ReferralFeePercent = product.ReferralFeePercent ?? 0,
                ReferralFeePercentage = product.ReferralFeePercentage ?? 0,
                Rating = Rating,
                SalesRankOnMainCategory = Ranking
            };
        }
    }
}