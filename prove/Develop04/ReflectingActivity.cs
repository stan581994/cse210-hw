using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string desc) : base(name, desc)
    {
        String filenamePrompt = "..\\..\\..\\util\\prompts.txt";
        String filenameQuestions = "..\\..\\..\\util\\questions.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        string filePathQuestions = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenameQuestions);

        string[] linesPrompt = System.IO.File.ReadAllLines(filePathPrompts);
        string[] linesQuestion = System.IO.File.ReadAllLines(filePathQuestions);

        foreach (String prompt in linesPrompt)
        {
            _prompts.Add(prompt);
        }

        foreach (String questions in linesQuestion)
        {
            _questions.Add(questions);
        }

    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DisplayQuestion();
        DisplayEndingMessage();

    }

    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0, _questions.Count);
        return _questions[index];

    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"\n---{GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();


    }

    private void DisplayQuestion()
    {

        Console.Clear();
        int totalDuration = GetDuration();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(totalDuration);
        List<string> usedQuestions = new List<string>();
        string displayQuestion = "";
        Random random = new Random();
        int remainingTime = totalDuration;

        while (DateTime.Now < futureTime)
        {
            int questionDuration = random.Next(3, remainingTime);

            do
            {
                displayQuestion = GetRandomQuestion();
            } while (usedQuestions.Contains(displayQuestion));

            // Add the question to the list of used questions
            usedQuestions.Add(displayQuestion);


            Console.Write($"{displayQuestion} ");
            ShowSpinner(questionDuration);
            Console.WriteLine("\n\n");
            remainingTime -= questionDuration;
            if (remainingTime <= 0)
            {
                break;
            }


            Thread.Sleep(1000);

        }
    }
}