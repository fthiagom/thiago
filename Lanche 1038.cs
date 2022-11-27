using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace S
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] valor = Console.ReadLine().Split();

            double codigo = double.Parse(valor[0]);
            double codigo2 = double.Parse(valor[1]);

            if (codigo == 1)
            {
                double codigo1 = 4.00;
                double total = codigo1 * codigo2;
                Console.WriteLine($"Total: R$ {total:F2}");
                Console.ReadKey();
            }
            else if (codigo == 2)
            {
                double codigo1 = 4.50;
                double total = codigo1 * codigo2;
                Console.WriteLine($"Total: R$ {total:F2}");
                Console.ReadKey();

            }
            else if (codigo == 3)
            {
                double codigo1 = 5.0;
                double total = codigo1 * codigo2;
                Console.WriteLine($"Total: R$ {total:F2}");
                Console.ReadKey();
            }
            else if (codigo == 4)
            {
                double codigo1 = 2.00;
                double total = codigo1 * codigo2;
                Console.WriteLine($"Total: R$ {total:F2}");
                Console.ReadKey();
            }
            else if (codigo == 5)
            {
                double codigo1 = 1.50;
                double total = codigo1 * codigo2;
                Console.WriteLine($"Total: R$ {total:F2}");
                Console.ReadKey();
              
            }
        }
    }
}
            