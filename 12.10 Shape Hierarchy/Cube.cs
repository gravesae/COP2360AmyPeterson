using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10_Shape_Hierarchy
{
    class Cube : ThreeDimensionalShape
    {
        public Cube(double length) : base(length)
        {
        }

        // Property to get the area
        public override double Area
        {
            // Formula for Surface Area of Cube = (length^2)*6
            get { return Math.Pow(base.Length,2) * 6; }
        }

        // Property to get the volume
        public override double Volume
        {
            // Formula for Volume of Cube = (length^3)            
            get { return Math.Pow(base.Length, 3); }
        }

        public override string ToString()
        {
            // Format the ToString method for a cube
            return string.Format("Cube") + base.ToString();
        }
    }
}
