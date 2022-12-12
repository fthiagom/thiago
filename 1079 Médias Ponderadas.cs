using System;


namespace _1079
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int totaldenumero = int.Parse(Console.ReadLine());

            for (int i = 0; i <= totaldenumero; i++)
            {
                if (i != totaldenumero)
                {
                    string[] p1 = Console.ReadLine().Split();
                    double n1 = double.Parse(p1[0]);
                    double n2 = double.Parse(p1[1]);
                    double n3 = double.Parse(p1[2]);


                   double media = (n1 * 2 + n2 * 3 + n3 * 5) / (2 + 3 + 5);
                    Console.WriteLine($"{media:F1}");
                 
                }
                
            }  
            
            Console.ReadLine();
        }

    }
}