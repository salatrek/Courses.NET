using System;

namespace FourthLesson_ClassWork_
{
    public class Currency
    {
        public double Rate { get; set; }

        public Currency(double rate)
        {
            Rate = rate <= 0 ? throw new ArgumentNullException(nameof(rate)) : rate;
        }
        
    }
}
