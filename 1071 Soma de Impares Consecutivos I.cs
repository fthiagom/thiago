using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace _1071
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int soma = 0;
            if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {

                    if (i % 2 != 0)
                    {
                        soma += i;
                    }

                }
            }
            else if(x > y)
           {
                for (int i = y + 1; i < x; i++)
                {

                    if (i % 2 != 0)
                    {
                        soma += i;
                    }

                }

           }

            Console.WriteLine(soma);
            
            Console.ReadKey();

        }
    }
}
