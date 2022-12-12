using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salário
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int hora = int.Parse(Console.ReadLine());
            double salario = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double resultado = hora * salario;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine($"SALARY = U$ { resultado.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
    }
}
