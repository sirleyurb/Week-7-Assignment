using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta kasutajatunnus:");
            string userName = Console.ReadLine();
            Console.WriteLine("sisesta parool:");
            string userPassword = Console.ReadLine();
            Console.WriteLine("sisesta PIN-kood:");
            int userPIN = Convert.ToInt32(Console.ReadLine());


            foreach (char c in userPIN)
            {
                
            }

        }
    }
}
