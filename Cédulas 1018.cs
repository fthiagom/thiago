using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());




            int n100 = N / 100;
            int restn100 = N % 100;

            int n50 = restn100 / 50;
            int restn50 = restn100 % 50;

            int n20 = restn50 / 20;
            int restn20 = restn50 % 20;

            int n10 = restn20 / 10;
            int restn10 = restn20 % 10;

            int n5 = restn10 / 5;
            int restn5 = restn10 % 5;

            int n2 = restn5 / 2;
            int restn2 = restn5 % 2;

            int n1 = restn2;

            Console.WriteLine(N);
            Console.WriteLine(n100+ " nota(s) de R$ 100,00");
            Console.WriteLine(n50+ " nota(s) de R$ 50,00");
            Console.WriteLine(n20+ " nota(s) de R$ 20,00");
            Console.WriteLine(n10+ " nota(s) de R$ 10,00");
            Console.WriteLine(n5+ " nota(s) de R$ 5,00");
            Console.WriteLine(n2+ " nota(s) de R$ 2,00");
            Console.WriteLine(n1+ " nota(s) de R$ 1,00");

            Console.ReadKey();
        }
    }
}
