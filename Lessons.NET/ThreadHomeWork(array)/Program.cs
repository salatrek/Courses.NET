﻿using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace ThreadHomeWork_array_
{
    internal static class Program
    {
        static double[] array10M = new double[10000000];
        static double[] array100M = new double[100000000];

        public static void Main(string[] args)
        {
            var timer = new Stopwatch();

            Console.WriteLine("\n----------------100M array----------------");
            timer.Start();
            Parallel.For(0, array100M.Length, AssignElement100M);
            timer.Stop();
            Console.WriteLine($"Assigning array (parallel):\t{timer.ElapsedMilliseconds}\tms");

            timer.Restart();
            for (var i = 0; i < array100M.Length; i++)
            {
                AssignElement100M(i);
            }
            timer.Stop();
            Console.WriteLine($"Assigning array (regular):\t{timer.ElapsedMilliseconds}\tms");

            timer.Restart();
            var average100M = array100M.AsParallel().Average();
            timer.Stop();
            Console.WriteLine($"Average counting (parallel):\t{timer.ElapsedMilliseconds}\tms");

            timer.Restart();
            average100M = array100M.Average();
            timer.Stop();
            Console.WriteLine($"Average counting (regular):\t{timer.ElapsedMilliseconds}\tms");

            Console.WriteLine("\n----------------10M array----------------");
            timer.Restart();
            Parallel.For(0, array10M.Length, AssignElement10M);
            timer.Stop();
            Console.WriteLine($"Assigning array (parallel):\t{timer.ElapsedMilliseconds}\tms");

            timer.Restart();
            for (var i = 0; i < array10M.Length; i++)
            {
                AssignElement10M(i);
            }
            timer.Stop();
            Console.WriteLine($"Assigning array (regular):\t{timer.ElapsedMilliseconds}\tms");

            timer.Restart();
            var average10M = array10M.AsParallel().Average();
            timer.Stop();
            Console.WriteLine($"Average counting (parallel):\t{timer.ElapsedMilliseconds}\tms");

            timer.Restart();
            average10M = array10M.Average();
            timer.Stop();
            Console.WriteLine($"Average counting (regular):\t{timer.ElapsedMilliseconds}\tms");

            Console.WriteLine();
        }

        private static void AssignElement10M(int x)
        {
            array10M[x] = x;
        }

        private static void AssignElement100M(int x)
        {
            array100M[x] = x;
        }
    }

}