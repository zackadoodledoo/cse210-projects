using System;

class Program
{
    static void Main(string[] args)
    {

        // Test Code

        Entry e = new Entry();
        e._date = "Today";
        e._promptText = "How are you feeling? ";
        e._entryText = "I am well. ";

        e.Display();

        Console.WriteLine("Welcome to the Journal Program!");
        String choice;
        do
        {
            Console.WriteLine("Please choose one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? Please Choose 1, 2, 3, 4, or 5.");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                //Create a new entry object to pass to the journal for storage
                Console.WriteLine("What would you like to write? ");
                Entry newEntry = new Entry();
                newEntry._date = Console.ReadLine();
                newEntry._promptText = Console.ReadLine();
                newEntry._entryText = Console.ReadLine();
                newEntry.Display();
            }
            else if (choice == "2")
            {
            
            }
            else if (choice == "3")
            {
                
            }
            else if (choice == "4")
            {
                
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again! ");
            }
            Console.WriteLine();
        } 
        while (choice != "5");
    }
}