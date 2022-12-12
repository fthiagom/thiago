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
            int vpares = 0;
            int vimp = 0;
            int pos = 0;
            int neg = 0;

            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());
            int valor3 = int.Parse(Console.ReadLine());
            int valor4 = int.Parse(Console.ReadLine());
            int valor5 = int.Parse(Console.ReadLine());

            int[] valores = new int[5];

            valores[0] = valor1;
            valores[1] = valor2;
            valores[2] = valor3;
            valores[3] = valor4;
            valores[4] = valor5;
            
            for (int i = 0; i < valores.Length; i ++)
            {
                double resto = valores[i] % 2;
                if(resto == 0)
                {
                    vpares++;
                }
                else if (resto != 0) 
                {
                    vimp++;
                }

            }
            for (int i = 0; i < valores.Length; i++) 
            {
                if (valores[i] > 0)
                {
                    pos++;
                }
                else if (valores[i] < 0) 
                {
                    neg++;
                }
            }

            Console.WriteLine(vpares + " valor(es) par(es)");
            Console.WriteLine(vimp + " valor(es) impar(es)");
            Console.WriteLine(pos + " valor(es) positivo(s)");
            Console.WriteLine(neg + " valor(es) negativo(s)");
            Console.ReadKey();

        }
    }
}