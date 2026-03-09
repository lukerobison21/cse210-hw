using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction a = new Fraction();
        Console.WriteLine(a.GetFractionString());
        Console.WriteLine(a.GetDecimal());

        Fraction b = new Fraction(9);
        Console.WriteLine(b.GetFractionString());
        Console.WriteLine(b.GetDecimal());

        Fraction c = new Fraction(5, 4);
        Console.WriteLine(c.GetFractionString());
        Console.WriteLine(c.GetDecimal());

        Fraction d = new Fraction(2, 3);
        Console.WriteLine(d.GetFractionString());
        Console.WriteLine(d.GetDecimal());

        Random random= new Random();
        Fraction f = new Fraction();
        for (int i = 0; i < 20; i++)
        {
            int topValue = random.Next(1, 11);
            int bottomValue = random.Next(1, 11);
            f.SetNum(topValue);
            f.SetDen(bottomValue);
            Console.Write($"Fraction {i + 1}: ");
            Console.Write($"string: {f.GetFractionString()}");
            Console.WriteLine($" Number: {f.GetDecimal()}");
        }
    }
}