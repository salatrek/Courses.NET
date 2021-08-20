using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinethLesson_Reflection_
{
    public class Figure
    {
        public string Name { get; set; }
        public int SideCount { get; set; }
        public double SideLenght { get; set; }

        public Figure()
        { }

        public void Display(string name)
        {
            Console.WriteLine(name);
        }
    }
}
