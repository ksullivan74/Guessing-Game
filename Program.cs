using System;



//Phase 6:
// Inform the user if their guess was too high or too low, when they guess incorrectly.

int y = 0;

Console.WriteLine("Guess a number, do you want easy, hard, or medium difficulty.");
Console.WriteLine("You can also have `cheater` mode which give you infinite guesses");
string difficulty = Console.ReadLine();
if (difficulty == "easy")
{
    y = 8;
};
if (difficulty == "hard")
{
    y = 4;
};
if (difficulty == "medium")
{
    y = 6;
};
if (difficulty == "cheater")
{
    y = 999;
}

int secretNumber = new Random().Next(1, 100);
Console.WriteLine(secretNumber);

Console.WriteLine("Guess Your Number!");

for (int i = 0; i < y; i++)
{
    int guesses = y - (i + 1);
    string input = Console.ReadLine();
    int parsedInput = int.Parse(input);
    //Continue to display the success or failure messages as in phase 2
    if (parsedInput == secretNumber)
    {
        Console.WriteLine($"You Guessed Right! Guesses remaining: {guesses}");
        break;
    }
    if (parsedInput < secretNumber)
    {
        Console.WriteLine($"Too low try again,  Guesses remaining: {guesses}");
    }
    else
    {
        Console.WriteLine($"Too high try again,  Guesses remaining: {guesses}");
    }
}

