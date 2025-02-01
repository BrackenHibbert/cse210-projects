using System.Reflection.Metadata.Ecma335;
using Develop02;

namespace Develop02
{
    public static class SaveLoadManager
    {
        public static void SaveJournal(List<string> journal, string filepath)
        {
            File.WriteAllLines(filepath, journal);
            Console.WriteLine("Journal saved");
        }

        public static List<string> LoadJournal(string filepath)
        {
            List<string> journal = new List<string>(File.ReadAllLines(filepath));
            Console.WriteLine("Journal Loaded");

            return journal;
        }
        
    }
}