using System;

namespace beecrowd1041
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            double x = double.Parse(valores[0]);
            double y = double.Parse(valores[1]);

            if (x > 0.0 && y > 0.0)
            {
                Console.WriteLine("Q1");
                Console.ReadKey();
            }
            else if (x > 0.0 && y < 0.0)
            {
                Console.WriteLine("Q4");
                Console.ReadKey();
            }
            else if (x < 0.0 && y > 0.0)
            {
                Console.WriteLine("Q2");
                Console.ReadKey();
            }
            else if (x < 0.0 & y < 0.0)
            {
                Console.WriteLine("Q3");
                Console.ReadKey();
            }
            else if (x == 0.0 && y != 0.0)
            {
                Console.WriteLine("Eixo X");
                Console.ReadKey();
            }
            else if (y == 0.0 && y != 0.0)
            {
                Console.WriteLine("Eixo Y");
                Console.ReadKey();
            }
            else if (x == 0.0 && y == 0.0)
            {
                Console.WriteLine("Origem");
                Console.ReadKey();
            }
        }
    }
}