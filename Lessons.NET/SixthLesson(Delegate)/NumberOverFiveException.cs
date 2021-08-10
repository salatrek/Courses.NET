using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthLesson_Delegate_
{
    class NumberOverFiveException : Exception
    {
        public NumberOverFiveException(string message) : base(message)
        { 
            
        }
    }
}
