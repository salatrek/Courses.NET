using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var timeSpent = Boxing();

            Unboxing();

            Console.ReadLine();
        }
        private static double Boxing()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                int a = 25;
                object b = a;
            }
            stopwatch.Stop();
            
            var time_spent = stopwatch.Elapsed.TotalMilliseconds;
            Console.WriteLine("Время упаковки: " + time_spent);
            return time_spent;
        }
        private static void Unboxing()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                object b = 5;
                int c = (int)b;
            }
            stopwatch.Stop();

            var UnBoxing = stopwatch.Elapsed.TotalMilliseconds;
            Console.WriteLine("Время распаковки: " + UnBoxing);
        }


    }
}
