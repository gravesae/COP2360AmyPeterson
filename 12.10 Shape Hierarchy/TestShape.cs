using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10_Shape_Hierarchy
{
    class TestShape
    {
        static void Main(string[] args)
        {
            // Create four-element Shape array
            Shape[] shapes = new Shape[4];

            // Populate array with objects that implement Shape
            shapes[0] = new Square(10); //length of side is 10
            shapes[1] = new Circle(5); //radius is 5
            shapes[2] = new Sphere(5); //radius is 5
            shapes[3] = new Cube(10); //length of side is 10

            // Process each element in array shapes
            foreach (Shape shape in shapes)
            {
                if (shape is TwoDimensionalShape)
                {
                    Console.WriteLine(shape);
                    Console.WriteLine("The area is {0:N} square units.", shape.Area);
                    Console.WriteLine();
                }
                else
                {
                    // Downcast Shape reference to ThreeDimensionalShape
                    ThreeDimensionalShape Shape = (ThreeDimensionalShape)shape;
                    Console.WriteLine(shape);
                    Console.WriteLine("The area is {0:N} square units.", shape.Area);
                    Console.WriteLine("The volume is {0:N} cubic units.", Shape.Volume);
                    Console.WriteLine();
                }
            }
            Console.Read();
        }


    }
}
