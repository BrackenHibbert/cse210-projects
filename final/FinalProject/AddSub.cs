public class AddSub : SimpleMath
{
    // Attributes


    // Initializors


    // Methods
    public override void Math1()
    {
        Console.Clear();
        //ADDITION
        float sum = _variable1 + _variable2;
        Console.WriteLine(sum);
        Console.ReadLine();
        
    }

    public override void Math2()
    {
        Console.Clear();
        // Subtraction
        float answer = _variable1 - _variable2;
        Console.WriteLine(answer);
        Console.ReadLine();
    }
}