using System;

namespace OOPLessons
{
    public class RightTriangle : Triangle
    {
        private bool Validate(float a, float b, float c)
        {
            return (a * a) == (b * b) + (c * c);
        }

        public RightTriangle(float a, float b, float c) : base(a, b, c)
        {


            if (Validate(a, b, c) || Validate(b, a, c) || Validate(c, a, b))
            {
                Name = "Прямоугольный треугольник";
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                throw new Exception("Треугольник с данными сторонами не является  прямоугольным");
            }
        }
    }
}
