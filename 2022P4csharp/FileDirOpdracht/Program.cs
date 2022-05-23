using System;
using System.IO;
namespace FileDirOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\MA\Bewijzenmap\Periode 1.4\C#2\2022P4csharp\2022P4csharp\FileDirOpdracht");
            Console.WriteLine("No search pattern returns:");
            foreach (DirectoryInfo fil in dir.GetDirectories())
            {
                Console.WriteLine(fil.Name);
            }

            Console.WriteLine();

            foreach (FileInfo fil in dir.GetFiles())
            {
                Console.WriteLine(fil.Name);
            }
            
        }
    }
}
