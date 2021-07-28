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
            double boxingTime = 0;
            double unboxingTime = 0;
            for (int i = 0; i < 1000; i++)
            {
                boxingTime += Boxing();

                unboxingTime += Unboxing();
            }

            Console.WriteLine($"Время упаковки: {boxingTime}    Время распаковки: {unboxingTime}");
            
            Console.ReadLine();
        }
        private static double Boxing()
        {
            Stopwatch stopwatch = new Stopwatch();

            int a = 25;
            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                object b = a;
            }
            stopwatch.Stop();
            
            var time_spent = stopwatch.Elapsed.TotalMilliseconds;
            //Console.WriteLine("Время упаковки: " + time_spent);
            return time_spent;
            
        }
        private static double Unboxing()
        {
            Stopwatch stopwatch = new Stopwatch();

            object c = 25;
            stopwatch.Start();
            for (int i = 0; i < 1000000; i++)
            {
                int d = (int)c;
            }
            stopwatch.Stop();

            var time_spent = stopwatch.Elapsed.TotalMilliseconds;
            //Console.WriteLine("Время распаковки: " + time_spent);

            return time_spent;
        }


    }
}
