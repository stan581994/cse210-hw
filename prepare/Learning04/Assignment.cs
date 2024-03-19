public class Assignment {

    private string _studentName;
    private string _topic;

    public Assignment(Assignment assignment){
        _studentName = assignment.getStudentName();
        _topic = assignment.getTopic();
    }


    public Assignment(string _studentName, string _topic){
        this._studentName = _studentName;
        this._topic = _topic;
    }

    public string getSummary(){
        return $"{_studentName} - {_topic}";
    }

    public string getStudentName(){
        return _studentName;
    }

    public string getTopic(){
        return _topic;
    }


}