using System;

namespace Beecrowd1048
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine());

            if (valor <= 400.00)
            {
                double reajuste = (valor * 0.15);
                double novosal = valor + reajuste;
                Console.WriteLine($"Novo salario: {novosal:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (valor >= 400.01 && valor <= 800.00)
            {
                double reajuste = (valor * 0.12);
                double novosal = valor + reajuste;
                Console.WriteLine($"Novo salario: {novosal:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (valor >= 800.01 && valor <= 1200.00)
            {
                double reajuste = (valor * 0.10);
                double novosal = valor + reajuste;
                Console.WriteLine($"Novo salario: {novosal:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (valor >= 1200.01 && valor <= 2000.00)
            {
                double reajuste = (valor * 0.07);
                double novosal = valor + reajuste;
                Console.WriteLine($"Novo salario: {novosal:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (valor >= 2000.01)
            {
                double reajuste = (valor * 0.04);
                double novosal = valor + reajuste;
                Console.WriteLine($"Novo salario: {novosal:F2}");
                Console.WriteLine($"Reajuste ganho: {reajuste:F2}");
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}