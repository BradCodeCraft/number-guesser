using System;

namespace NumberGuesser
{
    class Program
    {
        static void AppInfo()
        {
            // Set App Variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad Nguyen";

            // Change Text Color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Write out App info
            Console.WriteLine("{0}: Version {1} By {2}", appName, appVersion, appAuthor);

            // Reset Text Color
            Console.ResetColor();            
        }

        static void GreetUser()
        {
            // Ask User's Name
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();

            // Greet User
            Console.WriteLine("Hello {0}, let's play a game...", userName);
        }

        static void Main(string[] args)
        {
            // Show App Info
            AppInfo();

            // Greet User
            GreetUser();

            string playDecision = "Y";

            // App Logic
            while (playDecision != "N")
            {
                // Set correct number
                int correctNumber = new Random().Next(1, 10);

                // Set guess variable
                int userGuess = 0;
                Console.Write("Guess a number between 1 and 10: ");
                bool validGuess = Int32.TryParse(Console.ReadLine(), out userGuess);

                while (!validGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter a valid number.");
                    Console.ResetColor();
                    Console.Write("Guess a number between 1 and 10: ");
                    validGuess = Int32.TryParse(Console.ReadLine(), out userGuess);
                }

                while (userGuess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number, please try again.");
                    Console.ResetColor();
                    Console.Write("Guess a number between 1 and 10: ");
                    validGuess = Int32.TryParse(Console.ReadLine(), out userGuess);

                    while (!validGuess)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a valid number.");
                        Console.ResetColor();
                        Console.Write("Guess a number between 1 and 10: ");
                        validGuess = Int32.TryParse(Console.ReadLine(), out userGuess);
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You are correct! {0} is the correct number!", correctNumber);
                Console.ResetColor();

                Console.Write("Do you want to play again? [Y or N]: ");
                playDecision = Console.ReadLine().ToUpper();
            }

        }
    }
}