using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Employee : Person
    {
        public int EmployeeID;
        public string Department;
        public void DisplayEmployee()
        {
            DisplayPerson();
            Console.WriteLine("Employee ID: {0}", EmployeeID);
            Console.WriteLine("Department: {0}", Department);
        }
    }
}
