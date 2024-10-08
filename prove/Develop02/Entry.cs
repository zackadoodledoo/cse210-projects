using System;
public class Entry
{
    public string _entryNumber = "";
    public string _date = "";
    public string _dateTime = "";
    public string _promptText = "";
    public string _entryText = "";
    public string _fileName = "";
  
    // A special method, called a constructor that is invoked using the
    // new keyword followed by the class name and parentheses.
    public Entry() 
    {

    }



    public void Display()
    {
        Console.WriteLine($"\n#: {_entryNumber}");
        Console.WriteLine($"{_dateTime}");
        Console.WriteLine($"{_promptText}");
        Console.WriteLine($"{_entryText}");
       
    }

}
