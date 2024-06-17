using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 1989;
        job1._endYear = 2013;
        //job1.DisplayJob();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Analyst";
        job2._startYear = 2014;
        job2._endYear = 2023;
        //job2.DisplayJob();

        Resume myResume = new Resume();
        myResume._name = "Kelley Marx";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}