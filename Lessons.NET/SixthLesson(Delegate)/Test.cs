using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLesson_Delegate_
{
    public class Test
    {
        public void Devide(int a, int b)
        {
            try
            {
                int c = a / b;
                if (b >= 5)
                {
                    throw new NumberOverFiveException("Чмсло b превысило 5");
                }
            }
            catch (NumberOverFiveException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Блок finaly");
            }
        }
    }
}
