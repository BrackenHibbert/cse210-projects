using System;

public class JobDetails

{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2015";
        job1._endYear = "2018";

        Job job2 = new Job();
        job2._jobTitle = "Quality Assurance";
        job2._company = "Apple";
        job2._startYear = "2018";
        job2._endYear = "present";

        Resume resume = new Resume("Bracken Hibbert");
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.DisplayResume();

    }
}