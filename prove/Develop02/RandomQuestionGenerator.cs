public class RandomQuestionGenerator{

    public List<string> _randomQuestions = new List<string>();

    public RandomQuestionGenerator(){
        string filename = "D:\\BYU Idaho\\cse210\\prove\\Develop02\\prompt\\randomQuestions.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach(string line in lines){
            _randomQuestions.Add(line);
        }

    }
    public string generateRandomQuestions(){
        return _randomQuestions[new Random().Next(0,10)];
    }
}