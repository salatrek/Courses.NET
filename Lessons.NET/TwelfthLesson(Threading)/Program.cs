using System;
using System.Threading;

namespace TwelfthLesson_Threading_
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Thread(PrintX);
            t.Start();
            
            
            while (true)
            {
                Console.WriteLine("Y");
                Thread.Sleep(500);
            }
        }

        private static void PrintX()
        {
            while (true)
            {
                Console.WriteLine("X");
                Thread.Sleep(500);
            }
        }
    }
}
