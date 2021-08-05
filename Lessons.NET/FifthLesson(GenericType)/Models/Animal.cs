using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLesson_GenericType_.Models
{
    public class Animal : ICost
    {
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
