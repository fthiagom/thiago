using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distância_Entre_Dois_Pontos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] p1 = Console.ReadLine().Split();

            double x1,x2,y1,y2,quad1,soma,par1,par2,quad2,raiz,raiz2;

            x1 = double.Parse(p1[0]);
            y1= double.Parse(p1[1]);

            string[] p2 = Console.ReadLine().Split();
            x2 = double.Parse(p2[0]);
            y2= double.Parse(p2[1]);


            par1 = x2- x1;
            par2 = y2- y1;
            quad1= par1*par1;
            quad2= par2 * par2;
            soma = quad1 + quad2;
            raiz= Math.Sqrt( soma );

            

            Console.WriteLine($"{raiz:F4}");

            Console.ReadLine();


        }
    }
}
