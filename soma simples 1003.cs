using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conta_simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());  
            int B = int.Parse(Console.ReadLine());
            int SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);

            Console.ReadLine();

        }

    }
}
