// Assignment 3.15 Arithmetic
//Displaying the sum, difference, produce, and quotient of two numbers. 
using System;

//Grade: 10/10 Great  job
public class Arithmetic
    {
        // Main method begins execution of C# app    
        static void Main(string[] args)
        {
            int number1; // declare first number
            int number2; // declare second number
            int sum; // declare sum of number1 and number 2
            int difference; // declare difference of number1 and number 2
            int product; // declare product of number1 and number 2
            int quotient; // declare quotient of number1 and number 2

            Console.Write("Enter first integer: "); //promt user
            // read first number from user
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second integer: "); //promt user
            // read second number from user
            number2 = Convert.ToInt32(Console.ReadLine());

            sum = number1 + number2; // add numbers
            difference = number1 - number2; // subtract numbers
            product = number1 * number2; // multiply numbers
            quotient = number1 / number2; // divide numbers

            Console.WriteLine("Sum is {0}\nDifference is {1}\nProduct is {2}\nQuotient is {3}", sum, difference, product, quotient ); // display sum
            Console.Read();
        } // end Main
    } // end class Arithmetic

