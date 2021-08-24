using FifthLesson_GenericType_.Models;
using System;

namespace FifthLesson_GenericType_
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientCat = new Animal() { Cost = 1 };
            var clientAutomobile = new Automobile() { Cost = 1000 };
            var clientHouse = new House() { Cost = 100000 };

            var propertyCalculator = new PropertyCalculator<ICost>();
            
            //propertyCalculator.Add<ICost>(clientCat);
            //propertyCalculator.Add(clientAutomobile);

            Console.WriteLine(propertyCalculator.TotalCost);
        }
    }
}
