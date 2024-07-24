using System;

class Program
{
    public static void Main()
    {
        Address eventAddress = new Address("2333 W. McDonald", "Springfield", "MO", "55555");

        Event generalEvent = new Event("Annual Library Book Fair", "An event for everyone who loves books", new DateTime(2024, 8, 18), 17, eventAddress);

        Lecture lectureEvent = new Lecture("Mom's Tech Talk", "Discussion about technology geared towards mothers and families.", new DateTime(2024, 8, 8), 10, eventAddress, "Marissa Schemke", 75);

        Reception receptionEvent = new Reception("NextTel Company Party", "Company gathering", new DateTime(2024, 9, 8), 18, eventAddress, "info@nexttel.com");

        OutdoorGathering outdoorEvent = new OutdoorGathering("Frogapalooza", "A celebration of all things frog.", new DateTime(2024, 11, 14), 7, eventAddress, 75);

        Console.WriteLine("--STANDARD DETAILS--");
        Console.WriteLine(generalEvent.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("");

        Console.WriteLine("--FULL DETAILS--");
        Console.WriteLine(generalEvent.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine("");

        Console.WriteLine("--SHORT DESCRIPTIONS--");
        Console.WriteLine(generalEvent.GetShortDescription());
        Console.WriteLine("");
        Console.WriteLine(lectureEvent.GetShortDescription());
        Console.WriteLine("");
        Console.WriteLine(receptionEvent.GetShortDescription());
        Console.WriteLine("");
        Console.WriteLine(outdoorEvent.GetShortDescription());
        Console.WriteLine("");
    }
}