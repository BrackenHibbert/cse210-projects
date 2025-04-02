public class Volume : Geometry
{
    // Attributes


    // Initializors


    // Methods

    public void SelectVolume()
    {
        Console.Clear();
        Console.WriteLine("1. Cube");
        Console.WriteLine("2. Parallelpiped");
        Console.WriteLine("3. Prism");
        Console.WriteLine("4. Cylinder");
        Console.WriteLine("5. Cone");
        Console.WriteLine("6. Pyramid");
        Console.WriteLine("7. Sphere");
        Console.WriteLine();
        Console.Write("Select Shape: ");
        string type = Console.ReadLine();


        if (type == "1")
        {
            Console.WriteLine(Cube());
        }
        else if (type == "2")
        {
            Console.WriteLine(Parallelepiped());
        }
        else if (type == "3")
        {
            Console.WriteLine(Prism());
        }
        else if (type == "4")
        {
            Console.WriteLine(Cylinder());
        }
        else if (type == "5")
        {
            Console.WriteLine(Cone());
        }
        else if (type == "6")
        {
            Console.WriteLine(Cone());
        }
        else if (type == "7")
        {
            Console.WriteLine(Sphere());
        }
    }

    public double Cube()
    {
        Console.Clear();
        Console.Write("Enter the Length of a Side: ");
        double length = double.Parse(Console.ReadLine());
        return length * length * length;
    }

    public double Parallelepiped()
    {
        Console.Clear();
        Console.Write("Enter the Length:");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Width: ");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        double height = double.Parse(Console.ReadLine());
        return length * width * height;
    }

    public double Prism()
    {
        Console.Clear();
        Console.Write("Enter the Base: ");
        double tbase = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        double height = double.Parse(Console.ReadLine());
        return height * tbase / 2;
    }

    public double Cylinder()
    {
        Console.Clear();
        Console.Write("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        double height = double.Parse(Console.ReadLine());
        return Math.PI * radius * radius * height;
    }

    public override double Cone()
    {
        Console.Clear();
        Console.Write("Enter the Base: ");
        double tbase = double.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        double height = double.Parse(Console.ReadLine());
        return 1.0 / 3 * tbase * height;
    }

    public override double Sphere()
    {
        Console.Clear();
        Console.Write("Enter the Radius: ");
        double radius = double.Parse(Console.ReadLine());
        return 4 / 3 * Math.PI * radius * radius * radius;
    }
}