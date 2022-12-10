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

            double numero1, numero2, numero3, numero4, numero5, numero6;
            int qtdPositivos;

            qtdPositivos = 0;
            numero1 = double.Parse(Console.ReadLine());
            numero2 = double.Parse(Console.ReadLine());
            numero3 = double.Parse(Console.ReadLine());
            numero4 = double.Parse(Console.ReadLine());
            numero5 = double.Parse(Console.ReadLine());
            numero6 = double.Parse(Console.ReadLine());

            double[] numeros = new double[6];
            numeros[0] = numero1;
            numeros[1] = numero2;
            numeros[2] = numero3;
            numeros[3] = numero4;
            numeros[4] = numero5;
            numeros[5] = numero6;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0.0)
                {
                    qtdPositivos++;
                }
            }
            Console.WriteLine($"{qtdPositivos} valores positivos");
            Console.ReadKey();
        }
    }
}