public class Page{
    public string _date;
    public string _question;
    public string _answer;

    public void displayPage(){
        Console.WriteLine($"Date {_date} - Prompt: {_question}");
        Console.WriteLine($"{_answer}");
    }
}