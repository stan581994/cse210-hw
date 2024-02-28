using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numberList = new List<int>();
        int userInput;
        int sum = 0;
        int highestNumber = int.MinValue;

        do {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
                numberList.Add(userInput);
        
        }while(userInput != 0);

        for (int i = 0; i < numberList.Count; i++){
            sum += numberList[i];
            if (highestNumber < numberList[i]){
                highestNumber = numberList[i];
            }
        }
        Console.WriteLine("The sum is : " + sum);
        Console.WriteLine($"The average is : {(float)sum / numberList.Count} ");
        Console.WriteLine($"The largest Number is : {highestNumber}");


    }
}

