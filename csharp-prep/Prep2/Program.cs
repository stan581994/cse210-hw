using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade? ");
        String userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        String letterGrade;

        if(grade >= 90){
            letterGrade = "A";
        } 
        else if(grade >= 80){
            letterGrade = "B";
        }
        else if(grade >= 70){
           letterGrade = "c";
            
        }
        else if(grade >= 60){
            letterGrade = "D";
        }
        else{
            letterGrade = "F";
        }

        Console.WriteLine($"Your Letter Grade is {letterGrade}");
        if(grade == 70){
            Console.Write("Is the user passed? [y] or [n] ");
            String isItPassed = Console.ReadLine();
            if(isItPassed == "y"){
                Console.WriteLine("Congratulations, You are passed!"); 
            }else{
                Console.WriteLine("It's okay. Keep doing better next time!"); 
            }
        }


    }
}