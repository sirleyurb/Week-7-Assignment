using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta eesnimi:");
            string userName = Console.ReadLine();
            Random rnd = new Random();

            int taht = rnd.Next(0, userName.Length - 1);
            Console.WriteLine(userName[taht]);
        }
    }
}
