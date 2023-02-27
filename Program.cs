using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display a message to the user asking them to guess the secret number.
            //Display a prompt for the user's guess.
            Console.WriteLine("Guess a number");
            //Take the user's guess as input and save it as a variable.
            string input = Console.ReadLine();
            int parsedInput = int.Parse(input);

            // Display the user's guess back to the screen.
            // No longer display the user's guess. They know what they guessed, right?
            //Console.WriteLine(input);

            //Create a variable to contain the secret number(application's number). 
            //This number should be hard-coded for now. 42 is a nice number.
            int secretNumber = 42;

            //Compare the user's guess with the secret number. 
            //Display a success message if the guess is correct, otherwise display a failure message.
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
