using System;

class Program
{
    static void Main(string[] args)
    {
        ActivityManager manager = new ActivityManager();

        bool running = true;

        while (running)
        {
            Console.WriteLine("=== FITNESS TRACKER ===");
            Console.WriteLine("1. Add Running");
            Console.WriteLine("2. Add Cycling");
            Console.WriteLine("3. Add Swimming");
            Console.WriteLine("4. View Activities");
            Console.WriteLine("5. Save Activities");
            Console.WriteLine("6. Load Activities");
            Console.WriteLine("7. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.AddRunning();
                    break;
                case "2":
                    manager.AddCycling();
                    break;
                case "3":
                    manager.AddSwimming();
                    break;
                case "4":
                    manager.DisplayActivities();
                    break;
                case "5":
                    manager.SaveToFile();
                    break;
                case "6":
                    manager.LoadFromFile();
                    break;
                case "7":
                    running = false;
                    break;
            }

            Console.WriteLine();
        }
    }
}