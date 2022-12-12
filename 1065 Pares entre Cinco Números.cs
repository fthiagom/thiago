using System;

namespace Pares_entre_Cinco_Números
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero1, numero2, numero3, numero4, numero5, valorespares;
            double resto;


            valorespares = 0;
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());
            numero3 = int.Parse(Console.ReadLine());
            numero4 = int.Parse(Console.ReadLine());
            numero5 = int.Parse(Console.ReadLine());


            int[] numeros = new int[5];
            numeros[0] = numero1;
            numeros[1] = numero2;
            numeros[2] = numero3;
            numeros[3] = numero4;
            numeros[4] = numero5;




            for (int i = 0; i < numeros.Length; i++)
            {
                resto = numeros[i] % 2;
                if (resto == 0.0)
                {
                    valorespares++;

                }
            }
            Console.WriteLine($"{valorespares} valores pares");
            Console.ReadKey();
        }
    }
}