using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Área
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[]peca1 = Console.ReadLine().Split();

            double A = double.Parse(peca1[0]);
            double B = double.Parse(peca1[1]);
            double C = double.Parse(peca1[2]);

            double pi = 3.14159;
            double triret = C * A / 2;
            double r = (C * C)*pi;
            double trap = (C / 2) * (A + B);
            double quad = B * B;
            double ret = A * B;

            Console.WriteLine($"TRIANGULO: {triret:F3}");
            Console.WriteLine($"CIRCULO: {r:F3}");
            Console.WriteLine($"TRAPEZIO: {trap:F3}");
            Console.WriteLine($"QUADRADO: {quad:F3}");
            Console.WriteLine($"RETANGULO: {ret:F3}");
            

            Console.ReadLine();
        }
    }
}
