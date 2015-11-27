using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.FirstName = "Amy";
            student.LastName = "Peterson";
            student.Address = "123 Sesame St., Orlando, FL 33222";
            student.Phone = "555-555-5555";
            student.GPA = "4.0";
            student.Major = "Computer programming";
            student.GradudationDate = "Summer 2016";
            Console.WriteLine("Student Information");
            student.DisplayStudent();
            Console.WriteLine();
            
            Employee employee = new Employee();
            employee.FirstName = "Bob";
            employee.LastName = "Bobberson";
            employee.Address = "100 School St., Orlando, FL 33222";
            employee.Phone = "555-555-5000";
            employee.EmployeeID = 2135625;
            employee.Department = "Information Technology";
            Console.WriteLine("Employee Information");
            employee.DisplayEmployee();
            Console.WriteLine();

            Instructor instructor = new Instructor();
            instructor.FirstName = "Joe";
            instructor.LastName = "Josephson";
            instructor.Address = "100 School St., Orlando, FL 33222";
            instructor.Phone = "555-555-5001";
            instructor.EmployeeID = 2135501;
            instructor.Department = "Information Technology";
            instructor.officeNumber = 305;
            instructor.hours = "Monday & Wednesday 9:00 AM - 11:00 AM";
            Console.WriteLine("Instructor Information");
            instructor.DisplayInstructor();
            Console.WriteLine();
        }
    }
}
