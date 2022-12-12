using System;

namespace Beecrowd1010CalculoSimples
{
    public class program
    {
        public static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split();

            int cod1 = int.Parse(peca1[0]);
            int qua1 = int.Parse(peca1[1]);
            double val1 = Double.Parse(peca1[2]);

            string[] peca2 = Console.ReadLine().Split();

            int cod2 = int.Parse(peca2[0]);
            int qua2 = int.Parse(peca2[1]);
            double val2 = Double.Parse(peca2[2]);

            double valortotal1 = qua1 * val1;
            double valortotal2 = qua2 * val2;

            double totalapagar = valortotal1 + valortotal2;

            Console.WriteLine($"VALOR A PAGAR: R$ {totalapagar:F2}");

            Console.ReadKey();

        }
    }
}