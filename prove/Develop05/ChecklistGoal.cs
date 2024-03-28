
public class ChecklistGoal : Goal
{

    private int _amountCompleted;
    private int _target;

    private int _bonus;

    public ChecklistGoal(string name, string description, string point, int target, int bonus) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, string point, int bonus, int target, int amountCompleted) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override string GetStringRepresentation()
    {
        return "ChecklistGoal";
    }

    public override bool isComplete()
    {
        return _target == _amountCompleted;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Congratulations! You have earned {int.Parse(GetPoints()) + _bonus} points!");
            SetPoints(_bonus);
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }

    }

    public override string GetDetailsString()
    {
        if (isComplete())
        {
            return $"[X] {GetShortname()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {GetShortname()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
        }

    }

    public int GetTarget()
    {
        return _target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }


}