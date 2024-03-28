public abstract class Goal {

    private string _shortName;
    private string _description;
    private string _points;


    public Goal (string name, string description, string point){
        _shortName = name;
        _description = description;
        _points = point;
    }
    public abstract void RecordEvent();

    public abstract bool isComplete();

    public virtual string GetDetailsString(){
        return $"[ ] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();

    public string GetShortname(){
        return _shortName;
    }

    public string GetDescription(){
        return _description;
    }

    public string GetPoints(){
        return _points;
    }

    public void SetPoints(int point){
        
        int currentPoints = int.Parse(_points);
        int totalPoints = currentPoints + point;
        _points = totalPoints.ToString();

    }


}