using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_UnitTests_
{
    public class Calculator
    {
        public float SubtractNumbers(float a, float b)
        {
            return a - b;
        }

        public float SumNumbers(float a, float b)
        {
            return a + b;
        }

        public float MultiplyNumbers(float a, float b)
        {
            return a * b;
        }

        public float DivideNumbers(float a, float b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }
}
