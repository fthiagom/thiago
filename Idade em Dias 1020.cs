using System;

namespace Beecrowd1016Distancia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int ano = x / 365;
            int resto = x % 365;

            int mes = resto / 30;
            int resto2 = resto % 30;

            int dia = resto2;
  
            

            Console.WriteLine(ano+ " ano(s)");
            Console.WriteLine(mes+ " mes(es)");
            Console.WriteLine(dia+ " dia(s)");

           

            Console.ReadLine();
        }
    }
}