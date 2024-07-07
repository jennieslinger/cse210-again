public class ReflectingActivity : Activity
{
    private string[] _prompts = new string[]
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] _questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can   you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This acitivty will help you reflect on the time in your life when you have shown strength and resilience. This will help you to recognize the power you have and how you can use it in other aspects on your life.";
    }

    public void RunReflectingActivity(int duration)
    {
        Console.WriteLine("\nConsider the following prompt: ");
        DisplayPrompt();
        Console.WriteLine("\nWhen you have something in mind, press Enter to continue. ");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience. ");
        Thread.Sleep(5000);//pause 5 sec

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"> {GetRandomQuestion()}");
            Thread.Sleep(7000);//pause 7 secs
        }
    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        return _prompts[random.Next(_prompts.Length)];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        return _questions[random.Next(_questions.Length)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }

    public void DisplayQuestion()
    {
        Console.WriteLine(GetRandomQuestion());
    }

}