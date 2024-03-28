public class EternalGoal : Goal {

    public EternalGoal(string name, string description, string point) : base(name,description,point){

    }

    public override string GetStringRepresentation()
    {
        return "EternalGoal";
    }

    public override bool isComplete()
    {
        throw new NotImplementedException();
    }

    public override void RecordEvent()
    {
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }
}