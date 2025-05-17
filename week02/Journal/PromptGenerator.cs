using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private List<string> prompts;
    private Random rand = new Random();

    public PromptGenerator()
    {
        prompts = new List<string>
        {
            "What was the best part of my day?",
            "What made you smile today?",
            "Who was the most interesting person I interacted with today?",
            "What did you learn today?",
            "How did I see the hand of the Lord in my life today?",
            "What is something you're grateful for?",
            "What was the strongest emotion I felt today?",
            "What challenged you today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    public string GetRandomPrompt()
    {
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}
