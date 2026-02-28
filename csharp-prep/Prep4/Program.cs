using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> ns = new List<int>();
        
        int U = -1;
        while (U != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string R = Console.ReadLine();
            U = int.Parse(R);
            
            
            if (U != 0)
            {
                ns.Add(U);
            }
        }

        int s = 0;
        foreach (int n in ns)
        {
            s += n;
        }

        Console.WriteLine($"The sum is: {s}");

        
        float average = ((float)s) / ns.Count;
        Console.WriteLine($"The average is: {average}");

       
        
        int M = ns[0];

        foreach (int n in ns)
        {
            if (n > M)
            {
               
                M = n;
            }
        }

        Console.WriteLine($"The largest number is: {M}");
    }
}