using System;

//Grade 10/10 - Excellent!
namespace GuessTheNumberGame
{
    class Program
    {
        // Enter into the app
        static void Main(string[] args)
        {
            // Random number generator
            Random randomNumber = new Random();
            // Create boolean to determine if game is playing or not
            bool isPlaying = true;
            // Create while loop to allow users to continue to multiple games if they wish
            while (isPlaying)
            {
                // Display Welcome Message
                Console.WriteLine("Welcome to Guess a Number!");
                // Generate random number 1-1000
                int randomValue = randomNumber.Next(1, 1001);

                // Create boolean to allow users to continue to guess
                bool isGuessing = true;
                // Crate while loop to allow user to have multiple guesses for the number generated above
                while (isGuessing)
                {
                    // Prompt the user to guess number between 1-1000
                    Console.WriteLine("Enter a number 1 through 1000.");
                    // Get input from user
                    int number = Convert.ToInt32(Console.ReadLine());
                    // Display result: if correct, congratulations 
                    if (number == randomValue)
                    {
                        // User is done guessing so set boolean to false so the isGuessing loop will stop running
                        isGuessing = false;
                        // Tell user they have won
                        Console.WriteLine("Congratulations! You are a winner!");
                        // Ask if they want to play again
                        Console.WriteLine("Do you want to play again? Y/N");
                        // Get yes or no
                        string input = Console.ReadLine();
                        // Create an if statement to determine if user is going to continue to play
                        if (input != "y")
                        {
                            // Stop user from playing from continuing on to another game
                            isPlaying = false;
                        }
                    }
                    // If number is too high
                    else if (number > randomValue)
                    {
                        // Tell user the number is too high and guess again.
                        Console.WriteLine("Too High. Guess again.");
                        // Get next guess
                    }
                    // If number is too low
                    else if (number < randomValue)
                    {
                        // Tell user the number is too low and guess again.
                        Console.WriteLine("Too Low. Guess again.");
                        // Get next guess
                    }
                } // Close While loop for isGuessing


            } // Clost While loop for isPlaying
            // Give user a goodbye message
            Console.WriteLine("Thank you for playing Guess a Number!");

        } // End Main
    } // End Class
} // End namespace GuessTheNumberGame
