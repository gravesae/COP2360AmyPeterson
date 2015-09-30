using System;

namespace ParkingCharges
{
    class Program
    {
        // Entry point into the app
        static void Main(string[] args)
        {
            // Welcome messgae
            Console.WriteLine("How many hours did each customer park? (Example: 4 Hours and 30 minutes = 4.5.)");
            // Ask user for customer 1 parking time
            Console.WriteLine("How many hours did Customer 1 park?");
            // Use double to get convert the inputted time into a decimal then store the time for customer 1
            double time1 = Convert.ToDouble(Console.ReadLine());
            // Calcuate the cost for customer 1
            double cost1 = CalculateCharge(time1);
            // Ask user for customer 2 parking time
            Console.WriteLine("How many hours did Customer 2 park?");
            // Use double to get convert the inputted time into a decimal then store the time for customer 2
            double time2 = Convert.ToDouble(Console.ReadLine());
            // Calcuate the cost for customer 2
            double cost2 = CalculateCharge(time2);
            // Ask user for customer 3 parking time
            Console.WriteLine("How many hours did Customer 3 park?");
            // Use double to get convert the inputted time into a decimal then store the time for customer 3
            double time3 = Convert.ToDouble(Console.ReadLine());
            // Calcuate the cost for customer 3
            double cost3 = CalculateCharge(time3);

            // Return the total cost and time for customer 1
            Console.WriteLine("Total Cost is {0:C} for a total of {1} hours for Customer 1.", cost1, time1);
            // Return the total cost and time for customer 2
            Console.WriteLine("Total Cost is {0:C} for a total of {1} hours for Customer 2.", cost2, time2);
            // Return the total cost and time for customer 3
            Console.WriteLine("Total Cost is {0:C} for a total of {1} hours for Customer 3.", cost3, time3);
            // Insert blank line
            Console.WriteLine();
            // Return the total cost of yesterday's receipts
            Console.WriteLine("Yesterday's total charges = {0:C}", cost1 + cost2 + cost3);
            // Use a read line to keep application open until user is finished
            Console.ReadLine();
        } // End of Main

        // Method for Calculate Charge
        static double CalculateCharge(double time)
        {
            // Variable cost of parking
            double cost; 
            // Convert the decimal of time so it rounds to the next number
            time = Math.Ceiling(time);

            // If statement to determin how to calculate time if it is less than or equal to 3 hours
            if (time <= 3)
            {
                // If time is less than or equal to 3 hours, the cost is $2.00
                cost = 2;
            }
            // Otherwise, use this formula
            else
            {
                // The cost will be $2 plus (.5 times the total time minus the 3 original hours)
                cost = 2 + 0.5 * (time - 3);
            }
            // The cost cannot go over $10
            cost = Math.Min(cost, 10);
            // Return the cost
            return cost;
        } // End of method Calculate Charge
    } // End Class
} // End namespace ParkingCharges
