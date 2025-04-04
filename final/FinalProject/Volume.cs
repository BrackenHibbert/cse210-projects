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
            Cube();
        }
        else if (type == "2")
        {
            Parallelepiped();
        }
        else if (type == "3")
        {
            Prism();
        }
        else if (type == "4")
        {
            Cylinder();
        }
        else if (type == "5")
        {
            Cone();
        }
        else if (type == "6")
        {
            Cone();
        }
        else if (type == "7")
        {
            Sphere();
        }
    }

    public void Cube()
    {
        Console.Clear();
        Console.Write("Enter the Length of a Side: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine(GetVarA() * GetVarA() * GetVarA());
        Console.ReadLine();
    }

    public void Parallelepiped()
    {
        Console.Clear();
        Console.Write("Enter the Length:");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Width: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        SetVarC(double.Parse(Console.ReadLine()));
        Console.WriteLine(GetVarA() * GetVarB() * GetVarC());
        Console.ReadLine();
    }

    public void Prism()
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

    public void Cylinder()
    {
        Console.Clear();
        Console.Write("Enter the radius: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine(Math.PI * GetVarA() * GetVarA() * GetVarB());
        Console.ReadLine();
    }

    public override void Cone()
    {
        Console.Clear();
        Console.Write("Enter the Base: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine();
        Console.Write("Enter the Height: ");
        SetVarB(double.Parse(Console.ReadLine()));
        Console.WriteLine(1.0 / 3 * GetVarA() * GetVarB());
        Console.ReadLine();
    }

    public override void Sphere()
    {
        Console.Clear();
        Console.Write("Enter the Radius: ");
        SetVarA(double.Parse(Console.ReadLine()));
        Console.WriteLine(4 / 3 * Math.PI * GetVarA() * GetVarA() * GetVarA());
        Console.ReadLine();
    }
}