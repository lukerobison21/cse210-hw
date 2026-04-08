public class Running : Activity
{
    private double _distance;

    public Running(string date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance() => _distance;

    public override double GetSpeed()
    {
        return (_distance / _minutes) * 60;
    }

    public override double GetCalories()
    {
        return _minutes * 10;
    }

    public override string GetSummary()
    {
        return $"Running | {_date} | {_minutes} min | {_distance} miles";
    }

    public override string ToFileString()
    {
        return $"Running,{_date},{_minutes},{_distance}";
    }
}