using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letterGrade = "";

        if (number >= 90)
        {
            letterGrade = "A";
        }
        else if (number >= 80)
        {
            letterGrade = "B";
        }
        else if (number >= 70)
        {
            letterGrade = "C";
        }
        else if (number >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your Grade in the class is {letterGrade}.");

        if (number >= 70)
        {
            Console.WriteLine("You Passed the Class! Congratulations.");
        }
        else
        {
            Console.WriteLine("You did not pass the class, better luck next time!");
        }
    }
}