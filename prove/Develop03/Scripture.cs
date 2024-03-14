using System.Text;
public class Scripture{
    private Reference reference;
    private List<Word> words = new List<Word>();

    public Scripture(Reference reference, string text){
        this.reference = reference;
        String[] verseWords = text.Split(" ");
        foreach (string verse in verseWords) {
            Word word = new Word(verse);
            words.Add(word);
        } 

    }

    public void hideRandomWords(int numbersToHide){

    }

    public string getDisplayText(){
        StringBuilder stringBuilder = new StringBuilder();
        foreach(Word word in words){
            stringBuilder.Append(word.getDisplayText());
            stringBuilder.Append(" ");
        }
        return $"{reference.getDisplayText()} {stringBuilder.ToString()}";
    }

    public bool isCompletelyHidden(){
        return false;
    }
}