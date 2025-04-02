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

    public void Median()
    {
        ;
    }

    public void Mean()
    {
        ;
    }

    public void StandardDev()
    {
        ;
    }

    public void Probability()
    {
        ;
    }
}