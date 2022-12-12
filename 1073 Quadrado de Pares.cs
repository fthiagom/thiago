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
               
                if (resto == 0)
                {
                    if (i > 5 || i < 2000)
                    {
                        if (i > 0)
                        {
                            Console.WriteLine(i + "^2 = " + i * i);
                        }
                    }
                }
            }
            Console.ReadKey();

        }
    }
}