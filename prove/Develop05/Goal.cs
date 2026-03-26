using System;

public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string desc, int points)
    {
        _name = name;
        _description = desc;
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract int RecordEvent();
    public abstract string GetDetails();
    public abstract string GetString();
}