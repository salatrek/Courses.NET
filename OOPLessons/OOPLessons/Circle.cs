using System;

namespace OOPLessons
{
    public class Circle : Figure, IPerimeterCalculation
    {
        float radius;

        public Circle(float r)
        {
            if (r > 0)
            {
                Name = "Круг";
                radius = r;
            }
            else
            {
                throw new Exception("Недопустимое значение радиуса!!!");
            }
        }

        public float CalculatePerimeter()
        {
            var perimetr = 2 * 3.14 * radius;
            return (float)perimetr;
        }

        public override float Square()
        {
            var square = 3.14 * radius * radius;
            return (float)square;
        }
    }
}
    

