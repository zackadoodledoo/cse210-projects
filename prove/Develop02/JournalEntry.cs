using System;
public class JournalEntry
{
    public string _entryNumber = "";
    public string _dateTime = "";
    public string _journalPrompt = "";
    public string _journalEntry = "";
    public string _journalFile = "";
  
    // A special method, called a constructor that is invoked using the
    // new keyword followed by the class name and parentheses.
    public JournalEntry() 
    {
    }



    public void Display()
    {
        Console.WriteLine($"\n#: {_entryNumber}");
        Console.WriteLine($"{_dateTime}");
        Console.WriteLine($"{_journalPrompt}");
        Console.WriteLine($"{_journalEntry}");
       
    }

}
