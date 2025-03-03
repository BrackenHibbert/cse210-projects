public abstract class Shape
{
    // Attributes
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getters and Setters
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Method
    public abstract double GetArea();
}