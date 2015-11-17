using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10_Shape_Hierarchy
{
    abstract class ThreeDimensionalShape : Shape
    {
        public ThreeDimensionalShape(double length) : base(length)
        {
        }

        // Property to get the area
        public abstract override double Area
        {
            get;
        }

        // Property to get the volume
        public abstract double Volume
        {
            get;
        }

        // Format the ToString method for Three-Dimensional Shape
        public override string ToString()
        {
            return string.Format(" is a Three-Dimensional Shape");
        }
    }
}
