using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Mastering the Art of Vegan Backing", "Chef Ellie's Kitchen", 1200);//20 mins
        video1.AddComment("Sarah W", "This video made vegan baking look so easy! Can't wait to try out those recipes. Thanks, Chef Ellie!");
        video1.AddComment("Emily P", "Wow, those desserts look amazing! You've inspired me to give vegan baking a try. Subscribed!");
        video1.AddComment("Mark S", "As someone new to veganism, this was incredibly helpful. Loved the detailed tips on egg substitutes!");

        Video video2 = new Video("Exploring the Mysteries of Ancient Ruins", "ArachaeoQuest Adventures", 2700);//45mins
        video2.AddComment("John D", "This was like going on a virtual expedition! Fascinating insights into ancient civilizations.");
        video2.AddComment("Elena T", "Thie story telling was on point! I felt like I was right there uncovering history with you.");
        video2.AddComment("Robert K", "Absolutely mind-blowing! Can't believe how advanced thse ancient cultures were.");
        video2.AddComment("Sophie L", "Please make more videos like this!");

        Video video3 = new Video("Tech Review: Unboxing the Latest Gadgets!", "TechGeek Universe", 900);//15 mins
        video3.AddComment("David H", "Great review! Really helped me decide which new gadget to buy.");
        video3.AddComment("Jessica R", "Your unboxing videos are always so detailed and  informative. Keep up the good work!");
        video3.AddComment("Michael B", "Love your honest opinions on each product. It's refreshing in the would of tech reviews.");
        video3.AddComment("Laura G", "Could you do a comparison video next? Maybe between different brands of smartphones?");


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            Console.WriteLine("Video Information: ");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} in seconds");
            Console.WriteLine($"Number of Comments made on video: {video.GetNumberComments()}");

            Console.WriteLine("");
            Console.WriteLine("Comments: ");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"{comment._commentAuthor}: {comment._text}");
                Console.WriteLine("");
            }
        }

    }
}