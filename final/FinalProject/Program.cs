using System;

class Program
{
    static void Main(string[] args)
    {
        ActivityManager manager = new ActivityManager();

        manager.CreateSampleActivities();
        manager.DisplayActivities();

        Console.WriteLine("Program ran successfully.");
    }
}