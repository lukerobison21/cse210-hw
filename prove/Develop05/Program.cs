using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static int GetLevel(int score)
{
    return score / 1000 + 1;
}
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        while (true)
        {
            int level = GetLevel(score);
            Console.WriteLine($"\nYou have {score} points (Level {level}).");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Load Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nThe Types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");

                string type = Console.ReadLine();

                Console.Write("What is the name of your goal: ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it: ");
                string desc = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {
                    goals.Add(new SimpleGoal(name, desc, points));
                }
                else if (type == "2")
                {
                    goals.Add(new EternalGoal(name, desc, points));
                }
                else if (type == "3")
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }

            else if (choice == "2")
            {
                int i = 1;
                foreach (Goal g in goals)
                {   
                    Console.WriteLine("The goals are:");
                    Console.WriteLine($"{i}. {g.GetDetails()}");
                    i++;
                }
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();

                goals.Clear();
                string[] lines = File.ReadAllLines(file);

                score = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split("|");

                    if (parts[0] == "SimpleGoal")
                        goals.Add(new SimpleGoal(parts));
                    else if (parts[0] == "EternalGoal")
                        goals.Add(new EternalGoal(parts));
                    else if (parts[0] == "ChecklistGoal")
                        goals.Add(new ChecklistGoal(parts));
                }
            }
            

            else if (choice == "4")
            {
                Console.Write("What is the filename for the goal file? ");
                string file = Console.ReadLine();

                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine(score);
                    foreach (Goal g in goals)
                    {
                        writer.WriteLine(g.GetString());
                    }
                }
            }

            else if (choice == "5")
            {
                Console.WriteLine("What goal did you accomplish?");
                for (int i = 0; i < goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
                }

                int index = int.Parse(Console.ReadLine()) - 1;
                int oldLevel = GetLevel(score);

                score += goals[index].RecordEvent();

                int newLevel = GetLevel(score);

                if (newLevel > oldLevel)
                {
                    Console.WriteLine($"\n🎉 LEVEL UP! You are now Level {newLevel}!");
                }
            }

            else if (choice == "6")
            {
                break;
            }
        }
    }
}