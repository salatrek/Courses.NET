using System;

namespace OOPLessons
{
    public class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(float a, float b, float c) : base(a, b, c)
        {
            if ((a == b) || (b == c) || (c == a))
            {
                Name = "Равнобедренный треугольник";
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("Треугольник с данными сторонами не является равнобедренным!!!");
            }
        }

    }
}
