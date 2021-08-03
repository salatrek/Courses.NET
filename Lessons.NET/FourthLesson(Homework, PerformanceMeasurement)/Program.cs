using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;

namespace FourthLesson_Homework__PerformanceMeasurement_
{
    [MemoryDiagnoser]
    public class Program
    {
        static void Main(string[] args)
        {
            
            var summary = BenchmarkRunner.Run<BenchmarkClass>();
        }

    }
}
