public class Activity
{

    private string _name;
    private string _description;
    private int _duration;

    public Activity()
    {

    }
    public Activity(string _name, string _description)
    {
        this._name = _name;
        this._description = _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

    }

    public void DisplayEndingMessage()
    {

        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} Activity.");
        ShowSpinner(5);

    }
    public void ShowSpinner(int seconds)
    {

        List<string> animationStrings = new List<string> { "/", "-", "|", "\\", "|" };
        for (int i = seconds; i > 0; i--)
        {
            foreach (string str in animationStrings)
            {
                Console.Write(str);
                System.Threading.Thread.Sleep(200); // Adjust delay for animation speed
                Console.Write("\b \b"); // Erase the + character
            }



        }


    }
    public void ShowCountDown(int seconds)
    {

        for(int i = seconds; i>0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }





}