using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Simple Calculator");
            Console.WriteLine("2. Geometry");
            Console.WriteLine("3. Other Functions");
            Console.WriteLine("4. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SimpleCalculator();
                    break;
                case "2":
                    SelectGeo();
                    break;
                case "3":
                    // DisplayGoals();
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void SimpleCalculator()
    {
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Select Math Type: ");
        string type = Console.ReadLine();


        if (type == "1")
        {
            AddSub addsub = new AddSub();
            Console.WriteLine(addsub.Math1());
        }
        else if (type == "2")
        {
            AddSub addsub = new AddSub();
            Console.WriteLine(addsub.Math2());
        }
        else if (type == "3")
        {
            MultDiv multdiv = new MultDiv();
            Console.WriteLine(multdiv.Math1());
        }
        else if (type == "4")
        {
            MultDiv multdiv = new MultDiv();
            Console.WriteLine(multdiv.Math2());
        }
    }

    static void SelectGeo()
    {
        Console.WriteLine("1. Area");
        Console.WriteLine("2. Volume");
        Console.WriteLine();
        Console.Write("Select Math Type: ");
        string type = Console.ReadLine();


        if (type == "1")
        {
            Area area = new Area();
            area.SelectArea();
        }
        else if (type == "2")
        {
            Volume volume = new Volume();
            volume.SelectVolume();
        }
    }
}