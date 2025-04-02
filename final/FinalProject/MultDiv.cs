public class MultDiv : SimpleMath
{
    // Attributes


    // Initializors


    // Methods
    public override void Math1()
    {
        Console.Clear();
        // MULTIPLICATION
        float answer = _variable1 * _variable2;
        Console.WriteLine(answer);
        Console.ReadLine();
    }

    public override void Math2()
    {
        Console.Clear();
        // DIVISION
        float answer = _variable1 / _variable2;
        Console.WriteLine(answer);
        Console.ReadLine();
    }
}