using System;

class Program
{
    // Main method begins execution of C# app 
    static void Main(string[] args)  
    {
        // Label for (A, B, C) with tabs between each letter to create proper spacing throughout
        Console.WriteLine("(A,\tB,\tC)"); 
        // For loop to loop through all numbers 1-500 for the varible A
        for (int numberA = 1; numberA <= 20; numberA++)
        {
            // For loop to loop through all numbers 1-500 for the varible B
            for (int numberB = 1; numberB <= 20; numberB++)
            {
                // For loop to loop through all numbers 1-500 for the varible C
                for (int numberC = 1; numberC <= 20; numberC++)
                {
                    // Calculate a^2 to calculate the pythagorean theorem a^2 + b^2 = c^2
                    double aSquared = Math.Pow(numberA, 2);
                    // Calculate b^2 to calculate the pythagorean theorem a^2 + b^2 = c^2
                    double bSquared = Math.Pow(numberB, 2);
                    // Calculate c^2 to calculate the pythagorean theorem a^2 + b^2 = c^2
                    double cSquared = Math.Pow(numberC, 2);

                    // If statement to determine if a^2 + b^2 = c^2 where a, b, and c will be a whole number (The Pythagorean Theorem )
                    if (aSquared+bSquared==cSquared)
                    {
                        // Print out the numbers that prove the condition of a^2 + b^2 = c^2
                        Console.WriteLine("({0},\t{1},\t{2})", numberA, numberB, numberC);
                    } // End if statement                       
                } // End the for loop for C
            } // End the for loop for B
        } // End the for loop for A
    }  // End Main
} // End Class
