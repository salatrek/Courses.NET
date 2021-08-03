using System;
using System.Collections.Generic;

namespace FourthLesson_Generic__Dictionary_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Figure> figures = new Dictionary<string, Figure>()
            {
                {"Circle", new Figure () { SideCount = 1, SideLenght = 1} },
                {"Square", new Figure () { SideCount = 4, SideLenght = 1}}
            };

            figures.Add("Triangle", new Figure() { SideCount = 3, SideLenght = 1 });

            figures.ContainsKey("Triangle");

            var figure = figures["Triangle"];
            figures["Triangle"] = new Figure() {SideCount = 5, SideLenght = 1 };

            figures.Remove("Triangle");

            foreach (var item in figures)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            foreach (var item in figures.Keys)
            {
                Console.WriteLine($"{item}");
            }

            Console.ReadKey();
        }
    }
}
