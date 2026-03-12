using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();
        Reference ref1 = new Reference("Proverbs", 3, 5, 6);

    Scripture scripture1 = new Scripture(ref1,
    "Trust in the Lord with all thine heart and lean not unto thine own understanding");

    scriptures.Add(scripture1);

    Reference ref2 = new Reference("James", 1, 5);

    Scripture scripture2 = new Scripture(ref2,
    "If any of you lack wisdom let him ask of God that giveth to all men liberally and upbraideth not and it shall be given him");

    scriptures.Add(scripture2);

    Reference ref3 = new Reference("Ether", 12, 6);

    Scripture scripture3 = new Scripture(ref2,
    "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.");

    scriptures.Add(scripture3);
        
    Random rand = new Random();
    Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit'");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}