public abstract class SimpleMath
{
    // Attributes
    protected float _variable1;
    protected float _variable2;

    // Initializors
    public SimpleMath()
    {
        Console.WriteLine("Enter the first variable: ");
        _variable1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second variable: ");
        _variable2 = float.Parse(Console.ReadLine());
    }
    
    // Methods
    public abstract float Math1();
    public abstract float Math2();
}