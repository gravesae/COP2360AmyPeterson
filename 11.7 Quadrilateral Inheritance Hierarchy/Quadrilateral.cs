using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade:10/10 Excellent!
//Observations
//Coordinate is a great use of classes for code reuse and maintainability, nice job
namespace _11._7_Quadrilateral_Inheritance_Hierarchy
{
    abstract class Quadrilateral
    {
        // class level variables
        public Coordinate A;
        public Coordinate B;
        public Coordinate C;
        public Coordinate D;

        public Quadrilateral()
        {
            // new up the variables
            A = new Coordinate();
            B = new Coordinate();
            C = new Coordinate();
            D = new Coordinate();
        }

        // method to initialize the variables
        public void Initialize(Coordinate a, Coordinate b, Coordinate c, Coordinate d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        // overload the method so each point can taken in the pair of numberes that create the Coordinate
        public void Initialize(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {            
            A = new Coordinate(x1, y1);
            B = new Coordinate(x2, y2);
            C = new Coordinate(x3, y3);
            D = new Coordinate(x4, y4);
        }

        public abstract double Area();        
    }
    class Coordinate 
    {
        public double X;
        public double Y;
        public Coordinate()
        {

        }
        public Coordinate(double x, double y) 
        {
            X = x;
            Y = y;
        }
        
        // override the ToString method to print out the variables in the (x,y) format
        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y); 
        }

    }
    class Trapezoid : Quadrilateral
    {
        public override double Area()
        {
            // Formula for the distance between to Coordinates - Square Root((x2 - x1)^2 + (y2-y1)^2)
            // Base1
            double lengthSideAB = Convert.ToDouble(Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y)));
            // Base2
            double lengthSideCD = Convert.ToDouble(Math.Sqrt((C.X - D.X) * (C.X - D.X) + (C.Y - D.Y) * (C.Y - D.Y)));
            // Height
            double height = C.Y - B.Y;
            // Formula = ((Base1 + Base2) * height)/2
            return ((lengthSideAB + lengthSideCD) * height) / 2;
        }
    }
    class Parallelogram : Quadrilateral
    {
        public override double Area()
        {
            // Formula for the distance between to Coordinates - Square Root((x2 - x1)^2 + (y2-y1)^2)
            // Length of base
            double lengthSideAB = Convert.ToDouble(Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y)));
            // Calculate the height of the parallelogram
            double height = C.Y - B.Y;
            // Formula is base * height
            return lengthSideAB * height;
        }
    }
    class Rectangle : Parallelogram
    {
        public override double Area()
        {
            // Formula for the distance between to Coordinates - Square Root((x2 - x1)^2 + (y2-y1)^2)
            // Length of base
            double lengthSideAB = Convert.ToDouble(Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y)));
            // Length of height
            double lengthSideBC = Convert.ToDouble(Math.Sqrt((C.X - B.X) * (C.X - B.X) + (C.Y - B.Y) * (C.Y - B.Y)));
            // Formula is base * height
            return lengthSideAB * lengthSideBC;
        }
    }
    class Square : Rectangle
    {
        public override double Area()
        {
            // Formula for the distance between to Coordinates - Square Root((x2 - x1)^2 + (y2-y1)^2)
            // Length of base
            double lengthSideAB = Convert.ToDouble(Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y)));
            // Formula is base^2
            return lengthSideAB * lengthSideAB;
        }
    }
}
