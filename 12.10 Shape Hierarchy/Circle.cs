using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10_Shape_Hierarchy
{
    class Circle : TwoDimensionalShape
    {
        public Circle(double length) : base(length)
        {
        }

        // Property to get the area
        public override double Area
        {
            // Formula for Area of Circle = Pi * r^2 (substitue length for radius)
            get { return Math.PI * Math.Pow(Length, 2); }
        }

        public override string ToString()
        {
            // Format the ToString method for a circle
            return string.Format("Circle") + base.ToString();
        }
    }
 }
