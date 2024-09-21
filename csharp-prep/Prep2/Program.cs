using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = GradeLetter(percent);

        Console.WriteLine($"Your grade is {letter}");

        if(IsPassingGrade(percent))
        {
            Console.WriteLine("You passed! ");
        }
        else
        {
            Console.WriteLine("Better luck next time! ");
        }
    }

    static string GradeLetter(int percent)
    {
        if(percent >= 90)
        {
            return "A";
        }
        else if(percent >= 80)
        {
            return "B";
        }
        else if(percent >= 70)
        {
            return "C";
        }
        else if(percent >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

    static bool IsPassingGrade(int percent)
    {
        return percent >= 70;
    }
    
}