using System;
using System.IO;
namespace FileIOOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string[] Text = File.ReadAllLines(@"C:\MA\Bewijzenmap\Periode 1.4\C#2\2022P4csharp\2022P4csharp\FileIOOpdracht\Test.txt");

            foreach (string line in Text)
            {
                Console.WriteLine(line);
            }
        }
    }
}
