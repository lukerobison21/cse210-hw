using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Pest Control Technichian";
        job1._company = "Fox";
        job1._firstYear = 2024;
        job1._lastYear = 2025;

        Job job2 = new Job();
        job2._jobTitle = "Track Manager";
        job2._company = "Rad Ray's Karts";
        job2._firstYear = 2022;
        job2._lastYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Luke Robison";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}