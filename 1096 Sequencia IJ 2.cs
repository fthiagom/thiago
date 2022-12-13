using System;

namespace becrowd1095
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1, num2;
            for (num1 = 1; num1 <= 9; num1 += 2)
            {
                for (num2 = 7; num2 >= 5; num2--)
                {
                  Console.WriteLine("I= "+num1+ " J="+ num2);
                }
            }
            Console.ReadLine();
        }
    }
    
}