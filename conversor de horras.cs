using System;

namespace Beecrowd1016Distancia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            int x;
            x = Convert.ToInt32(Console.ReadLine());
            int hora = x / 3600;    //38 horas. vai sobrar 00,93//
            int restohora = x % 3600; //00,93//
            int somamin = restohora / 60;//somamin é 1//
            int restosomamin = somamin % 60;//55 segundos
            int restomin = x % 60;
           



            Console.WriteLine($"{hora}:{somamin}:{restomin}");
            Console.ReadKey();
        }
    }
}