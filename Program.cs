using System;



//Phase 4:
// Display the number of the user's current guess in the prompt. For example, if the user has already guessed one time, the prommpt should say something like Your guess (2)>.
//End the loop early if the user guesses the correct number.


Console.WriteLine("Guess a number, you have 4 chances.");
int secretNumber = 42;
// Give the user four chances to guess the number.
for (int i = 0; i < 4; i++)
{
    string input = Console.ReadLine();
    int parsedInput = int.Parse(input);
    //Continue to display the success or failure messages as in phase 2
    if (parsedInput == secretNumber)
    {
        Console.WriteLine($"You Guessed Right! Guess Number: {i + 1}");
        break;
    }
    else
    {
        Console.WriteLine($"You Guessed Wrong :(, Guess Number: {i + 1}");
    }
}



