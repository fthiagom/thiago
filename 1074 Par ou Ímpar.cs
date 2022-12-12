using System;

namespace becrowd1074
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int totaldenumero = int.Parse(Console.ReadLine());
            int[] inteiros = new int[totaldenumero];

            for (int i = 0; i < inteiros.Length; i++)
            {
                inteiros[i] = int.Parse(Console.ReadLine());
            }

            string descrit;

            foreach (int numero in inteiros)
            {

                if (numero % 2 != 0) descrit = "ODD ";
                else descrit = "EVEN ";

                if (numero > 0) descrit += "POSITIVE";
                else descrit += "NEGATIVE";

                if (numero == 0) descrit = "NULL";

                Console.WriteLine(descrit);

            }
            Console.ReadKey();
        }
    }
}