using System;

namespace Keepa.Api.Backend.Helper
{
    /// <summary>
    /// Keepa Time - Unix Time Converter Helper Class
    /// </summary>
    public static class KeepaTime
    {
        public static readonly long KeepaStartHour = 359400;
        public static readonly long KeepaStartMinute = 21564000;

        public static int NowHours()
        {
            return UnixInMillisToKeepaHour(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
        }

        public static int NowMinutes()
        {
            return UnixInMillisToKeepaMinutes(DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
        }

        public static int UnixInMillisToKeepaMinutes(long unix)
        {
            return (int)(Math.Floor(unix / (60 * 1000.0)) - KeepaStartMinute);
        }

        public static int UnixInMillisToKeepaHour(long unix)
        {
            return (int)(Math.Floor(unix / (60 * 60 * 1000.0)) - KeepaStartHour);
        }

        public static long KeepaHourToUnixInMillis(int hour)
        {
            return hour * 60 * 60 * 1000L + KeepaStartHour * 60 * 60 * 1000L;
        }

        public static long KeepaMinuteToUnixInMillis(int minute)
        {
            return minute * 60 * 1000L + KeepaStartMinute * 60 * 1000L;
        }

        public static long KeepaMinuteToUnixInMillis(string minute)
        {
            return KeepaMinuteToUnixInMillis(int.Parse(minute));
        }
    }
}
