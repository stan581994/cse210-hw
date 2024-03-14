using System.Text;
public class Scripture{
    private Reference reference;
    private List<Word> words = new List<Word>();

    private bool _isCompletelyHidden = false;

    private int sizeOfAllHiddenWords = 0;

    public Scripture(Reference reference, string text){
        this.reference = reference;
        String[] verseWords = text.Split(" ");
        foreach (string verse in verseWords) {
            Word word = new Word(verse);
            words.Add(word);
        } 

    }

    public void hideRandomWords(int numbersToHide){
        Random random = new Random();
        int randomIndex = 0;

        for (int i = 0; i<3; i++){

            do{
                Console.WriteLine($"{sizeOfAllHiddenWords} == {words.Count-1}");
                if (sizeOfAllHiddenWords  == (words.Count - 1)){
                    _isCompletelyHidden = true;
                    break;
                }
                randomIndex =  random.Next(0, words.Count);
                if(words[randomIndex].isHidden()){
                    
                }
            }while( || sizeOfAllHiddenWords  == (words.Count - 1));
            sizeOfAllHiddenWords++;
            words[randomIndex].hide();
        }


    }

    public string getDisplayText(){
        StringBuilder stringBuilder = new StringBuilder();
        foreach(Word word in words){
            if(word.isHidden()){
                string replacement = new string('_', word.getDisplayText().Length);
                stringBuilder.Append(word.getDisplayText().Replace(word.getDisplayText(),replacement));
                stringBuilder.Append(" ");
            }else{
                stringBuilder.Append(word.getDisplayText());
                stringBuilder.Append(" ");
            }

        }
        return $"{reference.getDisplayText()} {stringBuilder.ToString()}";
    }

    public bool isCompletelyHidden(){
        return _isCompletelyHidden;
    }
}