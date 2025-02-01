using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using Develop02;

using System.Runtime.InteropServices;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Develop02
{
    public class Program
    {
        private static List<string> _journal = new List<string>();

        private static string filepath = "journal.txt";

        private static Journal journalmanager = new Journal();
        static void Main(string[] args)
        {
            int number_choice = 0;

            while (number_choice != 5)
            {
                Console.WriteLine("Please select an option \n 1. Create an Entry \n 2. Display Journal \n 3. Save Journal \n 4. Load Journal \n 5. Quit Program.");
                string choice = Console.ReadLine();
                number_choice = int.Parse(choice);

                if (number_choice == 1)
                {
                    _journal.Add(journalmanager.JournalEntry().ToString());
                }
                else if (number_choice == 2)
                {
                    foreach (string entry in _journal)
                    {
                        Console.WriteLine(entry);
                    }
                }
                else if (number_choice == 3)
                {
                    SaveLoadManager.SaveJournal(_journal, filepath);
                }
                else if (number_choice == 4)
                {
                    _journal = SaveLoadManager.LoadJournal(filepath);
                }
                else if (number_choice == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 5");
                }

            }
        }
    }
}