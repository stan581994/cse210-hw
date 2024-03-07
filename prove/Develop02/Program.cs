using System;

class Program
{
    static void Main(string[] args)
    {

        RandomQuestionGenerator _randomQuestionGenerator = new RandomQuestionGenerator(); 
        Notebook myNotebook = new Notebook();

        int userPrompt;

        do {

            Console.WriteLine("Please select one of the following choices: "); 
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load ");
            Console.WriteLine("4. Save ");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userPrompt = int.Parse(Console.ReadLine());

            switch (userPrompt){
                case 1:
                    Page newPage = new Page();
                    newPage._question =  _randomQuestionGenerator.generateRandomQuestions();
                    Console.WriteLine(newPage._question);
                    newPage._answer = Console.ReadLine();
                    newPage._date = DateTime.Now.ToShortDateString();
                    Console.WriteLine("You chose to Write.");
                    myNotebook._pages.Add(newPage);
                    break;

                case 2:
                    Console.WriteLine("You chose to Display.");
                    myNotebook.display();
                    break;

                case 3:
                    Console.WriteLine("You chose to Load.");
                    // Add your Load logic here
                    break;

                case 4:
                    Console.WriteLine("You chose to Save.");
                    // Add your Save logic here
                    break;

                case 5:
                    Console.WriteLine("Quitting the program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    // change the value to 1 in order to reset the loop again
                    userPrompt = 1; 
                    break;
            }

      
        }while(userPrompt != 5);

        

    }
}