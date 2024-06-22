using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public static List<string> _prompts = new List<string>
    {
        "What did you change your mind about today?",
        "What acts of service did you participate in today?",
        "How did you build your testimony today?",
        "How did you feel the Holy Ghost today?",
        "What are your planned summer activities?",
        "What new thing did you learn or try today?"
    };

    public static Random random = new Random();

    public static string GetRandomPrompt()
    {
        return _prompts[random.Next(_prompts.Count)];
    }
}