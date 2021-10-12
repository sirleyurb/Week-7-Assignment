using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("sisesa perekonnanimi:");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Tere {firstName[0]}. {lastName[0]}.");
        }
    }
}
