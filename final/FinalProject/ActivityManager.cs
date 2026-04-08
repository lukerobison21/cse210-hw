using System;
using System.Collections.Generic;
using System.IO;

public class ActivityManager
{
    private List<Activity> _activities = new List<Activity>();

    public void AddRunning()
    {
        Console.Write("Date: ");
        string date = Console.ReadLine();

        Console.Write("Minutes: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Distance: ");
        double dist = double.Parse(Console.ReadLine());

        _activities.Add(new Running(date, min, dist));
    }

    public void AddCycling()
    {
        Console.Write("Date: ");
        string date = Console.ReadLine();

        Console.Write("Minutes: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Speed: ");
        double speed = double.Parse(Console.ReadLine());

        _activities.Add(new Cycling(date, min, speed));
    }

    public void AddSwimming()
    {
        Console.Write("Date: ");
        string date = Console.ReadLine();

        Console.Write("Minutes: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Laps: ");
        int laps = int.Parse(Console.ReadLine());

        _activities.Add(new Swimming(date, min, laps));
    }

    public void DisplayActivities()
    {
        foreach (Activity a in _activities)
        {
            Console.WriteLine(a.GetSummary());
            Console.WriteLine($"Distance: {a.GetDistance():0.00}");
            Console.WriteLine($"Speed: {a.GetSpeed():0.00}");
            Console.WriteLine($"Calories: {a.GetCalories():0.00}");
            Console.WriteLine();
        }
    }

    public void SaveToFile()
    {
        using StreamWriter writer = new StreamWriter("activities.txt");

        foreach (Activity a in _activities)
        {
            writer.WriteLine(a.ToFileString());
        }

        Console.WriteLine("Saved!");
    }

    public void LoadFromFile()
    {
        _activities.Clear();

        if (!File.Exists("activities.txt"))
            return;

        string[] lines = File.ReadAllLines("activities.txt");

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');

            string type = parts[0];
            string date = parts[1];
            int minutes = int.Parse(parts[2]);

            if (type == "Running")
                _activities.Add(new Running(date, minutes, double.Parse(parts[3])));

            else if (type == "Cycling")
                _activities.Add(new Cycling(date, minutes, double.Parse(parts[3])));

            else if (type == "Swimming")
                _activities.Add(new Swimming(date, minutes, int.Parse(parts[3])));
        }

        Console.WriteLine("Loaded!");
    }
}