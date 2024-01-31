// See https://aka.ms/new-console-template for more information
using System;

namespace Playtime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to guess the number game!");
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 50;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max +1);

                while(guess != number)
                {
                    Console.WriteLine("Please guess the number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " ,ouch! To high");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " ... tch. That low?");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You won, congrats");
                Console.WriteLine("Number of guesses: " + guesses);

                Console.WriteLine("Want to play again? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing, see ya around");
            Console.ReadKey();
        }
    }
}