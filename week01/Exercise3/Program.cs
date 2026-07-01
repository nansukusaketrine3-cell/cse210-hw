using System;

class Program
{
    static void Main(string[] args)
    {
          string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guessCount = 0;
            int guess = 0;

            // Play the game
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine($"It took you {guessCount} guesses.");

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}