using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class Logger
    {
        private static readonly Logger _logger = null;
        private static object padLock = new object();

        private Logger()
        {
        }

        //public static Logger Instance
        //{
        //    get
        //    {
        //        if (_logger == null)
        //        {
        //            lock (padLock)
        //            {
        //                if (_logger == null)
        //                {
        //                    return new Logger();
        //                }
        //            }
        //        }
        //        return _logger;
        //    }
        //}

        private static readonly Lazy<Logger> lazy = new Lazy<Logger>(() => new Logger());
        public static Logger Instance => lazy.Value;

        public void Log(string message)
        {
            Console.WriteLine($"An exception occured:=> {message}");
        }
    }
}
