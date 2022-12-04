using System;

namespace Beecrowd1046Tempodejogo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] horas = Console.ReadLine().Split();
            int inicio = int.Parse(horas[0]);
            int fim = int.Parse(horas[1]);
            int tempo;

            if (inicio > fim)
            {
                tempo = (24 - inicio) + (0 + fim);
                Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");

            }
            else if (inicio == fim)
            {
                Console.WriteLine($"O JOGO DUROU 24 HORA(S)");

            }
            else if (inicio < fim)
            {
                tempo = fim - inicio;
                Console.WriteLine($"O JOGO DUROU {tempo} HORA(S)");

            }



        }
    }
}