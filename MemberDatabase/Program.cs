using System;
using System.IO;

namespace MemberDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Members of CIS-SO!");
            Console.WriteLine();
            foreach (var file in Directory.EnumerateFiles(@"..\..\..\data"))
            {
                var content = File.ReadAllText(file).Split(',');
                Console.WriteLine("-----------------------------");
                Console.WriteLine($"First Name: {content[0]}");
                Console.WriteLine($"Last Name: {content[1]}");
                Console.WriteLine($"Favorite Language: {content[2]}");
                Console.WriteLine($"What do you hope to get out of CIS-SO? {content[3]}");
                Console.WriteLine();
            }

            Console.WriteLine("Welcome to CIS-SO!");

        }
    }
}
