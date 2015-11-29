using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Grade 10 - Excellent!
namespace Set_of_Integers_Assignment_10._8
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerSet set1 = new IntegerSet(); //New up the IntegerSet for set1
            IntegerSet set2 = new IntegerSet(); //New up the IntegerSet for set2
            IntegerSet set3 = new IntegerSet(); //New up the IntegerSet for set3
            set1.InsertElement(1); //Set 1 of numbers to test
            set1.InsertElement(2);
            set1.InsertElement(3);
            set1.InsertElement(10);
            set1.InsertElement(5);
            set2.InsertElement(3); //Set 2 of number to test
            set2.InsertElement(4);
            set2.InsertElement(5);
            set2.InsertElement(10);
            set2.InsertElement(12);
            set3.InsertElement(1); //Set 3 of number to test
            set3.InsertElement(2);
            set3.InsertElement(3);
            set3.InsertElement(10);
            set3.InsertElement(5);
            set3.InsertElement(99);

            Console.WriteLine("Set 1: " + set1.ToString()); //Display the ToString method
            Console.WriteLine("Set 2: " + set2.ToString()); //Display the ToString method

            DisplayUnion(set1,set2); //Display Union method
            DisplayIntersection(set1, set2); //Display Intersection method
            DisplayInsertElement(set1); //Display InsertElement method
            DisplayDeleteElement(set2); //Display DeleteElement method
            DisplayEmptyIntegerSet(); //Display EmptyIntegerSet method

            if (!set1.IsEqualTo(set2)) //To test the IsEqualTo method
            {
                Console.WriteLine("Set 1 is NOT equal to Set 2");
            }
            if (set1.IsEqualTo(set3))
            {
                Console.WriteLine("Set 1 is equal to Set 3");
            }
        }
        static void DisplayUnion(IntegerSet set1, IntegerSet set2) //To test Union method
        {
            IntegerSet union = set1.Union(set2);
            Console.WriteLine("Union Method: " + union.ToString());
        }
        static void DisplayIntersection(IntegerSet set1, IntegerSet set2) //To test Intersection method
        {

            IntegerSet intersection = set1.Intersection(set2);
            Console.WriteLine("Intersection Method: " + intersection.ToString());
        }
        static void DisplayInsertElement(IntegerSet set1) //To test InsertElement method
        {
            Console.WriteLine("Before InsertElement in Set 2: " + set1.ToString());
            set1.InsertElement(99);
            Console.WriteLine("After InsertElement in Set 2: " + set1.ToString());
        }
        static void DisplayDeleteElement(IntegerSet set2) //To test DeleteElement method
        {
            Console.WriteLine("Before DeleteElement in Set 2: " + set2.ToString());
            set2.DeleteElement(5);
            Console.WriteLine("After DeleteElement in Set 2: " + set2.ToString());
        }

        static void DisplayEmptyIntegerSet() //To test DisplayEmptyIntegerSet method
        {
            IntegerSet emptySet = new IntegerSet();
            Console.WriteLine("Empty Set: " + emptySet.ToString());
        }

        
    }
}
