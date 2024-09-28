public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileName = "";

    public Journal()
    {
        //Initialize _entries
    }  

    public void Display()
    {
        //Display each entry in _entries
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
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