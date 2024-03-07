using System.Collections;

public class Resume{

    public String _firstName;
    public String _lastName;

    public List<Job> _jobs = new List<Job>();

    public void display(){
        Console.WriteLine($"Name: {_firstName}  {_lastName}");
        foreach (var job in _jobs)
        {
            job.display();
        }
    }
}