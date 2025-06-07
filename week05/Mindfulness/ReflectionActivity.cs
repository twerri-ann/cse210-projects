class ReflectionActivity : MindfulnessActivity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity()
    {
        name = "Reflection Activity";
        description = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
    }

    protected override void PerformActivity()
    {
        Random rand = new Random();
        Console.WriteLine(prompts[rand.Next(prompts.Length)]);
        Spinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(questions[rand.Next(questions.Length)]);
            Spinner(5);
        }
    }
}