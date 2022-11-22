using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salario_com_bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string nome = Console.ReadLine();
            double salfix = Convert.ToDouble(Console.ReadLine());
            double vendas = Convert.ToDouble(Console.ReadLine());
            double resultado = (salfix + vendas * 0.15);

            Console.WriteLine($"TOTAL = R$ {resultado:F2}");
            Console.ReadLine();

        }
    }
}
