public class MultDiv : SimpleMath
{
    // Attributes


    // Initializors


    // Methods
    public override float Math1()
    {
        // MULTIPLICATION
        float answer = _variable1 * _variable2;
        return answer;
    }

    public override float Math2()
    {
        // DIVISION
        float answer = _variable1 / _variable2;
        return answer;
    }
}