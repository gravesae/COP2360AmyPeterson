using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10_Shape_Hierarchy
{
    public abstract class Shape
    {
        public Shape (double sideLength)
        {
            Length = sideLength;
        }

        // Property to get the length of the side.
        public double Length { get; set; }
        
        // Property to get the area.
        public abstract double Area { get; }

        public override string ToString()
        {
            return "";
        }
    }
}
