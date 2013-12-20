using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeShop.Common
{

    public static class Logger
    {
        //[ThreadStatic]
        /// <summary>
        /// Writes debug message to log
        /// </summary>

        public static void WriteToLog(string message)
        {
            lock (typeof(Logger))
            {
                WriteLineStart();
                WriteLine(message);
            }
        }

        private static void WriteLine(string message)
        {
            Write(message + Environment.NewLine);
        }

        private static void Write(string message, params object[] parameters)
        {
            Write(string.Format(message, parameters));
        }

        private static void Write(string message)
        {
            Console.Write(message);
        }

        private static void WriteLineStart()
        {
            Write("{0} -> ", DateTime.Now);
        }
    }
}
