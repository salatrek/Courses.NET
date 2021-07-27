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

            CreateFigure(figuresCountingPerimeter, new Circle(5));
            CreateFigure(figuresCountingPerimeter, new RightTriangle(3, 4, 5));

            CreateFigure(listOfFigures, new Quadrate(5));
            CreateFigure(listOfFigures, new Triangle(5, 9, 12));
            CreateFigure(listOfFigures, new EquilateralTriangle(6, 6, 6));
            CreateFigure(listOfFigures, new IsoscelesTriangle(5, 6, 6));
            CreateFigure(listOfFigures, new RightTriangle(3, 4, 5));
            CreateFigure(listOfFigures,new Circle(5));
            
            DisplayFigures(listOfFigures);

            Console.WriteLine("Колличество фигур: " + listOfFigures.Count);

            Console.ReadKey();

        }

        public static void CreateFigure(List<Figure> listOfFigures, Figure figure)
        {
            try
            {
                listOfFigures.Add(figure);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void CreateFigure(List<IPerimeterCalculation> figuresCountingPerimeter, IPerimeterCalculation figure)
        {
            try
            {
                figuresCountingPerimeter.Add(figure);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
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
