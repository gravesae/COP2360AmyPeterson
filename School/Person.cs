using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public string Address;
        public string Phone;
        public void DisplayPerson()
        {
            Console.WriteLine("Full Name: {0} {1}", FirstName, LastName);
            Console.WriteLine("Address: {0}", Address);
            Console.WriteLine("Phone Number: {0}", Phone);
        }
    }
}
