using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        String firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        String lastName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {firstName}, {firstName} {lastName}");
    }
}