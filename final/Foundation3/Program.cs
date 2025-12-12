using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new("123 Street St","Rexburg","ID","USA");
        Lecture lecture = new("How to tie your shoe","Lecture to teach people how to tie their shoes", "12/15/25","3:00 pm", address, "Rob Shoesburg",30);
        Reception reception = new("Wedding Reception","WEdding Reception for Arthur and Nicole","12/18/25","5:00 PM",address, "arthur@gmail.com");
        Gathering gathering = new("Birdwatching","Gather together to look at birds in Yellowstone","12/20/25","10:00 AM",address,"Sunny");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(gathering.GetStandardDetails());
        Console.WriteLine(gathering.GetFullDetails());
        Console.WriteLine(gathering.GetShortDescription());
    }
}