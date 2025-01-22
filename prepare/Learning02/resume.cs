using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs;

    public Resume(string name)
    {
        this._name = name;
        this._jobs = new List<Job>();
    }
    
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}