using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            Console.WriteLine("1 for start.\n2 for stop.\n3 close the project.");
            stopWatch.Butt = Console.ReadLine();

            while(stopWatch.Butt != "3")
            {
                if (stopWatch.Butt == "1")
                    stopWatch.Start();
                else if (stopWatch.Butt == "2")
                {
                    stopWatch.Stop();
                }
                Console.WriteLine("1 for start.\n2 for stop.\n3 close the project");
                stopWatch.Butt = Console.ReadLine();
            }
        }
    }
}
