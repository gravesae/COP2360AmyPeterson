// 3.31 Calculating BMI
using System;


public class Program
{
    static void Main(string[] args) // Main method begins execution of C# app  
    {
        int weight; // Weight in pounds
        int height; // Height in inches
        int BMI; // Calcuation of body mass index(BMI)

        Console.Write("What is your weight in pounds? "); // Prompt user for weight
        weight = Convert.ToInt32(Console.ReadLine()); // Read weight from user
            
        Console.Write("What is your height in inches? "); // Prompt user for height
        height = Convert.ToInt32(Console.ReadLine()); // Read height from user

        BMI = (weight * 703) / (height * height); // Formula for calulating BMI

        Console.WriteLine("Your Body Mass Index (BMI) is {0}%.", BMI); // Display the BMI
        Console.WriteLine(); // Line break
        Console.WriteLine("BMI VALUES"); // Title 
        // What the percentages mean from the Department of Health and Human Services/National Institutes of Health
        Console.WriteLine("Underweight:\tless that 18.5"); // Underweight Percentages with \t to make one tab
        Console.WriteLine("Normal:\t\tbetween 18.5 and 24.9"); // Normal Percentages with \t to make two tabs
        Console.WriteLine("Overweight:\tbetween 25 and 29.9"); // Overweight Percentages with \t to make one tab
        Console.WriteLine("Obese:\t\t30 or greater"); // Obese Percentages with \t\t to make two tabs
        
        Console.Read(); // Pause the execution of the program, so the user has time to read results.
    } // End Main
} // End Class

