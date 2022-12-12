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
            int val = int.Parse(Console.ReadLine());
            foreach (int value in Enumerable.Range(1, 10001).Where(x => x % val == 2))
            {
                Console.WriteLine(value);


            }
            Console.ReadLine();
        }
    }
}