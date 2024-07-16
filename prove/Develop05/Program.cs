using System;

class Program
{

    static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        Console.WriteLine("Let's go to the battlefield and work on your goals!");

        goalManager.Start();
    }
}