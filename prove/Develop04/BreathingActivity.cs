using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing")
    { }

    public void Run()
    {
        Start();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            Console.Write("\nBreathe in... ");
            ShowCountdown(4);
            Console.WriteLine();

            Console.Write("\nNow breathe out... ");
            ShowCountdown(4);
            Console.WriteLine();

            elapsed += 8;
        }

        End();
    }
}
