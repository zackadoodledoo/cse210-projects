using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber = GeneratingMagicNumber();

        int guess = -1;

        while (guess != magicNumber)
        {
            guess = GetUserGuess();

            EvaluateGuess(guess, magicNumber);
        }
    }

    static int GeneratingMagicNumber()
    {
        Random randomGenerator = new Random();
        return randomGenerator.Next(1, 101);
    }

    static int GetUserGuess()
    {
        Console.WriteLine("What is your guess? ");
        return int.Parse(Console.ReadLine());
    }

    static void EvaluateGuess(int guess, int magicNumber)
    {
        if (magicNumber > guess)
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
}