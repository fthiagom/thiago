using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Fórmula_de_Bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] p = Console.ReadLine().Split();
            double a = double.Parse(p[0]);
            double b = double.Parse(p[1]);
            double c = double.Parse(p[2]);

            double v1 = (b * b) - (4 * a * c);
            double bn = -1 * b;
            double baz1 = Math.Sqrt(v1);
            double dv = 2 * a;
            double result1 = (bn + baz1) / dv;
            double result2 = (bn - baz1) / dv;

            if (v1 <= 0 || dv <= 0)
            {
                Console.WriteLine("Impossivel calcular");
                Console.ReadKey();
            }

            else if (v1 > 0 || dv > 0)
            {
                Console.WriteLine($"R1 = {result1:F5}");
                Console.WriteLine($"R2 = {result2:F5}");
                Console.ReadKey();
            }
        }
    }
}
