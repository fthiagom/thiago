using System;

namespace becrowd1095
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int b = 65;

            for (int i = 1; i <= 37; i += 3)
            {

                b = b - 5;

                Console.WriteLine("I=" + i + " J=" + b);
            }
            Console.ReadKey();
        }
    }
}