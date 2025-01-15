using System;

class Program
{
    static void Main(string[] args)
    {
        string gameLoop = ("continue");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        while (gameLoop == "continue")
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            int numberGuess = int.Parse(guess);

            if (numberGuess > number)
            {
                Console.WriteLine("Lower");
            }

            else if (numberGuess < number)
            {
                Console.WriteLine("Higher");
            }

            else
            {
                gameLoop = "stop";
            }
        }
        Console.WriteLine("Correct! You win the game.");
    }
}