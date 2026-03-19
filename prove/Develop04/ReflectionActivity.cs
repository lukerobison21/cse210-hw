using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "--Think of a time you helped someone.--",
        "--Think of a time you overcame something difficult.--",
        "--Think of a time you showed strength.--",
        "--Think of a time you did something selfless.--"
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?",
        "What made this possible?",
        "How can you apply this again?"
    };

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can ues it in other aspects of your life. ")
    { }

    public void Run()
    {
        Start();

        Random rand = new Random();
        Console.WriteLine("\n" + _prompts[rand.Next(_prompts.Count)]);

        Console.WriteLine("\nConsider the following prompt:");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine($"> {question}");
            ShowSpinner(5);
        
        End();
    }
    }
}