using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string uN = PromptuN();
        int userNumber = PromptUserNumber();

        int sn = sqNumber(userNumber);

        int bY;
        PromptUserbY(out bY);


        DisplayResult(uN, sn, bY);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptuN()
    {
        Console.Write("Please enter your name: ");
        string n = Console.ReadLine();

        return n;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    static void PromptUserbY(out int bY)
    {
        Console.Write($"Please enter the year you were born: ");
        bY = int.Parse(Console.ReadLine());

    }

    static int sqNumber(int number)
    {
        int sq = number * number;
        return sq;
    }

    static void DisplayResult(string n, int sq, int bY)
    {
        Console.WriteLine($"{n}, the sq of your number is {sq}.");
        Console.WriteLine($"{n}, you will turn {2026 - bY} years old this year.");
    }
}