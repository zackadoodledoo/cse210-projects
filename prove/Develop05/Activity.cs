using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity()
    {
        _name = " ";
        _description = " ";
        _duration = 15;
    }
    public void SetName(string name)
    {
        _name= name;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void ShowDetails()
    {
        Console.WriteLine($"Welsome to the {_name}." );
        Console.WriteLine();
        Console.WriteLine(_description);
    }
    public void AskDuration()
    {
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like to meditate for your session? ");
        string durationString = Console.ReadLine();
        SetDuration(Convert.ToInt32(durationString));
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void RunActivity()
    {
        Console.Clear();
        ShowDetails();
        AskDuration();
        GetReady();
    }

    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Well done! You have completed {_name} for {_duration} seconds. ");
        GenerateSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity. ");
        GenerateSpinner(5);
    }

    public void GenerateSpinner(int totalSeconds)
    {
        int spinnerPosition = 25;
        int spinWait = 500;

        spinnerPosition = Console.CursorLeft;

        DateTime futureTime = GetFutureTime(5);

        while(DateTime.Now < futureTime)
        {
            char[] spinChars = {'|', '/', '-', '\\'};
            foreach (char spinChar in spinChars)
            {
                Console.CursorLeft = spinnerPosition;
                Console.Write(spinChar);
                Thread.Sleep(spinWait);
            }
        }

        Console.CursorLeft = spinnerPosition;
        Console.WriteLine(" ");
    }
    public void GenerateCountdownTimer(int totalSeconds)
    {
        int timerPosition = 25;
        int timerwait = 1000;

        timerPosition = Console.CursorLeft;

        for (int i = 0; i <= totalSeconds; i++)
        {
            Console.CursorLeft = timerPosition;
            Console.Write(totalSeconds - i);
            Thread.Sleep(timerwait);
        }

        Console.CursorLeft = timerPosition;
        Console.WriteLine(" ");
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        GenerateSpinner(5);
    }
    public DateTime GetFutureTime(int duration)
    {
        DateTime futureTime = new DateTime();
        futureTime = DateTime.Now.AddSeconds(duration);

        return futureTime;
    }

    public DateTime GetCurrentTime()
    {
        DateTime currentTime = new DateTime();
        currentTime = DateTime.Now;
        return currentTime;
    }
}