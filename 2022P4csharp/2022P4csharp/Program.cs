using System;
using System.Collections.Generic;


namespace _2022P4csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> birds = new List<string>() { "duif", "roodbosje" };
            birds.Add("kraai");
            birds.Add("papegaai");
            birds.Add("uil");
            birds.Remove("hond");

            List<string> birds2 = new List<string>();
            birds2.Add("meeuw");
            birds2.Add("arend");

            foreach (string bird in birds)
            {
                Console.WriteLine(bird);
            }
            Console.ReadLine();
        }


    }
    internal class Enemy
    {

    }
}
