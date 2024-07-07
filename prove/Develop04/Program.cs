using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Mindfulness Program! \n");
        Thread.Sleep(3000);//pause 3 sec
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Select a number choice from the menu below: ");
            Console.WriteLine("\nMenu Options: ");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity;");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");

            string choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    RunBreathingActivity();
                    break;
                case "2":
                    RunReflectingActivity();
                    break;
                case "3":
                    RunListingActivity();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid entry. Please select again.");
                    Thread.Sleep(2000);//pause 2 sec
                    Console.Clear();
                    break;
            }
        }
    }

    static void RunBreathingActivity()
    {
        BreathingActivity activity = new BreathingActivity();
        activity.SetDuration();
        int duration = activity.GetDuration();
        activity.DisplayStartingMessage();
        activity.RunBreathingActivity(duration);
        activity.DisplayEndingMessage();
    }

    static void RunReflectingActivity()
    {
        ReflectingActivity activity = new ReflectingActivity();
        activity.SetDuration();
        int duration = activity.GetDuration();
        activity.DisplayStartingMessage();
        activity.RunReflectingActivity(duration);
        activity.DisplayEndingMessage();
    }

    static void RunListingActivity()
    {
        ListingActivity activity = new ListingActivity();
        activity.SetDuration();
        int duration = activity.GetDuration();
        activity.DisplayStartingMessage();
        activity.RunListingActivity(duration);
        activity.DisplayEndingMessage();
    }
}