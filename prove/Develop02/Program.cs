using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        // Test Code

        int[] validNumbers = { 1, 2, 3, 4, 5 };
        int action = 0;
        Console.WriteLine("Welcome to the Journal Program!");

        Journal journal = new Journal();
        JournalPrompt jp = new JournalPrompt();

        while (action != 5)
        {
            //Ask for user input (1-5)
            //Call choices
            action = Choices();

            switch (action)
            {
                case 1:
                    //Write journal entry
                    string entryId = GetEntryId();
                    string dateInfo = GetDateTime();
                    string prompt = jp.GetPrompt();

                    JournalEntry entry = new JournalEntry();
                    entry._entryNumber = entryId;
                    entry._dateTime = dateInfo;
                    entry._journalPrompt = prompt;

                    Console.WriteLine($"{prompt}\n");
                    Console.Write(">>> ");
                    string userEntry = Console.ReadLine();
                    entry._journalEntry = userEntry;

                    journal._journal.Add(entry);
                    break;

                case 2:
                    //Display journal entries
                    journal.Display();
                    break;

                case 3:
                    //Load journal entries
                    journal.LoadJournalFile();
                    // Console.WriteLine("Journal entries loaded!");
                    break;

                case 4:
                    //Save journal entries
                    journal.CreateJournalFile();
                    break;

                case 5:
                    //Quit
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static int Choices()
    //Method to display choices to the user
    {
        string choices = @"
    
1. Write       
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ";

        Console.WriteLine(choices);
        string userInput = Console.ReadLine();
        int action = 0;
        // This block catches any non integer values that are entered
        try
        {
            action = int.Parse(userInput);
        }
        catch (FormatException)
        {
            action = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"An error occurred: {exception.Message}");
        }
        return action;
    }
    static string GetDateTime()
    //Method to get date and time for journal record
    {
        DateTime now = DateTime.Now;
        string currentDateTime = now.ToString("F");
        //Console.WriteLine(now.ToString("F"));
        //Displays date and time
        return currentDateTime;
    }   

    static void AddJournalEntry()
    //Method to add entry to text file
    {
        string MyJournalFile = "MyJournal.txt";
        File.AppendAllText(MyJournalFile, " ");
    }

    static string GetEntryId()
    {
        Guid entryuuid = Guid.NewGuid();
        string entryuuisAsString = entryuuid.ToString();

        return entryuuisAsString;
    }
    
}
        