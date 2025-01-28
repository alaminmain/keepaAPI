using System;
using Newtonsoft.Json;

namespace keepaAPI.Structs
{
    /// <summary>
    /// Required by the Add Tracking request.
    /// </summary>
    public class TrackingRequest
    {
        /// <summary>
        /// The product ASIN to track.
        /// </summary>
        public string Asin { get; set; }

        /// <summary>
        /// The time to live in hours until the tracking expires and is deleted.
        /// </summary>
        public int Ttl { get; set; } = 24 * 365 * 2; // Default: 2 years

        /// <summary>
        /// Trigger a notification if tracking expires or is removed.
        /// </summary>
        public bool ExpireNotify { get; set; } = false;

        /// <summary>
        /// Whether or not all desired prices are in the currency of the mainDomainId.
        /// </summary>
        public bool DesiredPricesInMainCurrency { get; set; } = true;

        /// <summary>
        /// The main Amazon locale of this tracking determines the currency used for all desired prices.
        /// </summary>
        public byte MainDomainId { get; set; }

        /// <summary>
        /// Contains all settings for price or value related tracking criteria.
        /// </summary>
        public Tracking.TrackingThresholdValue[] ThresholdValues { get; set; }

        /// <summary>
        /// Contains specific meta tracking criteria, like out of stock.
        /// </summary>
        public Tracking.TrackingNotifyIf[] NotifyIf { get; set; }

        /// <summary>
        /// Determines through which channels notifications will be sent.
        /// </summary>
        public bool[] NotificationType { get; set; }

        /// <summary>
        /// A tracking specific rearm timer.
        /// </summary>
        public int IndividualNotificationInterval { get; set; } = -1;

        /// <summary>
        /// The update interval, in hours.
        /// </summary>
        public int UpdateInterval { get; set; } = 1;

        /// <summary>
        /// Metadata for this tracking (max length is 500 characters).
        /// </summary>
        public string MetaData { get; set; }

        /// <summary>
        /// Constructor to initialize a tracking request.
        /// </summary>
        public TrackingRequest(string asin, byte mainDomainId, int updateInterval)
        {
            Asin = asin;
            MainDomainId = mainDomainId;
            UpdateInterval = updateInterval < 1 ? 1 : updateInterval;
        }

        /// <summary>
        /// Converts the object to a JSON string.
        /// </summary>
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
