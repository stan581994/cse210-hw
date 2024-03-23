public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    private List<string> _userLists = new List<string>();
    private int _count;

    public ListingActivity(string name, string desc) : base(name, desc)
    {
        String filenamePrompt = "..\\..\\..\\util\\listing.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        string[] linesPrompt = System.IO.File.ReadAllLines(filePathPrompts);
        foreach (String prompt in linesPrompt)
        {
            _prompts.Add(prompt);
        }


    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPromt();
        DisplayEndingMessage();

    }

    private void GetRandomPromt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        int totalDuration = GetDuration();
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(totalDuration);

        while (DateTime.Now < futureTime)
        {
            string response = Console.ReadLine();
            _userLists.Add(response);
            Thread.Sleep(1000);
        }

        Console.WriteLine($"You listed {GetListFromUser().Count} items!");


    }

    public List<string> GetListFromUser()
    {
        return _userLists;
    }


}