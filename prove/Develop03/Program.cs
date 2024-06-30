using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Mosiah", 26, 39);
        string text = "And they did admonish their brethren; and they were also admonished, every one by the word of God, according to his sins, or to the sins which he had committed, being commanded of God to pray without ceasing, and to give thanks in all things.";
        Scripture scripture = new Scripture(reference, text);

        //welcome message - Exceeds requirements
        Console.WriteLine("Welcome to the Scripture Memorizer! Today's scripture is:  \n");

        //initial display
        Console.WriteLine(reference.GetDisplayText());
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nPress ENTER to continue or type 'quit' to exit.");

        //user input
        string input = Console.ReadLine();
        while (input != "quit")
        {
            //hide words and display
            scripture.HideRandomWords(5);
            Console.WriteLine("\nUpdated Scripture: ");
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden. Press any key to exit.");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("\nPress Enter to hide 5 more random words or type 'quit' to exit.");
            input = Console.ReadLine();
        }

        Console.WriteLine("Program has finished. Goodbye!");
    }
}