public class PromptGenerator
{

    public List<string> _prompts = new List<string>() {
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
    


    public string GetRandomPrompt()
    {
        //Choose a random prompt from _prompts
        Random randomGenerator = new Random();
        int index = randomGenerator.Next(0, _prompts.Count);
        string randomPrompt = _prompts[index];
        return "A random prompt: ";
    }
}