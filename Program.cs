using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a message to the user asking them to guess the secret number.
            Console.WriteLine("Guess a number between 1 and 10");
            //Display a prompt for the user's guess.
            string input = Console.ReadLine();
            //Take the user's guess as input and save it as a variable.
            int parsedInput = int.Parse(input);
            // Display the user's guess back to the screen.
            Console.WriteLine(input);

        }
    }
}
