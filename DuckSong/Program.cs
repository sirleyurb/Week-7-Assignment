using System;

namespace DuckSong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("five little ducks");
            string ducks;

            for (int i = 5; i > 0; i--)
            {
                if ( i > 1)
                {
                    ducks = "ducks";
                }
             else
                {
                    ducks = "duck";
                }
                Console.WriteLine($"{i} little {ducks} went out one day");
                Console.WriteLine("over he hill and far away");
                Console.WriteLine("mother duck said, \"Quack, quack, quack\"");
                
                if (i == 2)
                {
                    ducks = "duck";
                }
                else if (i > 1)
                {
                    Console.WriteLine($"but only {i - 1} little {ducks} came back");
                }
                else
                {
                    Console.WriteLine($"but none of the {i + 4} little ducks came back");
                }

                Console.WriteLine("sad mother duck went out one day");
                Console.WriteLine("over the hill and far away");
                Console.WriteLine("the sad mother duck said, \" Quack, quack, quack\"");
                Console.WriteLine("and all of the 5 little ducks came back");

                
            }
        }
    }
}
