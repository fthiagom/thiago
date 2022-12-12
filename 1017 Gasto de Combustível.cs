using System;

namespace Beecrowd1017ConsumoDeCombustivel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int tempo, velmed, dist;
            double conslit = 12.000;
            double constot;

            tempo = Convert.ToInt32(Console.ReadLine());
            velmed = Convert.ToInt32(Console.ReadLine());
            dist = tempo * velmed;
            constot = dist / conslit;

            Console.WriteLine($"{constot:F3}");
            Console.ReadKey();




        }
    }
}