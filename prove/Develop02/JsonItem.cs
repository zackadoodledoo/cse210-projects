using System;

// A code template for the category of things known as
public class JsonItem
{
    public string ID{ get; set; }
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Entry { get; set; }
    public string Text { get; set; }

    // A special method, called a constructor that is invoked using the
    // new keyword followed by the class name and parentheses
    public JsonItem()
    {
        ID = "";
        Date = "";
        Prompt = "";
        Entry = "";
        Text = "";
    }
}