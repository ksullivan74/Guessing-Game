using System;



//Phase 5:
// Use a random number to set the secret number between 1 and 100 instead of a hard-coded number.
//The prompt should display the number of guesses the user has left.


Console.WriteLine("Guess a number, you have 4 chances.");
int secretNumber = new Random().Next(1, 100);

for (int i = 0; i < 4; i++)
{
    int guesses = 4 - (i + 1);
    string input = Console.ReadLine();
    int parsedInput = int.Parse(input);
    //Continue to display the success or failure messages as in phase 2
    if (parsedInput == secretNumber)
    {
        Console.WriteLine($"You Guessed Right! Guesses remaining: {guesses}");
        break;
    }
    else
    {
        Console.WriteLine($"You Guessed Wrong :(, Guesses remaining: {guesses}");
    }
}



