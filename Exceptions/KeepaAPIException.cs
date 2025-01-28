using System;

namespace Keepa.Api.Backend.Exceptions
{
    /// <summary>
    /// API-Exception thrown on different negative API-Events.
    /// </summary>
    public class KeepaAPIException : Exception
    {
        public KeepaAPIException(string message) : base(message)
        {
        }
    }
}
