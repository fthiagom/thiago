using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _1078
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = int.Parse(Console.ReadLine());


            for (int i = 0; i < valor; i += 1)
            {
                if (i <= 10 && i>0) 
                {
                    Console.WriteLine(i+" x "+valor+" = "+i*valor);
                }
            }
            Console.ReadKey();

        }
    }
}
