using System;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        bool hideFewWords = false;

        RandomGenerateScriptureVerse randomGenerateScriptureVerse = new RandomGenerateScriptureVerse();
        Scripture scripture = randomGenerateScriptureVerse.generateRandomScriptureVerse();

        do {

            if(hideFewWords){
                scripture.hideRandomWords(3);
            }

            Console.Clear();
            Console.WriteLine(scripture.getDisplayText());
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            if( scripture.isCompletelyHidden()){
                break;
            }
            response = Console.ReadLine();
            hideFewWords = true;



        }while(response != "quit" );
       
    }
}