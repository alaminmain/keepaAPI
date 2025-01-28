namespace Keepa.Api.Backend.Structs
{
    /// <summary>
    /// Represents a price alert notification.
    /// </summary>
    public class Notification
    {
        /// <summary>
        /// The notified product ASIN.
        /// </summary>
        public string Asin { get; set; }

        /// <summary>
        /// Title of the product. May contain HTML markup in rare cases.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The main image name of the product. Full Amazon image path: https://m.media-amazon.com/images/I/_image_name_.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Creation date of the notification in Keepa Time minutes.
        /// </summary>
        public int CreateDate { get; set; }

        /// <summary>
        /// The main Amazon locale of the tracking which determines the currency used for all prices of this notification.
        /// </summary>
        public byte DomainId { get; set; }

        /// <summary>
        /// The Amazon locale which triggered the notification.
        /// </summary>
        public byte NotificationDomainId { get; set; }

        /// <summary>
        /// The CsvType which triggered the notification.
        /// </summary>
        public int CsvType { get; set; }

        /// <summary>
        /// The tracking notification cause of the notification.
        /// </summary>
        public int TrackingNotificationCause { get; set; }

        /// <summary>
        /// Contains the prices/values of the product at the time this notification was created.
        /// The price is an integer of the respective Amazon locale's smallest currency unit (e.g., euro cents or yen).
        /// If no offer was available in the given interval (e.g., out of stock), the price has the value -1.
        /// </summary>
        public int[] CurrentPrices { get; set; }

        /// <summary>
        /// States through which notification channels this notification was delivered.
        /// </summary>
        public bool[] SentNotificationVia { get; set; }

        /// <summary>
        /// The metadata of the tracking.
        /// </summary>
        public string MetaData { get; set; }
    }
}
