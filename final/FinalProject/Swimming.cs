public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 0.05;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetCalories()
    {
        return _minutes * 11;
    }

    public override string GetSummary()
    {
        return $"Swimming | {_date} | {_minutes} min | {_laps} laps";
    }

    public override string ToFileString()
    {
        return $"Swimming,{_date},{_minutes},{_laps}";
    }
}