using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diferença
{
    internal class Program
    {
        static void Main(string[] args)
        {
         int A = Convert.ToInt32(Console.ReadLine());
         int B = Convert.ToInt32(Console.ReadLine());
         int C = Convert.ToInt32(Console.ReadLine());
         int D = Convert.ToInt32(Console.ReadLine());

            int dif = A * B - C * D;
            Console.WriteLine("DIFERENCA = "+ dif);
            Console.ReadLine();

        }
    }
}
