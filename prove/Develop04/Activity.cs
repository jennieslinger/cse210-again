using System;
using System.Threading;

public class Activity
{
    protected string _name;
    protected string _description;
    public string _duration;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name}...\n");
        Console.WriteLine(_description);
        Thread.Sleep(5000);//pause 5 sec
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(8);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        Console.WriteLine($"\nYou have completed the {_name} for {_duration} seconds.\n");
        Thread.Sleep(5000);//pause 5 sec
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("-");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);//moves cursor back 1 space
            Console.Write("\\");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("|");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Console.Write("/");
            Thread.Sleep(100);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }
        Console.WriteLine(" ");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);//pause 1 sec
            Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
        }
        Console.WriteLine();
    }

    public void SetDuration()
    {
        Console.WriteLine($"How long, in seconds, would you like your {_name} session?");
        _duration = Console.ReadLine();
    }

    public int GetDuration()
    {
        return int.Parse(_duration);
    }
}