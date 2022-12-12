using System;

namespace becrowd1072
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int totaldenumero = int.Parse(Console.ReadLine());
            int[] inteiros = new int[totaldenumero];
            int inf = 0;
            int fe = 0;

            for (int i = 0; i < inteiros.Length; i++)
            {
                inteiros[i] = int.Parse(Console.ReadLine());
            }

           foreach (int numero in inteiros)
            {

                if (numero <= 20 && numero >= 10)
                {
                    inf++;
                }
                else if (numero > 20 || numero < 10)
                {
                    fe++;
                }
            
            }
            Console.WriteLine(inf + " in");
            Console.WriteLine(fe +" out");
            Console.ReadKey();
        }
    }
}