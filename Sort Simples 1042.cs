using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Simples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] p = Console.ReadLine().Split();

            int num1 = int.Parse(p[0]);
            int num2 = int.Parse(p[1]);
            int num3 = int.Parse(p[2]);

            if (num1 < num2 && num2 < num3 && num1 < num3 )
            {
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                Console.WriteLine(num3);
                
            }
            else if (num1 > num2 && num2 < num3 && num1 < num3)
            {
                Console.WriteLine(num2);
                Console.WriteLine(num1);
                Console.WriteLine(num3);
                
            }
            else if (num1 > num2 && num2 > num3 && num1 > num3)
            {
                Console.WriteLine(num3);
                Console.WriteLine(num2);
                Console.WriteLine(num1);
              
            }
            else if (num1 < num2 && num2 > num3 && num1 > num3)
            {
                Console.WriteLine(num3);
                Console.WriteLine(num1);
                Console.WriteLine(num2);
                    
            }
            else if (num1 < num2 && num2 > num3 && num1 < num3 )
            {
                Console.WriteLine(num1);
                Console.WriteLine(num3);
                Console.WriteLine(num2);

            }
            else if (num1 > num2 && num2 < num3 && num1 > num3)
            {
                Console.WriteLine(num2);
                Console.WriteLine(num3);
                Console.WriteLine(num1);

            }
            Console.WriteLine();
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.ReadKey();

        }
    }
}
