using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Guess a number");
            int secretNumber = 42;
            // Give the user four chances to guess the number.
            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();
                int parsedInput = int.Parse(input);
                //Continue to display the success or failure messages as in phase 2
                if (parsedInput == secretNumber)
                {
                    Console.WriteLine("You Guessed Right!");
                }
                else
                {
                    Console.WriteLine("You Guessed Wrong :(");
                }
            }
        }
    }
}
