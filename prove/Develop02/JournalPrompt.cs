using System;
public class JournalPrompt
{

    public static string[] _prompt = {
        "How are you?",
        "What is your name?",
        "What are you doing?",
        "What do you do for fun?",
        "What is your favorite color?",
        "What is your favorite food?",
        "What is your favorite band?",
        "What is your favorite movie?",
        "What is your favorite song?",
        "What is your favorite book?",
        "What is your favorite TV show?",
    };
    public List<string> _journalPrompt = new List<string> (_prompt);

    public JournalPrompt()
    {

    }

    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];

        return journalPrompt;
    }

}