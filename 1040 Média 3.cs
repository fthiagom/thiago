using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] p1 = Console.ReadLine().Split();

            double n1 = double.Parse(p1[0]);
            double n2 = double.Parse(p1[1]);
            double n3 = double.Parse(p1[2]);
            double n4 = double.Parse(p1[3]);
                      
            double media = (n1 * 2 + n2 * 3 + n3 * 4 + n4 * 1)/10;

            if (media >= 7.0)
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno aprovado.");
                Console.ReadKey();
            }
            else if (media < 5.0)
            {
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno reprovado.");
                Console.ReadKey();
            }
            else if (media >= 5.0 || media <= 6.9)
            {
                string[] p2 = Console.ReadLine().Split();
                double n5 = double.Parse(p2[0]);
                Console.WriteLine($"Media: {media:F1}");
                Console.WriteLine("Aluno em exame.");
                double media2 = (media + n5) / 2;
                if (media2 >= 5.0)
                {
                    Console.WriteLine($"Nota do exame: {n5:F1}");
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine($"Media final: {media2:F1}");
                    Console.ReadKey();
                }
                else if (media2 <= 4.9)
                {
                    Console.WriteLine($"Nota do exame: {n5:F1}");
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine($"Media final: {media2:F1}");
                    Console.ReadKey();
                }
            }
        }
    }
}
