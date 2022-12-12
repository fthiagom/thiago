using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esferas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double x = 4.0 / 3;
            double r = raio * raio * raio;
            double pi = 3.14159;
            double volume = x * pi * r;

            Console.WriteLine($"VOLUME = {volume:F3}");
            Console.ReadKey();
        }
    }
}
