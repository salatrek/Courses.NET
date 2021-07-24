using System;

namespace OOPLessons
{
    public class EquilateralTriangle : Triangle
    {
        public EquilateralTriangle(float a, float b, float c) : base(a, b, c)
        {
            if (a == b && b == c)
            {
                Name = "Равносторонний треугольник";
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("Треугольник с данными сторонами не является равносторонним");
            }
        }
    }
}
