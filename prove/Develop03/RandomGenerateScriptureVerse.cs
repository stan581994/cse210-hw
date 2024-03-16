using System;
using System.IO; 
public class RandomGenerateScriptureVerse{

    private List<string> _scriptureVerses = new List<string>();
    private Scripture _scripture;

    public RandomGenerateScriptureVerse(){
        String filename = "..\\..\\..\\scripture_verse.txt";
        string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filename);

        string[] lines = System.IO.File.ReadAllLines(filePath);

        foreach(String scriptureVerse in lines){
            _scriptureVerses.Add(scriptureVerse);
        }

    }
 
    public Scripture generateRandomScriptureVerse(){

        Random random = new Random();
        int index = random.Next(0, _scriptureVerses.Count);
        string[] parts = _scriptureVerses[index].Split(";");
        Reference reference;
        if(parts[3] == "0"){
            reference = new Reference(parts[0],int.Parse(parts[1]),int.Parse(parts[2]));
        }else{
            reference = new Reference(parts[0],int.Parse(parts[1]),int.Parse(parts[2]),int.Parse(parts[3]));
        }
        _scripture = new Scripture(reference,parts[4]);
        return _scripture;
    }
}