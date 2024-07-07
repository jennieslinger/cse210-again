using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by slowly walking through your inhales and exhales in a regulated square pattern. Clear your mind and focus on your breathing.";
    }

    public void RunBreathingActivity(int duration)
    {
        int cycleDuration = 4; //a cycle = inhale + exhale in seconds

        int cycles = duration / (cycleDuration * 2); //calculated number of cycles

        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Inhale...");
            ShowCountDown(cycleDuration);
            Console.Clear();
            Console.WriteLine("Hold...");
            ShowCountDown(cycleDuration);
            Console.Clear();
            Console.WriteLine("Exhale...");
            ShowCountDown(cycleDuration);
            Console.Clear();
            Console.WriteLine("Hold...");
            ShowCountDown(cycleDuration);
            Console.Clear();
        }
    }
}