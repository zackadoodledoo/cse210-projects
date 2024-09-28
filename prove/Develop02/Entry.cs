
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        Console.WriteLine($"{_date} : {_promptText}");
        Console.WriteLine(_entryText);
    }

    internal void Load(string file)
    {
        throw new NotImplementedException();
    }

    internal void Save(string file)
    {
        throw new NotImplementedException();
    }
}