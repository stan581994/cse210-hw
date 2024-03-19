using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment = new Assignment("Roberto Rodriguez", "Fractions");
        MathAssignment mathAssignment = new MathAssignment("7.3","8-19",assignment);


        Console.WriteLine(mathAssignment.getSummary());
        Console.WriteLine(mathAssignment.getHomeWorkList());


         Assignment assignment2 = new Assignment("Mary Waters", "European History");
         WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II by Mary Waters", assignment2);
        
         Console.WriteLine(writingAssignment.getSummary());
         Console.WriteLine(writingAssignment.getWritingInformation());
    }
}