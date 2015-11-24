using System;
//Grade 9.5/10
//Requirements state to use the smallest array possible, an array of size 4 is sufficient as the 5th input does not have to be stored.
class Program
{
    // Entry point of the application
    static void Main(string[] args)
    {
        // Declare a single dimensional array to store 5 numbers
        int[] array = new int[5];

        // Give user instructions on what to do
        Console.WriteLine("Input 5 numbers from 10-100");

        int i = 0;  // Initialize i
        int j = 0;  // Initialize j
        
        // While loop to get input from users
        while (i < 5)
        {
            // Prompt user for input
            Console.Write("Input number {0}: ", i+1);
            // Get input from user 
            int input = Convert.ToInt32(Console.ReadLine());
            // Ensure number is within the range
            if (input < 10 || input > 100)
            {
                // If the number is not in range, display error
                Console.WriteLine("Please enter a number that is between 10 and 100.");
            }           
            else
            {
                // Check to see if the value has been entered, assume false
                bool contains = false;
                
                // Iterate through the input so far
                for (j = 0; j < i; j++)
                {
                    // Check to see if the input has already been entered into the array
                    if (array[j] == input)
                    {
                        // The value already exists in the array
                        contains = true;
                    }
                }
                // The value does not exist in the array
                if (contains == false)
                {
                    // Store the inputted number into the array
                    array[i] = input;
                }

                // Print out the values of the array
                Console.Write("Values: ");
                // Iterate what has been entered so far
                for (j = 0; j <= i; j++)
                {
                    // If the value is 0, it a duplicate. Skip it.
                    if (array[j] > 0)
                    {
                        // Print out the value
                        Console.Write("{0} ", array[j]);
                    }
                }
                // Print a break line
                Console.WriteLine();
                // Increments i by 1 each time until it reaches 5
                i++;
            }
        } // End the while loop
    } // End Main
} // End class
