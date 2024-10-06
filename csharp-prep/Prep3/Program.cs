using System;

class Program
{
    static void Main(string[] args)
    {
        // Stretch Challenge 2:
        // Declaring and initializing variable to loop back and play the whole game again as long as the user keep saying "yes".
        string playAgain = "yes";

        // Setting the condition to play again as long as user says "yes"
        while (playAgain == "yes")
        {
            // Declaring and initializing the loop variables
            /* Creating an instance of the Random class, and then using it to
                generate a random number from 1 to 100.
            */
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            // Declaring and initializing the guess variable        
            int guess = 0;

            // Stretch Challenge 1: Declaring and initializing the guess counter variable.
            int guessCount = 0;

            while (magicNumber != guess)
            {
                // Prompting the user for the guess number and then converting it
                Console.Write("What is your guess? ");
                string userInputGuess = Console.ReadLine();
                guess = int.Parse(userInputGuess);

                // Incrementing the guessCounter
                guessCount++;

                // Setting the conditions to determine if the user needs to guess higher or lowe
                if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }
            // Leaving the inner loop to display message after a correct correct guess. 
            Console.WriteLine($"You made {guessCount} guesses");

            // Input statement to ask the user if he/she wants to play the game again.
            Console.Write("Would you like to play again (yes/no)? ");
            string userPlayAgain = Console.ReadLine();
            

            // Using the ToLower() to convert the user entry before comparing, to avoid errors
            playAgain = userPlayAgain.ToLower();
        }
        // Goodbye message after playing
        Console.WriteLine("Thank you for playing. Goodbye.");
        
    }
}