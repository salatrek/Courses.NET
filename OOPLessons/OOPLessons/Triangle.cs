using System;

namespace OOPLessons
{
    public class Triangle : Figure, IPerimeterCalculation
    {
        public float a, b, c;

        public Triangle(float a, float b, float c)
        {
            if (a > (b - c) && a < (b + c) && a > 0 && b > 0 && c > 0)
            {
                Name = "Треугольник";
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("Неверно указаны стороны треугольника");
            }
        }
        public float CalculatePerimeter()
        {
            var perimetr = a + b + c;
            return perimetr;
        }

        public override float Square()
        {
            var semi_perimeter = (a + b + c) / 2;
            var square = Math.Sqrt(semi_perimeter * (semi_perimeter - a) * (semi_perimeter - b) * (semi_perimeter - c));
            return (float)square;
        }
    }
}
