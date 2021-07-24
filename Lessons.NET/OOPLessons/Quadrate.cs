using System;

namespace OOPLessons
{
    public class Quadrate : Figure
    {

        float a;

        public Quadrate(float a)
        {
            if (a > 0)
            {
                Name = "Квадрат";
                this.a = a;
            }
            else
            {
                throw new Exception("Фигура с данной стороной не является квадратом");
            }
        }

        public override float Square()
        {
            var s = a * a;
            return s;
        }
    }
}
    

