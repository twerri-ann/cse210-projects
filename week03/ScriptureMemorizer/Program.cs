using System;

class Program
{
    static void Main()
    {
        string referenceText = "Ether 12:12";
        string scriptureText = "For if there be no faith among the children of men God can do no miracle among them; wherefore, he showed not himself until after their faith.";

        Reference reference = new Reference(referenceText);
        Scripture scripture = new Scripture(reference, scriptureText);

        while (!scripture.AllWordsHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine().Trim().ToLower();

            if (input == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 random words each time
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Program ending.");
    }
}
