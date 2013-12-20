using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace FreeShop.Common
{

    public static class ConsoleManager
    {
        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", CharSet = CharSet.Unicode)]
        private static extern bool AllocConsole();

        public static void InitializeConsoleManager()
        {
            try
            {
              AllocConsole();
              Console.SetOut(//new TextWriter
                                            (new StreamWriter(Console.OpenStandardOutput(), Encoding.Default, 100)));

                
              Console.Clear();
              Console.WriteLine("ALEX");
            }
            catch (Exception)
            {
            }
        }


        public static void EventLogerInit()
        {
            if (!EventLog.SourceExists("MySource"))
            {
                //An event log source should not be created and immediately used.
                //There is a latency time to enable the source, it should be created
                //prior to executing the application that uses the source.
                //Execute this sample a second time to use the new source.
                EventLog.CreateEventSource("MySource", "MyNewLog");
                Console.WriteLine("CreatedEventSource");
                Console.WriteLine("Exiting, execute the application a second time to use the source.");
                // The source is created.  Exit the application to allow it to be registered.
                return;
            }

        }
    }

}
