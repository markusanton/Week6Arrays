using System;

namespace UserAgainstZombies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userBag = new string[5];

            int i = 0;
            while (i < userBag.Length)
            { 
            Console.WriteLine("What items are in your bag?");
            userBag[i] = Console.ReadLine();
            i++;
            }
            Random rnd = new Random;
            Console.WriteLine($"In case of a zombie attack you will have to fight off zombies with {userBag[rnd.Next(0, userBag.Length)]}");

        }
    }
}
