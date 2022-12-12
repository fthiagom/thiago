using System;

namespace Beecrowd1021NotaseMoedas
{
    public class Program
    {
        public static void Main(string[] args)
        {

            double dinheiro = Double.Parse(Console.ReadLine());

            double n100, n50, n20, n10, n5, n2, restonota, m1, m50, m25, m10, m05, m01, resto;

            n100 = (int)dinheiro / 100;
            resto = dinheiro % 100;

            n50 = (int)resto / 50;
            resto = resto % 50;

            n20 = (int)resto / 20;
            resto = resto % 20;

            n10 = (int)resto / 10;
            resto = resto % 10;

            n5 = (int)resto / 5;
            resto = resto % 5;

            n2 = (int)resto / 2;
            resto = resto % 2;

            m1 = (int)resto / 1;
            resto = resto % 1;

            resto = resto * 100;

            m50 = (int)resto / 50;
            resto = resto % 50;

            m25 = (int)resto / 25;
            resto = resto % 25;

            m10 = (int)resto / 10;
            resto = resto % 10;

            m05 = (int)resto / 5;
            resto = resto % 5;

            m01 = (int)resto / 1;

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{n100} nota(s) de R$ 100.00");
            Console.WriteLine($"{n50} nota(s) de R$ 50.00");
            Console.WriteLine($"{n20} nota(s) de R$ 20.00");
            Console.WriteLine($"{n10} nota(s) de R$ 10.00");
            Console.WriteLine($"{n5} nota(s) de R$ 5.00");
            Console.WriteLine($"{n2} nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine($"{m1} moeda(s) de R$ 1.00");
            Console.WriteLine($"{m50} moeda(s) de R$ 0.50");
            Console.WriteLine($"{m25} moeda(s) de R$ 0.25");
            Console.WriteLine($"{m10} moeda(s) de R$ 0.10");
            Console.WriteLine($"{m05} moeda(s) de R$ 0.05");
            Console.WriteLine($"{m01} moeda(s) de R$ 0.01");







        }
    }
}