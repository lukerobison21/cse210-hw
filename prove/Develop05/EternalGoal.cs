using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
        : base(name, desc, points)
    {
    }

    public EternalGoal(string[] data)
        : base(data[1], data[2], int.Parse(data[3]))
    {
    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override string GetDetails()
    {
        return $"[∞] {_name} ({_description})";
    }

    public override string GetString()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }
}