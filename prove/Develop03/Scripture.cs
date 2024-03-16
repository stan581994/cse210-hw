using System.Text;
public class Scripture{
    private Reference reference;
    private List<Word> words = new List<Word>();

    private bool _isCompletelyHidden = false;

    private int sizeOfAllHiddenWords = 0;

    private int sizeOfAllWords = 0;

    public Scripture(Reference reference, string text){
        this.reference = reference;
        String[] verseWords = text.Split(" ");
        foreach (string verse in verseWords) {
            Word word = new Word(verse);
            words.Add(word);
        } 

        sizeOfAllWords = words.Count;
        

    }

    public void hideRandomWords(int numbersToHide){
        Random random = new Random();
        int randomIndex = 0;
        

        if (numbersToHide <= (sizeOfAllWords - sizeOfAllHiddenWords)){

            for (int i = 0; i<numbersToHide; i++){

                do{
                    randomIndex =  random.Next(0, words.Count);
                
                }while(words[randomIndex].isHidden());

                sizeOfAllHiddenWords++;

                words[randomIndex].hide();

                if(sizeOfAllHiddenWords == sizeOfAllWords){
                 _isCompletelyHidden = true;
                 
                }
            }
        } else {
            int numbersToHideRemaining = sizeOfAllWords - sizeOfAllHiddenWords;

            for(int  i = 0; i< numbersToHideRemaining;i++ ){
                do {
                    randomIndex =  random.Next(0, words.Count);
                }while(words[randomIndex].isHidden());

                sizeOfAllHiddenWords++;

                words[randomIndex].hide();

                Console.WriteLine($"{sizeOfAllHiddenWords} == {sizeOfAllWords}");

                if(sizeOfAllHiddenWords == sizeOfAllWords){
                    _isCompletelyHidden = true;
                }
            }

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