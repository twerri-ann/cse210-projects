using System;

abstract class MindfulnessActivity
{
    protected int duration;
    protected string name;
    protected string description;

    public void Run()
    {
        DisplayStartMessage();
        PrepareToBegin();
        PerformActivity();
        DisplayEndMessage();
    }

    public void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    protected void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"--- {name} ---");
        Console.WriteLine(description);
        SetDuration();
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine("\nWell done!");
        Spinner(3);
        Console.WriteLine($"\nYou completed the {name} for {duration} seconds.");
        Spinner(3);
    }

    protected void PrepareToBegin()
    {
        Console.WriteLine("\nGet ready to begin...");
        Spinner(3);
    }

    protected void Spinner(int seconds)
    {
        for (int i = 0; i < seconds * 2; i++)
        {
            Console.Write(".");
            Thread.Sleep(500);
        }
        Console.WriteLine();
    }

    protected void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected abstract void PerformActivity();
}