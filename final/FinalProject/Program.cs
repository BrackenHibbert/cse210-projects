using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("1. Simple Calculator");
            Console.WriteLine("2. Geometry");
            Console.WriteLine("3. Other Functions");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
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
                    SelectFunc();
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
        Console.Clear();
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine();
        Console.Write("Select Math Type: ");
        string type = Console.ReadLine();
        Console.WriteLine();


        if (type == "1")
        {
            AddSub addsub = new AddSub();
            addsub.Math1();
        }
        else if (type == "2")
        {
            AddSub addsub = new AddSub();
            addsub.Math2();
        }
        else if (type == "3")
        {
            MultDiv multdiv = new MultDiv();
            multdiv.Math1();
        }
        else if (type == "4")
        {
            MultDiv multdiv = new MultDiv();
            multdiv.Math2();
        }
    }

    static void SelectGeo()
    {
        Console.Clear();
        Console.WriteLine("1. Area");
        Console.WriteLine("2. Volume");
        Console.WriteLine();
        Console.Write("Select Math Type: ");
        string type = Console.ReadLine();
        Console.Clear();


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

    static void SelectFunc()
    {
        Console.Clear();
        Console.WriteLine("1. Basic Functions");
        Console.WriteLine("2. Statistics");
        Console.WriteLine();
        Console.Write("Select Math Type: ");
        string type = Console.ReadLine();
        Console.WriteLine();


        if (type == "1")
        {
            Functions functions = new Functions();
            functions.SelectForm();
        }
        else if (type == "2")
        {
            Statistics stat = new Statistics();
            stat.SelectStat();
        }
    }
}