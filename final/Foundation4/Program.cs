using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        DateTime date = new DateTime(2024, 7, 22);
        activities.Add(new Running(date, 60, 5.5)); //60 mins, 5.5 miles
        activities.Add(new Cycling(date, 60, 20)); //60 mins, 20 mph
        activities.Add(new Swimming(date, 60, 30));//60 mins, 30 laps

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}