using System;

class Program
{
    static void Main(string[] args)
    {
        //create assignment
        Assignment assignment = new Assignment("Jenni Eslinger", "Inheritance Assignment");

        //get and display summary
        Console.WriteLine(assignment.GetSummary());

        //create math assignment
        MathAssignment mathAssignment = new MathAssignment("Jenni Eslinger", "Calculus", "Limits", "1-30");

        //get and display summary and math homework list
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        //create writing assignment
        WritingAssignment writingAssignment = new WritingAssignment("Jenni Eslinger", "Holocost Literature", "Report on Elie Wiesel's Night");

        //get and display summary and writing info
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}