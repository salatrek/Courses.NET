using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdLesson_Homework_Equals_GetHashCode_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Пробная строка";
            string text2 = "Пробная строка";
            string text3 = "Пробная другая строка";
            string text4 = text1;

            bool result1 = text1 == text2;
            bool result2 = text1 == text3;
            bool result3 = text1 == text4;

            Person person1 = new Person("Mospan Alexey Alexandrovich", new DateTime(1996, 03, 27), "Tiraspol", 584);
            Person person2 = new Person("Mospan Anna Pavlovna", new DateTime(1992, 09, 06), "Tiraspol", 589);
            Person person3 = new Person("Mospan Alexey Alexandrovich", new DateTime(1996, 03, 27), "Tiraspol", 584);
            Person person4 = new Person("Mospan Elena Petrovna", new DateTime(1975, 04, 15), "Bendery", 584);
            Person person5 = new Person("Mospan Elena Petrovna", new DateTime(1975, 04, 15), "Bendery", 723);

            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person1.GetHashCode());
            Console.WriteLine(person4.GetHashCode());
            Console.WriteLine(person4.GetHashCode());
            Console.WriteLine(person5.GetHashCode());
            Console.WriteLine(person5.GetHashCode());
            Console.WriteLine(person3.GetHashCode());
            Console.WriteLine(person3.GetHashCode());

            Console.WriteLine(person1.Equals(person2));
            Console.WriteLine(person1.Equals(person3));
            Console.WriteLine(person1.Equals(person4));
            Console.WriteLine(person1.Equals(person5));
            Console.WriteLine(person4.Equals(person5));

            Console.ReadKey();
        }


    }
}
