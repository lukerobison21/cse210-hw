using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your Grade Percentage ");
        string answer = Console.ReadLine();
        int x = int.Parse(answer);
        string grade=" ";
        string sign=" ";
        bool a = false;
        if (x >= 90)
        {
            grade="A";
        }
        else if (x >= 80)
        {
            grade="B";
            a=true;
        }
        else if (x >= 70)
        {
            grade="C";
            a=true;
        }
        else if (x >= 60)
        {
            grade="D";
            a=true;
        }
        else
        {
            grade="F";
        }
        if (a)
        {
            int y=x%10;
            if (y >= 7)
            {
                sign="+";
            }
            else if (y <= 3)
            {
                sign="-";
            }
        }
        Console.WriteLine($"you got a {grade}{sign}");
    }
}