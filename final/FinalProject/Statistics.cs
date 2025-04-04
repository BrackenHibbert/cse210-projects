public class Statistics : AdvancedMath
{
    // Attributes


    // Initializors


    // Methods

    public void SelectStat()
    {
        Console.Clear();
        Console.WriteLine("1. Median");
        Console.WriteLine("2. Mean");
        Console.WriteLine("3. Standard Deviation");
        Console.WriteLine("4. Probability");
        Console.WriteLine();
        Console.Write("Select Statistic Type: ");
        string type = Console.ReadLine();
        Console.WriteLine();

        if (type == "1")
        {
            Median();
        }
        else if (type == "2")
        {
            Mean();
        }
        else if (type == "3")
        {
            StandardDev();
        }
        else if (type == "4")
        {
            Probability();
        }
    }

    static void Median()
    {
        // Ask the user how many numbers they'll input
        Console.Write("How many numbers are in your dataset? ");
        int count = int.Parse(Console.ReadLine());

        // Create an array to hold the numbers
        double[] values = new double[count];

        // Prompt the user to input each number
        Console.WriteLine("Please enter your numbers:");
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Number {i + 1}: ");
            values[i] = double.Parse(Console.ReadLine());
        }

        // Sort the array
        Array.Sort(values);

        // Calculate and return the median
        if (values.Length % 2 == 1)
        {
            // Odd number of elements: return the middle one
            Console.WriteLine(values[values.Length / 2]);
            Console.ReadLine();
        }
        else
        {
            // Even number of elements: return the average of the two middle ones
            Console.WriteLine((values[(values.Length / 2) - 1] + values[values.Length / 2]) / 2.0);
            Console.ReadLine();
        }
    }


    static void Mean()
    {
        // Ask the user how many numbers they'll input
        Console.Write("How many numbers are in your dataset? ");
        int count = int.Parse(Console.ReadLine());

        // Create an array to hold the numbers
        double[] values = new double[count];

        // Prompt the user to input each number
        Console.WriteLine("Please enter your numbers:");
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Number {i + 1}: ");
            values[i] = double.Parse(Console.ReadLine());
        }

        // Calculate the mean
        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += values[i];
        }

        double mean = sum / count;

        Console.WriteLine(mean); // Return the calculated mean
        Console.ReadLine();
    }

    static void StandardDev()
    {
        // Ask the user how many numbers they'll input
        Console.Write("How many numbers are in your dataset? ");
        int count = int.Parse(Console.ReadLine());

        // Create an array to hold the numbers
        double[] values = new double[count];

        // Prompt the user to input each number
        Console.WriteLine("Please enter your numbers:");
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Number {i + 1}: ");
            values[i] = double.Parse(Console.ReadLine());
        }

        // Calculate the mean
        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += values[i];
        }
        double mean = sum / count;

        // Calculate the variance
        double varianceSum = 0;
        for (int i = 0; i < count; i++)
        {
            varianceSum += Math.Pow(values[i] - mean, 2);
        }
        double variance = varianceSum / count;

        // Calculate the standard deviation
        double standardDeviation = Math.Sqrt(variance);

        Console.WriteLine(standardDeviation);
        Console.ReadLine();
    }


    static void Probability()
    {
        // Ask the user for the number of favorable outcomes
        Console.Write("Enter the number of favorable outcomes: ");
        int favorableOutcomes = int.Parse(Console.ReadLine());

        // Ask the user for the total number of possible outcomes
        Console.Write("Enter the total number of possible outcomes: ");
        int totalOutcomes = int.Parse(Console.ReadLine());

        // Ensure valid input
        if (favorableOutcomes > totalOutcomes || totalOutcomes <= 0 || favorableOutcomes < 0)
        {
            Console.WriteLine("Invalid input. Please make sure favorable outcomes are less than or equal to total outcomes, and both are non-negative.");
            Console.WriteLine(-1);
            Console.ReadLine(); // Return an invalid flag
        }

        // Calculate probability
        double probability = (double)favorableOutcomes / totalOutcomes;
        Console.WriteLine(probability); // Return the calculated probability
        Console.ReadLine();
    }
}