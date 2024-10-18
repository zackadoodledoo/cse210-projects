using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Think of a scenario where you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you made a mistake.",
        "Think of a time when you did something truly selfless.",
        "Think of a time you took a risk to support a worthy cause.",
        "Think of an occasion when you overcame a major obstacle through preserverance.",
        "Think of a time where you went out of your way to make someone's day.",
        "Think of a memory of when you prioritized someone's needs over your own.",
        "Think of a time when you confronted unjustice or unfairness.",
        "Think of a time when you made someone feel appreciated.",
        "Think of a time when you made someone feel obligated.",
        "Think of a time when you made someone feel humbled.",
        "Think of a time when you made someone feel respected.",
        "Think of a time when you made someone feel loved.",
        "Think of a time when you shared what you have learned or experienced to help another.",
    };
    private List<string> _questions = new List<string>{
        "What differentiates this occasion from previous ones where you were less successful?",
        "What aspect of this experience resonated with you most?",
        "What broader applications or lessons can you take away from this expereience?",
        "What self-discoveries did you make because of this experience?",
        "How can you integrate the insights gained from this experience into future endeavors?",
        "What significance does this experience hold for you?",
        "Have you reviously encountered a similar situation?",
        "What were the initial steps you took to initiate this process?",
        "How did you feel upon completing the task?",
    };
    public ReflectingActivity()
    {
        SetName("Reflecting Activity");
        SetDescription("This activity will help you reflect on the good things in your life by having you reflect on times in your life when you have shown strength and resilience. ");
    }

    public string GeneratePrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }

    public string GenerateQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];
    }
    public void PromptReflecting()
    {
        string prompt = GeneratePrompt();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.Clear();

        DateTime futureTime = GetFutureTime(GetDuration());
        DateTime currentTime = GetCurrentTime();

        while (currentTime <= futureTime)
        {
            string question = GenerateQuestion();
            Console.WriteLine();
            Console.WriteLine(question + " ");
            GenerateSpinner(15);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
    }
}