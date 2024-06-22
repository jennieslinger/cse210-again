public class Entry
{
    public string _date { get; }
    public string _promptText { get; }
    public string _entryText { get; }

    public Entry(string entryDate, string promptText, string entryText)
    {
        _date = entryDate;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText} \n");
    }
}