using System;

namespace LoginValidation2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine("sisesta kasutajatunnus:");
                string userName = Console.ReadLine();
                Console.WriteLine("sisesta parool:");
                string userPassword = Console.ReadLine();
                Console.WriteLine("sisesta PIN-kood:");
                string userPIN = Console.ReadLine();
                if (userPIN.Length > 4)
                {
                    Console.WriteLine("vale PIN, proovi uuesti");
                }
                else if (userName == "user1" && userPassword == "password1" && userPIN == "1532")
                {
                    Console.WriteLine("Tere tulemast");
                    break;
                }
                else
                {
                    Console.WriteLine("Midagi läksvalesti. Proovi uuesti.");
                    i = i + 1;
                }
            }
        }
    }
}
