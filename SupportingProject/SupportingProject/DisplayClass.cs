using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportingProject
{
    class DisplayClass
    {
        private int Number { get; }
        private string Name { get; }

        private int testField;

        public DisplayClass()
        {
            Number = 15;
            Name = "Вспомогательный класс";
            testField = 20;
        }
        
        
        public void Display(string word)
        {
            Console.WriteLine(word + " new");
        }
    }
}
