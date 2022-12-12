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


            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);

            }
            Console.ReadKey();

        }
    }
}