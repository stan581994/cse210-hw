using System;

class Program
{
    static void Main(string[] args)
    {

        int response = 0; 
        string desc="";

        do {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            response = int.Parse(Console.ReadLine());

            switch (response){
                case 1:
                    Console.Clear();
                    desc="This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                    BreathingActivity breathingActivity = new BreathingActivity("Breathing",desc);
                    breathingActivity.Run();
                    break;
                case 2:
                    Console.Clear();
                    desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting",desc);
                    reflectingActivity.Run();
                    break;
                case 3:
                    break;

            }



        }while (response != 4);

    }
}