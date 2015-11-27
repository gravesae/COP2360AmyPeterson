using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10_Shape_Hierarchy
{
    abstract class TwoDimensionalShape : Shape
    {
        public TwoDimensionalShape(double length): base(length)
        {
        }

        // Property to get the area
        public abstract override double Area
        {
            get;
        }

        public override string ToString()
        {
            // Format the ToString method for Two-Dimensional Shape.
            return string.Format(" is a Two-Dimensional Shape");
        }
    }
}
