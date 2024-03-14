using System;

class Program
{
    static void Main(string[] args)
    {
        string verse = "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Reference reference = new Reference("Proverbs",3,5,6);
        Scripture scripture = new Scripture(reference,verse);
        string response = "";
        bool hideFewWords = false;

        do {

            if(hideFewWords){
                scripture.hideRandomWords(3);
            }

          //  Console.Clear();
            Console.WriteLine(scripture.getDisplayText());
            Console.WriteLine(" ");
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            response = Console.ReadLine();
            hideFewWords = true;



        }while(response != "quit" || scripture.isCompletelyHidden());
       
    }
}