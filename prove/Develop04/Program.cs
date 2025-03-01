using System;

class Program
{
    static void Main(string[] args)
    {
        Listing listing = new Listing();
        Reflection reflection = new Reflection();
        Breathing breathing = new Breathing();

        int user_choice = 0;
        
        Console.Clear();

        while (user_choice != 4)
        {
            Console.WriteLine("Menu Options: \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            user_choice = int.Parse(Console.ReadLine());

            if (user_choice == 1)
            {
                breathing.Breathe();
            }

            else if (user_choice == 2)
            {
                reflection.Reflect();
            }

            else if (user_choice == 3)
            {
                listing.List();
            }

            else if (user_choice == 4)
            {
                break;
            }

            else
            {
                Console.WriteLine("Please enter a number between 1 and 4.");
            }
        }
    }
}