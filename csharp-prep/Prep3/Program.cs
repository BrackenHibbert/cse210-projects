using System;

class Program
{
    static void Main(string[] args)
    {
        string answer = ("incorrect");

        Console.WriteLine("What is the Magic Number? ");
            string response = Console.ReadLine();
            int magicNumber = int.Parse(response);

        while (answer == "incorrect")
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            int numberGuess = int.Parse(guess);

            if (numberGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            if (numberGuess < magicNumber);
            {
                Console.WriteLine("Higher");
            }

            if (numberGuess == magicNumber);
            {
                response = ("correct");
            }
        }
        Console.WriteLine("Correct! You win the game.");
    }
}