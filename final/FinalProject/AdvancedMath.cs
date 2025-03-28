public abstract class AdvancedMath
{
    // Attributes
    protected float _variable1;
    protected float _variable2;

    // Initializors
    public AdvancedMath()
    {
        Console.WriteLine("Enter the first variable: ");
        _variable1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second variable: ");
        _variable2 = float.Parse(Console.ReadLine());
    }

    // Methods
    
}