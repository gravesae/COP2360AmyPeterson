using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._7_Quadrilateral_Inheritance_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Trapezoid t = new Trapezoid();
            Parallelogram p = new Parallelogram();
            Rectangle r = new Rectangle();
            Square s = new Square();

            t.Initialize(0, 0, 10, 0, 8, 5, 5, 5);
            Console.WriteLine("Coordinates of the Trapezoid: A{0}, B{1}, C{2}, D{3}", t.A, t.B, t.C, t.D);
            Console.WriteLine("The foruma for for Area of Trapezoid is Area = ((base1 +base2)*height)2,\nwhere the base is Side AB and height is the difference in the y coordinates of Side BC.");
            Console.WriteLine("The area of the Parallelogram is {0} square units.", t.Area());
            Console.WriteLine();

            p.Initialize(0, 0, 10, 0, 15, 10, 5, 10);
            Console.WriteLine("Coordinates of the Parallelogram: A{0}, B{1}, C{2}, D{3}", p.A, p.B, p.C, p.D);
            Console.WriteLine("The foruma for for Area of Parallelogram is Area = base * height, \n where the base1 is Side AB, base2 is Side CD and height is the difference in the y coordinates of Side BC.");
            Console.WriteLine("The area of the Parallelogram is {0} square units.", p.Area());
            Console.WriteLine();

            r.Initialize(0, 0, 15, 0, 15, 10, 0, 10);
            Console.WriteLine("Coordinates of the Rectangle: A{0}, B{1}, C{2}, D{3}", r.A, r.B, r.C, r.D);
            Console.WriteLine("The forumula for Area of Rectangle is Area = base * height, \n where the base is Side AB and height is side BC.");
            Console.WriteLine("The area of the Rectangle is {0} square units.",r.Area());
            Console.WriteLine();

            s.Initialize(0, 0, 15, 0, 15, 15, 0, 15);
            Console.WriteLine("Coordinates of the Square: A{0}, B{1}, C{2}, D{3}", s.A, s.B, s.C, s.D);
            Console.WriteLine("The formula for Area of Square is Area = base^2, \n where side base is Side AB.");
            Console.WriteLine("Area of the Square = {0} square units.", r.Area());
        }
    }

}
