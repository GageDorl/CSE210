using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = [];
        Video video1 = new("How to tie your shoe", "ShoeTieGuy73", 124);
        Video video2 = new("Pranking the homeless", "BadPerson12", 728);
        Video video3 = new("Christmas with the fam", "FamilyManDan", 1283);
        video1.AddComment(new("Bryan","Thanks man, I couldn't figure out the bunny ears"));
        video1.AddComment(new("Chuck","Can you make a part 2?"));
        video1.AddComment(new("MeanGuy1","Who even needs to watch this?"));
        video2.AddComment(new("Bryan","You are so mean for doing this"));
        video2.AddComment(new("Chuck","Do they really need more on their plate? Well..."));
        video2.AddComment(new("MeanGuy1","This is the best!"));
        video3.AddComment(new("Bryan","So wholecome"));
        video3.AddComment(new("Chuck","This is so sweet"));
        video3.AddComment(new("MeanGuy1","Bro get off the internet"));
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach(Video video in videos)
        {
            video.Display();
        }
    }
}