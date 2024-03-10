using System;
using System.IO; 

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
                    Console.WriteLine("What is the name of the file? ");
                    string _Loadfilename =  Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(_Loadfilename);


                    foreach (string line in lines)
                    {
                        Page page = new Page();
                        string[] parts = line.Split(",");

                        page._date = parts[0];
                        page._question = parts[1];
                        page._answer = parts[2];

                        myNotebook._pages.Add(page);
                    
                    }

                    break;

                case 4:

                    try{

                        Console.WriteLine("What is the filename? ");
                        string _filename = Console.ReadLine();
                        using (StreamWriter outputFile = new StreamWriter(filename_path))
                        
                        foreach (Page page in myNotebook._pages){
                            outputFile.WriteLine($"{page._date},{page._question},{page._answer}");
                        }

                        Console.WriteLine($"File {_filename} created successfully.");
                        

                    } catch (Exception ex) {
                        Console.WriteLine($"Error creating the file: {ex.Message}");
                    }
                    
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