
public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private List<Rank> _ranks = new List<Rank>();
    private int _score;

    
    private string _rank;

    public GoalManager()
    {
        _rank = " none";
        IniatilizeRank();

    }

    public void Start()
    {
        int playerChoice;

        do
        {
            Console.WriteLine();
            DisplayPlayerInfo();

            Console.WriteLine();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal ");
            Console.WriteLine("  2. List Goals ");
            Console.WriteLine("  3. Save Goals ");
            Console.WriteLine("  4. Load Goals ");
            Console.WriteLine("  5. Record Event ");
            Console.WriteLine("  6. Quit ");
            Console.Write("Select a choice from the menu: ");
            playerChoice = int.Parse(Console.ReadLine());

            switch (playerChoice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                default:
                    break;
            }

        } while (playerChoice != 6);





    }

    public void DisplayPlayerInfo()
    {
        if (_score > 0){
            _rank = UpdatePlayerRankBasedOnPoints();
        }
        Console.WriteLine($"You have {_score} points.");
        Console.WriteLine($"Rank: {_rank}");
    }

    private string UpdatePlayerRankBasedOnPoints()
    {
        string newRank = "none";
        foreach(Rank rank in _ranks){
            if(int.Parse(rank.GetPointNeeded()) <= _score){
                newRank = rank.GetRank();
            }
        }

        return newRank;
    }

    private void IniatilizeRank(){
        string filenamePrompt = $"..\\..\\..\\ranking\\rank.txt";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        string[] linesPrompt = System.IO.File.ReadAllLines(filePathPrompts);
        foreach (String prompt in linesPrompt)
        {
            string[] lines  = prompt.Split(",");
            Rank rank = new Rank(lines[0],lines[1]);
            _ranks.Add(rank);
            
        }

    }

    public void ListGoalNames()
    {
        int counter = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{counter}. {goal.GetShortname()}");
            counter++;
        }

    }

    public void ListGoalDetails()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are: ");
        int counter = 1;
        foreach (Goal goal in _goals)
        {

            Console.WriteLine($"{counter}. {goal.GetDetailsString()}");
            counter = counter + 1;
        }

    }

    public void CreateGoal()
    {
        int playerChoice;
        Goal goal;

        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("   1. Simple Goal ");
        Console.WriteLine("   2. Eternal Goal ");
        Console.WriteLine("   3. Checklist Goal ");
        Console.Write("Which type of goal would you like to create? ");
        playerChoice = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is the short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amout of point associated with this goal? ");
        string point = Console.ReadLine();

        switch (playerChoice)
        {
            case 1:
                goal = new SimpleGoal(goalName, description, point);
                _goals.Add(goal);
                break;
            case 2:
                goal = new EternalGoal(goalName, description, point);
                _goals.Add(goal);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonusTarget = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(goalName, description, point, target, bonusTarget);
                _goals.Add(goal);
                break;


        }



    }

    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are ");
        ListGoalNames();

        Console.Write("Which goal did you accomplish? ");
        int response = int.Parse(Console.ReadLine());
        _goals[response - 1].RecordEvent();
        _score = _score + int.Parse(_goals[response-1].GetPoints());
        Console.WriteLine($"You now have {_score} points.");
        Console.WriteLine();



    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"..\\..\\..\\goal\\{filename}");

        using (StreamWriter outputFile = new StreamWriter(filePath))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                if (goal is SimpleGoal)
                {
                    outputFile.WriteLine($"{goal.GetStringRepresentation()}:{goal.GetShortname()},{goal.GetDescription()},{goal.GetPoints()},{goal.isComplete()}");
                }
                else if (goal is EternalGoal)
                {
                    outputFile.WriteLine($"EternalGoal:{goal.GetShortname()},{goal.GetDescription()},{goal.GetPoints()}");
                }
                else
                {
                    outputFile.WriteLine($"ChecklistGoal:{goal.GetShortname()},{goal.GetDescription()},{goal.GetPoints()},{((ChecklistGoal)goal).GetBonus()},{((ChecklistGoal)goal).GetTarget()},{((ChecklistGoal)goal).GetAmountCompleted()}");
                }

            }

        }
        Console.Write("");




    }

    public void LoadGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();
        string filenamePrompt = $"..\\..\\..\\goal\\{filename}";
        string filePathPrompts = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filenamePrompt);
        string[] linesPrompt = System.IO.File.ReadAllLines(filePathPrompts);
        bool skipTheFirstLine = true;
        foreach (String prompt in linesPrompt)
        {
            if (skipTheFirstLine)
            {
                _score = int.Parse(prompt);
                skipTheFirstLine = false;
                continue;
            }

            string[] line = prompt.Split(":");

            if (line[0] == "SimpleGoal")
            {
                string[] properties = line[1].Split(",");
                SimpleGoal simpleGoal = new SimpleGoal(properties[0], properties[1], properties[2], properties[3]);
                _goals.Add(simpleGoal);
            }
            else if (line[0] == "EternalGoal")
            {
                string[] properties = line[1].Split(",");
                EternalGoal eternalGoal = new EternalGoal(properties[0], properties[1], properties[2]);
                _goals.Add(eternalGoal);
            }
            else
            {
                string[] properties = line[1].Split(",");
                ChecklistGoal checklistGoal = new ChecklistGoal(properties[0], properties[1], properties[2], int.Parse(properties[3]), int.Parse(properties[4]), int.Parse(properties[5]));
                _goals.Add(checklistGoal);
            }

        }

    }
}