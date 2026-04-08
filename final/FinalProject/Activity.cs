public class Activity
{
    protected string _date;
    protected int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance() { return 0; }
    public virtual double GetSpeed() { return 0; }
    public virtual double GetCalories() { return 0; }

    public virtual string GetSummary()
    {
        return $"{_date} {_minutes} min";
    }

    // Used for saving to file
    public virtual string ToFileString()
    {
        return "";
    }
}