using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Student : Person
    {
        public string GPA;
        public string Major;
        public string GradudationDate;
        public void DisplayStudent()
        {
            DisplayPerson();
            Console.WriteLine("GPA: {0}", GPA);
            Console.WriteLine("Major: {0}", Major);
            Console.WriteLine("Graduation Date: {0}", GradudationDate);
        }
    }
}
