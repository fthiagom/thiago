using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Mês
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mes = int.Parse (Console.ReadLine());

            if (mes == 1) 
            {
                Console.WriteLine("January");
                Console.ReadKey();
            }
            else if (mes == 2) 
            {
                Console.WriteLine("February");
                Console.ReadKey();
            }
            else if (mes == 3)
            {
                Console.WriteLine("March");
                Console.ReadKey();
            }
            else if (mes == 4)
            {
                Console.WriteLine("April");
                Console.ReadKey();
            }
            else if (mes == 5)
            {
                Console.WriteLine("May");
                Console.ReadKey();
            }
            else if (mes == 6)
            {
                Console.WriteLine("June");
                Console.ReadKey();
            }
            else if (mes == 7)
            {
                Console.WriteLine("July");
                Console.ReadKey();
            }
            else if (mes == 8)
            {
                Console.WriteLine("August");
                Console.ReadKey();
            }
            else if (mes == 9)
            {
                Console.WriteLine("September");
                Console.ReadKey();
            }
            else if (mes == 10)
            {
                Console.WriteLine("October");
                Console.ReadKey();
            }
            else if (mes == 11)
            {
                Console.WriteLine("November");
                Console.ReadKey();
            }
            else if (mes == 12)
            {
                Console.WriteLine("December");
                Console.ReadKey();
            }
        }
    }
}
