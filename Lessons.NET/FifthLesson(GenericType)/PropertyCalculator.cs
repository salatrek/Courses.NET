using FifthLesson_GenericType_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthLesson_GenericType_
{
    class PropertyCalculator <T> where T:ICost
    {
        public double TotalCost { get; set; }

        public void Add<T, U>(T property, U myProp) where T : ICost where U : Animal 
        {
            TotalCost = TotalCost + property.Cost;
        }
    }
}
