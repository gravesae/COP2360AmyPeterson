using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10_Shape_Hierarchy
{
    class Sphere : ThreeDimensionalShape
    {
        public Sphere(double length) : base(length)
        {
        }

        // Property to get the area
        public override double Area
        {
            // Formula for Surface Area of Sphere = 4*Pi*r^2 (substitute length for radius)
            get { return 4 * Math.PI * Math.Pow(Length, 2); }
        }

        // Property to get the volume
        public override double Volume
        {
            // Formula for Volume of Sphere = 4/3*Pi*r^3
            get { return (4 * Math.PI * Math.Pow(Length, 3)/3); }
        }

        public override string ToString()
        {
            // Format the ToString method for a sphere
            return string.Format("Sphere") + base.ToString();
        }
    }
}
