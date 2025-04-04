public abstract class Geometry
{
    private double _variablea;
    private double _variableb;
    private double _variablec;

    public void SetVarA(double variable)
    {
        _variablea = variable;
    }

    public void SetVarB(double variable)
    {
        _variableb = variable;
    }

    public void SetVarC(double variable)
    {
        _variablec = variable;
    }



    

    public double GetVarA()
    {
        return _variablea;
    }

    public double GetVarB()
    {
        return _variableb;
    }

    public double GetVarC()
    {
        return _variablec;
    }
    
    public abstract void Cone();
    public abstract void Sphere();
    
}