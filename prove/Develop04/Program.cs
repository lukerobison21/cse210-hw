using System;

class Program
{
    static void Main(string[] args)
    {
        int breathingCount = 0;
        int reflectionCount = 0;
        int listingCount = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
                breathingCount++;
            }
            else if (choice == "2")
            {
                new ReflectionActivity().Run();
                reflectionCount++;
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
                listingCount++;
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("Activity log:");
                Console.WriteLine($"- Breathing Activity: {breathingCount}");
                Console.WriteLine($"- Reflection Activity: {reflectionCount}");
                Console.WriteLine($"- Listing Activity: {listingCount}");
                Console.WriteLine("\nPress Enter to quit...");
                Console.ReadLine();
                break;
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
