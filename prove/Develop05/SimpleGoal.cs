public class SimpleGoal : Goal
{


    private bool _isComplete;

    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string shortName, string description, string points,string isCompleted) : base(shortName, description, points)
    {
        _isComplete = bool.Parse(isCompleted);
    }

     public override string GetDetailsString(){
        if (isComplete())
        {
            return $"[X] {GetShortname()} ({GetDescription()})";
        }
        else
        {
            return $"[ ] {GetShortname()} ({GetDescription()})";
        }

     }




    public override void RecordEvent()
    {
        _isComplete = true;

    }

    public override bool isComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "SimpleGoal";
    }
}