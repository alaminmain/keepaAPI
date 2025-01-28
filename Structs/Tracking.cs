using System;
using Newtonsoft.Json;

namespace keepaAPI.Structs
{
    /// <summary>
    /// Represents a Tracking Object
    /// </summary>
    public class Tracking
    {
        /// <summary>
        /// The tracked product ASIN.
        /// </summary>
        public string Asin { get; set; }

        /// <summary>
        /// Creation date of the tracking in Keepa Time minutes.
        /// </summary>
        public int CreateDate { get; set; }

        /// <summary>
        /// Time to live in hours until the tracking expires.
        /// </summary>
        public int Ttl { get; set; }

        /// <summary>
        /// Trigger a notification if tracking expires or is removed.
        /// </summary>
        public bool ExpireNotify { get; set; }

        /// <summary>
        /// The main Amazon locale of this tracking.
        /// </summary>
        public byte MainDomainId { get; set; }

        /// <summary>
        /// Contains all settings for price or value related tracking criteria.
        /// </summary>
        public TrackingThresholdValue[] ThresholdValues { get; set; }

        /// <summary>
        /// Contains specific, meta tracking criteria like out of stock.
        /// </summary>
        public TrackingNotifyIf[] NotifyIf { get; set; }

        /// <summary>
        /// Determines the notification channels used.
        /// </summary>
        public bool[] NotificationType { get; set; }

        /// <summary>
        /// A history of past notifications of this tracking.
        /// </summary>
        public int[] NotificationCSV { get; set; }

        /// <summary>
        /// A tracking-specific rearm timer.
        /// </summary>
        public int IndividualNotificationInterval { get; set; }

        /// <summary>
        /// Whether or not the tracking is active.
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// The update interval in hours.
        /// </summary>
        public int UpdateInterval { get; set; }

        /// <summary>
        /// The metadata for this tracking.
        /// </summary>
        public string MetaData { get; set; }

        /// <summary>
        /// Available notification channels.
        /// </summary>
        public enum NotificationTypeEnum
        {
            EMAIL,
            TWITTER,
            FACEBOOK_NOTIFICATION,
            BROWSER,
            FACEBOOK_MESSENGER_BOT,
            API,
            MOBILE_APP,
            DUMMY
        }

        /// <summary>
        /// The cause that triggered a notification.
        /// </summary>
        public enum TrackingNotificationCause
        {
            EXPIRED,
            DESIRED_PRICE,
            PRICE_CHANGE,
            PRICE_CHANGE_AFTER_DESIRED_PRICE,
            OUT_STOCK,
            IN_STOCK,
            DESIRED_PRICE_AGAIN
        }

        /// <summary>
        /// Available notification meta trigger types.
        /// </summary>
        public enum NotifyIfType
        {
            OUT_OF_STOCK,
            BACK_IN_STOCK
        }

        /// <summary>
        /// Represents a desired price tracking threshold value.
        /// </summary>
        public class TrackingThresholdValue
        {
            public TrackingThresholdValue(byte domain, int csvType, int thresholdValue, bool isDrop, int? minDeltaAbsolute, int? minDeltaPercentage, bool? deltasAreBetweenNotifications)
            {
                ThresholdValue = thresholdValue;
                IsDrop = isDrop;
                Domain = domain;
                CsvType = csvType;
                MinDeltaAbsolute = minDeltaAbsolute;
                MinDeltaPercentage = minDeltaPercentage;
                DeltasAreBetweenNotifications = deltasAreBetweenNotifications ?? false;
            }

            /// <summary>
            /// The history of threshold values.
            /// </summary>
            public int[] ThresholdValueCSV { get; set; }

            /// <summary>
            /// The threshold value.
            /// </summary>
            public int ThresholdValue { get; set; }

            /// <summary>
            /// The domain ID.
            /// </summary>
            public byte Domain { get; set; }

            /// <summary>
            /// The CSV type.
            /// </summary>
            public int CsvType { get; set; }

            /// <summary>
            /// Whether the tracking threshold tracks value drops.
            /// </summary>
            public bool IsDrop { get; set; }

            public int? MinDeltaAbsolute { get; set; }
            public int? MinDeltaPercentage { get; set; }
            public bool DeltasAreBetweenNotifications { get; set; }
        }

        /// <summary>
        /// Represents a notification trigger condition.
        /// </summary>
        public class TrackingNotifyIf
        {
            public TrackingNotifyIf(byte domain, int csvType, NotifyIfType notifyIfType)
            {
                Domain = domain;
                CsvType = csvType;
                NotifyIfType = (int)notifyIfType;
            }

            public byte Domain { get; set; }
            public int CsvType { get; set; }
            public int NotifyIfType { get; set; }
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
