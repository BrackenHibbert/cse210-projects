using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int numberGuess = -1;

        while (numberGuess != number)
        {
            Console.WriteLine("What is your guess? ");
            numberGuess = int.Parse(Console.ReadLine());

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
                Console.WriteLine("Correct! You win the game.");
            }
        }
    }
}