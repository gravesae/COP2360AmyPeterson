using System;

//Grade: 10/10 Nice Job
class Program
{
    static void Main(string[] args) // Entry into the application
    {
        Random randomNumbers = new Random(); // Intialize random number generator
        int[] frequency = new int[13]; // Array to store frequency of rolls
        
        for (int rolls = 0; rolls < 36000; ++rolls)  // Perform rolls
        {
            int roll1 = randomNumbers.Next(1, 7); // Roll first die
            int roll2 = randomNumbers.Next(1, 7); // Roll second die
            int sum = roll1 + roll2; // Add dice together
            ++frequency[sum]; // Increment freqency by 1
        }

        Console.WriteLine("{0}{1,10}", "Sum", "Frequency"); // Print out header

        for (int sum = 2; sum < frequency.Length; ++sum) // Iterate through the frequencies
        {
            Console.WriteLine("{0,4}{1,10}", sum, frequency[sum]); // Print frequencies
        }
    } // end Main
} // end class RollDie

