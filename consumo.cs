using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consulmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = Convert.ToInt32(Console.ReadLine());
            double Y = Convert.ToDouble(Console.ReadLine());
            double result = X / Y;

            Console.WriteLine($"{result:F3} km/l");

            Console.ReadKey();



        }
    }
}
