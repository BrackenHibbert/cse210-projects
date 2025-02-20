using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning04 World!");

        Assignment assignment = new Assignment("Samuel Bennet", "Multiplication");

        Console.WriteLine(assignment.GetSummary());
        
        MathAssignment mathassignment = new MathAssignment("Roberto Rodriquez", "Fractions", "Section 7.3", "Problems 8-19");

        Console.WriteLine(mathassignment.GetSummary());
        Console.WriteLine(mathassignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War 2");

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}