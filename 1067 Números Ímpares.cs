using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace numeros_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= valor; i += 1)
            {
                double resto = i % 2;
                if (resto != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
    }
}