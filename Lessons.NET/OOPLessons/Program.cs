using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            var figuresCountingPerimeter = new List<IPerimeterCalculation>();
            var listOfFigures = new List<Figure>();

            try
            {
                figuresCountingPerimeter.Add(new Circle(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                figuresCountingPerimeter.Add(new RightTriangle(3, 4, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                listOfFigures.Add(new Quadrate(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                listOfFigures.Add(new Circle(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                listOfFigures.Add(new Triangle(5, 9, 12));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                listOfFigures.Add(new EquilateralTriangle(6, 6, 6));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                listOfFigures.Add(new IsoscelesTriangle(5, 6, 6));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                listOfFigures.Add(new RightTriangle(3, 4, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            DisplayFigures(listOfFigures);

            Console.WriteLine("Колличество фигур: " + listOfFigures.Count);

            Console.ReadKey();

        }

        public static void DisplayFigures(List<Figure> figuresCollection)
        {
            if (figuresCollection == null)
            {
                Console.WriteLine("Список фигур пуст.");
                return;
            }

            foreach (var figure in figuresCollection)
            {
                if (figure != null)
                {

                    
                    if (figure is IPerimeterCalculation perimeterCalculated)
                    {
                        var perimeter = perimeterCalculated.CalculatePerimeter();
                        Console.WriteLine($"{figure.Name}, площадь = {figure.Square()}, периметр = {perimeter}\n ");
                    }
                    else
                    {
                        Console.WriteLine($"{figure.Name}, площадь = {figure.Square()}\n ");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Неверные параметры фигуры"); ;
                }
            }
        }

    }

}
