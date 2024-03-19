public class WritingAssignment : Assignment{

    private string _title;

    public WritingAssignment(string title, Assignment assignment) : base (assignment){
        _title = title;
    }

    public string getWritingInformation(){
        return $"{_title}";
    }
} 