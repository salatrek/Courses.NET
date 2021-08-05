using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLesson_GenericType_.Models
{
    public class House : ICost
    {
        public string Location { get; set; }
        public int Square { get; set; }
        public double Cost { get; set; }
    }
}
