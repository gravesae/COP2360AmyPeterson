using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Instructor : Employee
    {
        public int officeNumber;
        public string hours;
        public void DisplayInstructor()
        {
            DisplayEmployee();
            Console.WriteLine("Office Number: {0}", officeNumber);
            Console.WriteLine("Office Hours: {0}", hours);
        }
    }
}
