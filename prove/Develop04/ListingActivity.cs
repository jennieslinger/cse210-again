public class ListingActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "Who are people tha tyou appreciate?",
        "What are your personal strengths?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some your pesonal heroes?"
    };

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can regarding a certain area of your life.";
    }

    public void RunListingActivity(int duration)
    {
        Console.WriteLine("\nList as many responses as possible to the following prompt: ");
        Console.WriteLine($"---{_prompts[new Random().Next(_prompts.Length)]}---");

        //countdown

        Console.WriteLine("\nEnter items, one item per line, press Enter after each item: ");
        int count = 0;
        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < 20)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
                break;
            count++;
        }

        Console.WriteLine($"You listed a total of {count} items.");
        ShowSpinner(3);
    }
}

/*public void GetRandomPrompt()
{
    return;
}

public string GetListFromUser()
{
    return;
}
*/