using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio = double.Parse(Console.ReadLine());
            double PI = 3.14159;

            double area = PI * raio * raio;

            Console.WriteLine($"A={area:F4}");

            Console.ReadLine();
        }
    }
}
