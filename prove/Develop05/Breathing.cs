using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing Activity");
        SetDescription("This activity will help you relax by walking through your breathing in and out slowly. Clear your mind, relax, and  focus on your breathing.");

    }
    public void PromptBreathing()
    {
        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Breathe in....");
        GenerateCountdownTimer(5);
        Console.WriteLine();
        Console.WriteLine("Now breathe out....");
        GenerateCountdownTimer(6);

        while (currentTime < futureTime)
        {
           Console.WriteLine();
           Console.WriteLine();
           Console.WriteLine("Breathe in....");
           GenerateCountdownTimer(5);
           Console.WriteLine();
           Console.WriteLine("Now breathe out....");
           GenerateCountdownTimer(6);
           currentTime = GetCurrentTime(); 
        }
    }
}