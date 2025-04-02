public class Functions : AdvancedMath
{
    // Attributes


    // Initializors


    // Methods
    public void SelectForm()
    {
        Console.Clear();
        Console.WriteLine("1. Quadratic Formula");
        Console.WriteLine("2. Square Difference");
        Console.WriteLine("3. Square Trinomial");
        Console.WriteLine();
        Console.Write("Select Math Type: ");
        string type = Console.ReadLine();
        Console.WriteLine();

        if (type == "1")
        {
            QuadraticForm();
        }
        else if (type == "2")
        {
            SquareDiff();
        }
        else if (type == "3")
        {
            SquareTri();
        }
    }


    public void QuadraticForm()
    {
        Console.Clear();
        Console.Write("Enter coefficient a: ");
        SetVarA(double.Parse(Console.ReadLine()));

        Console.Write("Enter coefficient b: ");
        SetVarB(double.Parse(Console.ReadLine()));

        Console.Write("Enter coefficient c: ");
        SetVarC(double.Parse(Console.ReadLine()));
        Console.WriteLine();

        if (GetVarA() == 0)
        {
            Console.WriteLine("Invalid input. 'a' must not be zero.");
            Console.ReadLine();
            return;
        }

        double discriminant = GetVarB() * GetVarB() - 4 * GetVarA() * GetVarC();

        if (discriminant > 0)
        {
            double root1 = (-GetVarB() + Math.Sqrt(discriminant)) / (2 * GetVarA());
            double root2 = (-GetVarB() - Math.Sqrt(discriminant)) / (2 * GetVarA());
            Console.WriteLine($"The roots are real and different:\nRoot 1: {root1}\nRoot 2: {root2}");
            Console.ReadLine();
        }
        else if (discriminant == 0)
        {
            double root = -GetVarB() / (2 * GetVarA());
            Console.WriteLine($"The roots are real and identical:\nRoot: {root}");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("The equation has no real roots.");
            Console.ReadLine();
        }
    }

    public void SquareDiff()
    {
        Console.Clear();
        Console.Write("Enter coefficient a: ");
        SetVarA(double.Parse(Console.ReadLine()));

        Console.Write("Enter coefficient b: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine();

        double difference = (GetVarA() - GetVarB()) * (GetVarA() + GetVarB());

        string formula = $"({GetVarA()} - {GetVarB()}) * ({GetVarA()} + {GetVarB()})";

        Console.WriteLine($"Factored Form: {formula}, Difference: {difference}");
        Console.ReadLine();
    }
    
    public void SquareTri()
    {
        Console.Clear();
        Console.Write("Enter coefficient a: ");
        SetVarA(double.Parse(Console.ReadLine()));

        Console.Write("Enter coefficient b: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine();

        double firstTerm = Math.Pow(GetVarA(), 2);
        double middleTerm = 2 * GetVarA() * GetVarB();
        double lastTerm = Math.Pow(GetVarB(), 2);

        string trinomial = $"{firstTerm} + {middleTerm} + {lastTerm}";

        double triAns = firstTerm + middleTerm + lastTerm;

        string factoredForm = $"({GetVarA()} + {GetVarB()})^2";

        double factoredAns = Math.Pow((GetVarA()) + (GetVarB()), 2) ;

        Console.WriteLine($"Square Trinomial: {trinomial} = {triAns}, Factored Form: {factoredForm} = {factoredAns}");
        Console.ReadLine();
    }
}