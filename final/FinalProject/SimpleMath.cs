public abstract class SimpleMath
{
    // Attributes
    protected float _variable1;
    protected float _variable2;

    // Initializors
    public SimpleMath()
    {
        Console.Clear();
        Console.WriteLine("Enter the first variable: ");
        _variable1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second variable: ");
        _variable2 = float.Parse(Console.ReadLine());
    }
    
    // Methods
    public abstract void Math1();
    public abstract void Math2();
}