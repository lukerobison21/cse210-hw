using System.Collections.Generic;

public class WorkoutSession
{
    private List<Activity> _activities = new List<Activity>();

    public void AddActivity(Activity activity)
    {
        _activities.Add(activity);
    }

    public List<Activity> GetActivities()
    {
        return _activities;
    }
}