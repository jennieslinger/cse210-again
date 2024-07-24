using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime date = new DateTime(2024, 7, 22);
        activities.Add(new Running(date, 45, 3));
        activities.Add(new Cycling(date, 60, 25));
        activities.Add(new Swimming(date, 30, 20));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}