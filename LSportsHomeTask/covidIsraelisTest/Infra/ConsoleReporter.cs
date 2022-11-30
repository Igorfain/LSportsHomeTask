using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSportsHomeTask.covidIsraelisTest.Infra
{
    public class ConsoleReporter
    {
        public static void Log(string message)
        {
            Console.WriteLine(DateTime.Now.ToString("[HH:mm:ss] ") + message + "\n");
#if DEBUG
            Debug.WriteLine(DateTime.Now.ToString("[HH:mm:ss] ") + message + "\n");
#endif
        }
    }
}
