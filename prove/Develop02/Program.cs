using System;
using System.Security.Cryptography;

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
        