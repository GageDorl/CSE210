using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [];
        Run run = new("12 Dec 2025", 30, 3);
        Cycle cycle = new("11 Dec 2025", 25, 6);
        Swim swim = new("10 Dec 2025", 15, 50);
        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);
        foreach(Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}