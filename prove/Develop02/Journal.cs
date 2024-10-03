using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    private string _fileName = "";

    public Journal()
    {
        //Initialize _entries
    }  

    public void Display()
    {
        Console.WriteLine("Journal Entries: ");
        //Display each entry in _entries
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }

        Console.WriteLine("\n*********** End ***********");
    }
    public void CreateJournalFile()
    //Method to check if text file is created if not create one
    {
        Console.WriteLine("What would you like to name your file? ");
        string userInput = Console.ReadLine();
        _fileName = userInput + ".txt";

        if (!File.Exists(_fileName))
        {
            File.Create(_fileName);
            Console.WriteLine($"\n*** {_fileName} File created successfully!***\n");
            Console.WriteLine("*** Your journal entries have been saved! ***\n");
            SaveJournalFile(_fileName);
            CreateJSON(userInput);
        }   
        else
        {
            Console.WriteLine($"\n*** {_fileName} File already exists!***\n");
            Console.WriteLine("*** Your journal entries have been loaded! ***\n");
            AppendJournalFile(_fileName);
        }
    }

    public void SaveJournalFile(string fileName)
    // Method to save journal to text file
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._entryNumber}; {entry._dateTime}; {entry._promptText}; {entry._entryText}");
            }
        }
        //Save each entry in _entries to file

    }
    public void Load(string file)
    {
        //Load each entry from file into _entries
        foreach (Entry entry in _entries)
        {
            entry.Load(file);
        }
    }

    public void Save(string file)
    {
        //Save each entry in _entries to file
        foreach (Entry entry in _entries)
        {
            entry.Save(file);
        }
    }

    public void AddEntry()
    {
        //Create a new entry object and add it to _entries
        Entry newEntry = new Entry();
        _entries.Add(newEntry);
    }

    public void AddEntry(string date, string promptText, string entryText)
    {
        //Create a new entry object and add it to _entries
        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._promptText = promptText;
        newEntry._entryText = entryText;
        _entries.Add(newEntry);
    }

    public void AddEntry(string date, string promptText)
    {
        //Create a new entry object and add it to _entries
        Entry newEntry = new Entry();
        newEntry._date = date;
        newEntry._promptText = promptText;
        _entries.Add(newEntry);
    }
    

    public void AddEntry(Entry newEntry)
    {
        //Add to the list of entries into _entries
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        //Display each entry in _entries
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        //Save each entry in _entries to file
        foreach (Entry entry in _entries)
        {
            //Save each entry in _entries to file
            entry.Save(file);
        }
    }

    public void loadFromFile(string file)
    {
        //Load each entry from file into _entries
        foreach (Entry entry in _entries)
        {
            //Load each entry from file into _entries
            entry.Load(file);
        }
    }
}