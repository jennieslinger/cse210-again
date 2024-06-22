using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Hello! Nice to see you!");
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load from a txt file");
            Console.WriteLine("4. Save to a txt file");
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do?");
            string answer = Console.ReadLine();
            int intAnswer = int.Parse(answer);

            if (intAnswer == 1)
            {
                Console.WriteLine("Enter a date for this entry: (xx/xx/xx)");
                string entryDate = Console.ReadLine();

                string prompt = PromptGenerator.GetRandomPrompt();
                Console.WriteLine($"{prompt}: ");
                Console.WriteLine(">>>");
                string entryText = Console.ReadLine();
                Entry _entry = new Entry(prompt, entryText, entryDate);
                journal.AddEntry(_entry);
                Console.WriteLine("Entry has been added.");
            }

            else if (intAnswer == 2)
            {
                journal.DisplayAllEntries();
            }

            else if (intAnswer == 3)
            {
                Console.WriteLine("What file would you like to load?  (Include .txt)");
                string loadFilename = Console.ReadLine();
                journal.LoadFromFile(loadFilename);
            }

            else if (intAnswer == 4)
            {
                Console.WriteLine("What would you like to call this file? (Include .txt) ");
                string saveFilename = Console.ReadLine();
                journal.SaveToFile(saveFilename);
                Console.WriteLine($"You're file has been saved as {saveFilename}");
            }
            else if (intAnswer == 5)
            {
                Console.WriteLine("See you next time. Good bye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Entry. Try again");
            }
        }
    }
}