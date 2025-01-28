using System;
using System.Threading;

namespace Keepa.Api.Backend.Helper
{
    /// <summary>
    /// HelperFactory to name ThreadPool-Threads for debugging purposes.
    /// </summary>
    public class BasicNameFactory : IThreadFactory
    {
        private readonly string _namingPattern;
        private int _count = 0;

        public BasicNameFactory(string namingPattern)
        {
            _namingPattern = namingPattern;
        }

        public Thread NewThread(ThreadStart start)
        {
            var thread = new Thread(start);
            if (!string.IsNullOrEmpty(_namingPattern))
            {
                thread.Name = string.Format(_namingPattern, Interlocked.Increment(ref _count) - 1);
            }

            return thread;
        }
    }

    public interface IThreadFactory
    {
        Thread NewThread(ThreadStart start);
    }
}
