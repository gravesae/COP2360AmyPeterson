using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_of_Integers_Assignment_10._8
{
    public class IntegerSet
    {
        public bool[] Values; //Array of bools named Values
        public IntegerSet() //Declare the constructor IntegerSet
        {
            Values = new bool[101]; //Initialize the Values property
        }

        public IntegerSet Union(IntegerSet otherValues)
        {
            IntegerSet set3 = new IntegerSet(); //Declaring a new IntegerSet set3 and initialize it to a new IntegerSet
            for (int i = 0; i < Values.Length; i++) 
            {
                if (Values[i] == true || otherValues.Values[i] == true) //if the value is in either integerSet, include it in the union
                {
                    set3.Values[i] = true;
                }
            }
            return set3;
        }

        public IntegerSet Intersection(IntegerSet otherValues)
        {
            IntegerSet set3 = new IntegerSet(); //Declaring a new IntegerSet set3 and initialize it to a new IntegerSet
            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] == true && otherValues.Values[i] == true) //if the value is in both integerSets, include it in the intersection
                {
                    set3.Values[i] = true;
                }
            }
            return set3;
        }

        public void InsertElement(int k) //Insert a new element into an array
        {
           Values[k] = true;
        }

        public void DeleteElement(int m) //Delete an element from the array
        {
            Values[m] = false;
        }

        public string ToString() //Add values to the string
        {
            string result = "";
            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] == true)
                {
                    result += i + " "; 
                }
            }
            if (result == "")
            {
                result = "---";
            }
            return result;
        }

        public bool IsEqualTo(IntegerSet otherValues)
        {
            for (int i = 0; i < Values.Length; i++)
            {
                if (Values[i] != otherValues.Values[i]) //Determines if the values in the array are equal to one another
                {
                    return false; 
                }
            }
            return true;
        }
    }
}
