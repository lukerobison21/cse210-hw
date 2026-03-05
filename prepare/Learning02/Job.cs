using System;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _firstYear;
    public int _lastYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_firstYear}-{_lastYear}");
    }
}