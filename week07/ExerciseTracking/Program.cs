using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        // Create sample activities
        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8));        
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 45, 20.0));        
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 40, 30));         

        // Display summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

