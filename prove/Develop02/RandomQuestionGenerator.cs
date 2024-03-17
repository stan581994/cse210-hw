public class RandomQuestionGenerator{

    public List<string> _randomQuestions = new List<string>();

    public RandomQuestionGenerator(){
        String filename = "..\\..\\..\\prompt\\randomQuestions.txt";
        string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);
        string[] lines = System.IO.File.ReadAllLines(filePath);

        foreach(string line in lines){
            _randomQuestions.Add(line);
        }

    }
    public string generateRandomQuestions(){
        return _randomQuestions[new Random().Next(0,10)];
    }
}