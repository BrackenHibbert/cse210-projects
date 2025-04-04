public class Area : Geometry
{
    // Attributes


    // Initializors


    // Methods
    public void SelectArea()
    {
        Console.Clear();
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
            Square();
        }
        else if (type == "2")
        {
            Rectangle();
        }
        else if (type == "3")
        {
            Triangle();
        }
        else if (type == "4")
        {
            Rhombus();
        }
        else if (type == "5")
        {
            Trapezoid();
        }
        else if (type == "6")
        {
            Polygon();
        }
        else if (type == "7")
        {
            Circle();
        }
        else if (type == "8")
        {
            Cone();
        }
        else if (type == "9")
        {
            Sphere();
        }
    }

    public void Square()
    {
        Console.Clear();
        Console.Write("Enter the Length: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine(GetVarA() * GetVarA());
        Console.ReadLine();
    }

    public void Rectangle()
    {
        Console.Clear();
        Console.Write("Enter the Width: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine(GetVarA() * GetVarB());
        Console.ReadLine();
    }

    public void Triangle()
    {
        Console.Clear();
        Console.Write("Enter the Base: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine(GetVarB() * GetVarA() / 2);
        Console.ReadLine();
    }

    public void Rhombus()
    {
        Console.Clear();
        Console.Write("Enter the Large Diagonal: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Small Diagonal: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine(GetVarA() * GetVarB() / 2);
        Console.ReadLine();
    }

    public void Trapezoid()
    {
        Console.Clear();
        Console.Write("Enter the Large Side: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Small Side: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        SetVarC(double.Parse(Console.ReadLine()));
        Console.WriteLine((GetVarA() + GetVarB()) / 2 * GetVarC());
        Console.ReadLine();
    }

    public void Polygon()
    {
        Console.Clear();
        Console.Write("Enter the Perimeter: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Apothem: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine(GetVarA() / 2 * GetVarB());
        Console.ReadLine();
    }

    public void Circle()
    {
        Console.Clear();
        Console.Write("Enter the Radius: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine(Math.PI * GetVarA() * GetVarA());
        Console.ReadLine();
    }

    public override void Cone()
    {
        Console.Clear();
        Console.Write("Enter the radius: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Slant Height: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine(Math.PI * GetVarA() * GetVarB());
        Console.ReadLine();
    }

    public override void Sphere()
    {
        Console.Clear();
        Console.Write("Enter the Radius: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine(4 * Math.PI * GetVarA() * GetVarA());
        Console.ReadLine();
    }
    
}