class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity()
    {
        name = "Breathing Activity";
        description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    protected override void PerformActivity()
    {
        int cycleTime = 6; // 3 in, 3 out
        int cycles = duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            Countdown(3);
            Console.Write("Breathe out... ");
            Countdown(3);
        }
    }
}