using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi:");
            string userName = Console.ReadLine();

            Console.WriteLine(userName[' ']);
            int userNameLenght = userName.Length;

        }
    }
}
