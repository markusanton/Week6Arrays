using System;

namespace Week6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = { "will win a million", "lose your smartphone", "fall in love", "buy youtube premium", "get a cookie" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(1, predictions.Length + 1);
            Console.WriteLine($"Today you will {predictions[randomIndex]}");
        }
    }
}
