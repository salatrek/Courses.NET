using System;

namespace FourthLesson_Generic__Dictionary_
{
    public class Figure
    { 
        public int SideCount { get; set; }
        public int SideLenght { get; set; }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Figure)
            {
                Figure figure = (Figure)obj;
                return SideCount == figure.SideCount && SideLenght == figure.SideLenght;
            }
            else
            {
                return false;
            }

        }
        public override int GetHashCode()
        {
            return SideCount + SideLenght;
        }
    }

}

