public class AddSub : SimpleMath
{
    // Attributes


    // Initializors


    // Methods
    public override float Math1()
    {
        //ADDITION
        float sum = _variable1 + _variable2;
        return sum;
    }

    public override float Math2()
    {
        // Subtraction
        float answer = _variable1 - _variable2;
        return answer;
    }
}