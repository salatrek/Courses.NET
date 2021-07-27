using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondLesson_ValueType__Structure_
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure firstFigure = new Figure() { NumbersOfFaces = 5, FaceLength = 7};

            var figure1 = CalculateArea(firstFigure);
            var figure2 = CalculateAreaWithAppropriation(firstFigure);

            Console.WriteLine(figure2.FigureArea);
            Console.WriteLine(figure1.Equals(firstFigure));

            Console.ReadKey();
        }

        public static Figure CalculateArea(Figure figure)
        {
            var facesLenght = figure.FaceLength;
            var numbersOfFaces = figure.NumbersOfFaces;

            figure.FigureArea = (numbersOfFaces * (float)Math.Pow(facesLenght, 2)) / (4 * (float)Math.Tan(180 / numbersOfFaces));

            Figure secondFigure = new Figure() { NumbersOfFaces = numbersOfFaces, FaceLength = facesLenght };
            secondFigure.FigureArea = figure.FigureArea;

            return secondFigure;

        }

        public static Figure CalculateAreaWithAppropriation(Figure figure)
        {
            var facesLenght = figure.FaceLength;
            var numbersOfFaces = figure.NumbersOfFaces;

            figure.FigureArea = (numbersOfFaces * (float)Math.Pow(facesLenght, 2)) / (4 * (float)Math.Tan(180 / numbersOfFaces));

            //Figure secondFigure = new Figure(facesLenght, numbersOfFaces);

            Figure secondFigure = figure;
            figure.FigureArea = 15;

            return secondFigure;
        }
    
}
}
