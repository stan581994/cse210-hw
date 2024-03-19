public class MathAssignment : Assignment{

    private string _textbookSection;
    private string _problems;

    public MathAssignment(string _textbookSection, string problems, Assignment assignment) : base(assignment){
        this._textbookSection = _textbookSection;
        this._problems = problems;
        
    }

    public string getHomeWorkList(){
       return $"Section {_textbookSection} Problems {_problems}";
    }
}