using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != mNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (mNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (mNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}