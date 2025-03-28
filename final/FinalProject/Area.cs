public class Area : Geometry
{
    // Attributes


    // Initializors


    // Methods
    public void SelectArea()
    {
        Console.WriteLine("1. Square");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Triangle");
        Console.WriteLine("4. Rhombus");
        Console.WriteLine("5. Trapezoid");
        Console.WriteLine("6. Polygon");
        Console.WriteLine("7. Circle");
        Console.WriteLine("8. Cone");
        Console.WriteLine("9. Sphere");
        Console.WriteLine();
        Console.Write("Select Shape: ");
        string type = Console.ReadLine();


        if (type == "1")
        {
            Console.WriteLine(Square());
        }
        else if (type == "2")
        {
            Console.WriteLine(Rectangle());
        }
        else if (type == "3")
        {
            Console.WriteLine(Triangle());
        }
        else if (type == "4")
        {
            Console.WriteLine(Rhombus());
        }
        else if (type == "5")
        {
            Console.WriteLine(Trapezoid());
        }
        else if (type == "6")
        {
            Console.WriteLine(Polygon());
        }
        else if (type == "7")
        {
            Console.WriteLine(Circle());
        }
        else if (type == "8")
        {
            Console.WriteLine(Cone());
        }
        else if (type == "9")
        {
            Console.WriteLine(Sphere());
        }
    }

    public double Square()
    {
        Console.Write("Enter the Length: ");
        double length = double.Parse(Console.ReadLine());
        return length * length;
    }

    public double Rectangle()
    {
        Console.Write("Enter the Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        double height = double.Parse(Console.ReadLine());
        return width * height;
    }

    public double Triangle()
    {
        Console.Write("Enter the Base: ");
        double tbase = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        double height = double.Parse(Console.ReadLine());
        return height * tbase / 2;
    }

    public double Rhombus()
    {
        Console.Write("Enter the Large Diagonal: ");
        double ldiag = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Small Diagonal: ");
        double sdiag = double.Parse(Console.ReadLine());
        return ldiag * sdiag / 2;
    }

    public double Trapezoid()
    {
        Console.Write("Enter the Large Side: ");
        double large = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Small Side: ");
        double small = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        double height = double.Parse(Console.ReadLine());
        return (large + small) / 2 * height;
    }

    public double Polygon()
    {
        Console.Write("Enter the Perimeter: ");
        double perimeter = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Apothem: ");
        double apothem = double.Parse(Console.ReadLine());
        return perimeter / 2 * apothem;
    }

    public double Circle()
    {
        Console.Write("Enter the Radius: ");
        double radius = double.Parse(Console.ReadLine());
        return Math.PI * radius * radius;
    }

    public override double Cone()
    {
        Console.Write("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Slant Height: ");
        double slant = double.Parse(Console.ReadLine());
        return Math.PI * radius * slant;
    }

    public override double Sphere()
    {
        Console.Write("Enter the Radius: ");
        double radius = double.Parse(Console.ReadLine());
        return 4 * Math.PI * radius * radius;
    }
    
}