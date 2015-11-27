using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10_Shape_Hierarchy
{
    class Square : TwoDimensionalShape
    {
        public Square(double length): base(length)
        {
        }

        // Property to get the area
        public override double Area
        {
            // Formula for Area of Square = length^2 
            get { return Math.Pow(base.Length, 2); }
        }

        public override string ToString()
        {
            // Format the ToString method for a square
            return string.Format("Square") + base.ToString();
        }
    }
}
