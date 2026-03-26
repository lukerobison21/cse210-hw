using System;

public class ChecklistGoal : Goal
{
    private int _count;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus)
        : base(name, desc, points)
    {
        _target = target;
        _bonus = bonus;
        _count = 0;
    }

    public ChecklistGoal(string[] data)
        : base(data[1], data[2], int.Parse(data[3]))
    {
        _count = int.Parse(data[4]);
        _target = int.Parse(data[5]);
        _bonus = int.Parse(data[6]);
    }

    public override int RecordEvent()
    {
        _count++;
        if (_count == _target)
        {
            return _points + _bonus;
        }
        return _points;
    }

    public override string GetDetails()
    {
        return $"[{(_count >= _target ? "X" : " ")}] {_name} ({_description}) -- Completed {_count}/{_target}";
    }

    public override string GetString()
    {
        return $"ChecklistGoal|{_name}|{_description}|{_points}|{_count}|{_target}|{_bonus}";
    }
}