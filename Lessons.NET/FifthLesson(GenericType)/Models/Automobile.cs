using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLesson_GenericType_.Models
{
    public class Automobile : ICost
    {
        public string Model { get; set; }
        public long Miles { get; set; }
        public double Cost { get; set; }
    }
}
