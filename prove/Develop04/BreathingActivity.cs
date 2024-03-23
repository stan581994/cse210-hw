public class BreathingActivity : Activity
{

    public BreathingActivity(string name, string _description) : base(name, _description)
    {
    }

    public void Run()
    {

        DisplayStartingMessage();
        BreatheExercise(GetDuration());
        DisplayEndingMessage();



    }

    private void BreatheExercise(int sec)
    {
        int totalDuration = GetDuration();

        // Assuming a default number of sets (e.g., 5)
        Random random = new Random();
        int sets = random.Next(3, 5);

        // Calculate duration for each inhale-exhale cycle
        int cycleDuration = totalDuration / sets;


        for (int i = 0; i < sets; i++)
        {
            int inhaleDuration = random.Next(2, cycleDuration); // Random inhale duration between 1 and cycleDuration
            int exhaleDuration = cycleDuration - inhaleDuration; // Exhale duration to complete the cycle

            Console.WriteLine();
            Console.Write("Breathe in...");
            ShowCountDown(inhaleDuration);
            Console.WriteLine();

            Console.Write("\nBreathe out...");
            ShowCountDown(exhaleDuration);
            Console.WriteLine();
        }
    }
}