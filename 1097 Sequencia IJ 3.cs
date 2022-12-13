using System;
using System.Runtime.CompilerServices;

namespace becrowd1095
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 1, cont = 7;
            while (num <= 9)
            {
                Console.WriteLine("I="+num+ " J="+cont--);
                Console.WriteLine("I=" + num + " J=" + cont--);
                Console.WriteLine("I=" + num + " J=" + cont--);
                num += 2;
                cont += 5;
            }
            Console.ReadLine();
        }
    }

}