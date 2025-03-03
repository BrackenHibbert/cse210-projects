using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning05 World!");

        // Square square = new Square("blue", 5);
        // Console.WriteLine($"{square.GetColor()}");
        // Console.WriteLine(square.GetArea());

        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("blue", 5);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("red", 4, 3);
        shapes.Add(r1);

        Circle c1 = new Circle("Yellow", 4);
        shapes.Add(c1);


        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}