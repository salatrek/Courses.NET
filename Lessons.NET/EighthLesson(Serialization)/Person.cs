using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EighthLesson_Serialization_
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person NextPerson { get; set; }
    }
}
