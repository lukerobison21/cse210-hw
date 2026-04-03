using System;
using System.Collections.Generic;

public class ActivityManager
{
    private List<Activity> _activities = new List<Activity>();

    public void CreateSampleActivities()
    {
        _activities.Add(new Running("04 Apr 2026", 30, 3.0));
        _activities.Add(new Cycling("04 Apr 2026", 45, 12.0));
        _activities.Add(new Swimming("04 Apr 2026", 20, 20));
    }

    public void DisplayActivities()
    {
        foreach (Activity activity in _activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine($"Distance: {activity.GetDistance()}");
            Console.WriteLine($"Speed: {activity.GetSpeed()}");
            Console.WriteLine($"Calories: {activity.GetCalories()}");
            Console.WriteLine();
        }
    }
}