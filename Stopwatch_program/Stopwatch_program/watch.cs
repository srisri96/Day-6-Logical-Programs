using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch_program
{
    internal class watch
    {
        public static void Timing()
        {
            watch stop = new watch();
            Console.WriteLine("Type start");
            String start = Console.ReadLine();
            Console.WriteLine("Started");
            watch.start();                      //Start timing
            Console.WriteLine("Type stop");
            String stop = Console.ReadLine();
            watch.Stop();                        // Stop timing
            Console.WriteLine("Stoped");
            Console.WriteLine("Time Elapsed : " + watch.Elapsed);
            Console.ReadLine();
        }
    }
}
