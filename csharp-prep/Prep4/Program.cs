using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int numberInput = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            numberInput = int.Parse(Console.ReadLine());
            Console.WriteLine();
            numbers.Add(numberInput);
        } while (numberInput != 0);

        float sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        };
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        float largestNumber = -100;
        foreach (int num in numbers)
        {
            if (num > largestNumber)
            {
                largestNumber =num;
            }
        }
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}