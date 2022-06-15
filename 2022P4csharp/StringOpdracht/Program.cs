using System;
using System.IO;

namespace StringOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string stringtext = File.ReadAllText(@"C:\MA\Bewijzenmap\Periode 1.4\C#2\2022P4csharp\2022P4csharp\StringOpdracht\stringsplit.txt");

            string[] subs = stringtext.Split(':', ',');
            foreach (string sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
        }
    }
}
