using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_com_peso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            double B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double MEDIA = (A * 2 + B * 3 + C*5) / 10;
          
            Console.WriteLine($"MEDIA = { MEDIA.ToString("f1", CultureInfo.InvariantCulture)}");
            Console.ReadLine();

        }
        
    }
}
