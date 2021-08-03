using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Collections.Generic;


namespace FourthLesson_Homework__PerformanceMeasurement_
{
    public class BenchmarkClass
    {
        static Figure figure;
        static List<Figure> listOfFigures;
        static Dictionary<Figure, int> dictionaryOfFigures;

        public void Process()
        {
            figure = new Figure() { SideCount = 3, SideLenght = 4 };

            listOfFigures = new List<Figure>();
            dictionaryOfFigures = new Dictionary<Figure, int>();

            for (int i = 0; i < 1000; i++)
            {
                listOfFigures.Add(new Figure() { SideCount = i, SideLenght = i + 1 });
                dictionaryOfFigures.Add(new Figure() { SideCount = i, SideLenght = i + 1 }, i);

            }
        }
        [Benchmark]
        public void ListMeasurement()
        {
            Process();
            
            for (int i = 0; i < 10000; i++)
            {
                listOfFigures.Contains(figure);
            }
        }

        [Benchmark]
        public void DictionaryMeasurement()
        {
            Process();

            for (int i = 0; i < 10000; i++)
            {
                dictionaryOfFigures.ContainsKey(figure);
            }
        }
    }

}
