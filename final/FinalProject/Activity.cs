using System;

public class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetCalories()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"Date: {_date}, Minutes: {_minutes}";
    }
}