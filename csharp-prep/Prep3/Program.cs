using System;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
    
        int magicNumber = rnd.Next(20);
        bool continueLoop = true;

        do{
            Console.Write("What is your guess? ");
            int guessNumber = int.Parse(Console.ReadLine());

            if (guessNumber == magicNumber){
                Console.Write("You guessed it!");
                continueLoop = false;
            }
            else if (guessNumber > magicNumber){
                Console.WriteLine("Lower");
            }else{
                Console.WriteLine("Higher");
            }
        }while(continueLoop);
    }
}
