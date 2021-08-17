using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EighthLesson_Extensions_
{
    public static class IntExtension
    {
        public static TimeSpan Second(this int time)
        {
            return TimeSpan.FromSeconds(time);
        }
    }
}
