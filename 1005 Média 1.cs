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
            double Nota1 = Convert.ToDouble(Console.ReadLine(),CultureInfo.InvariantCulture);
            double Nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            double MEDIA = (Nota1 * 3.5 + Nota2 * 7.5) / 11;
          
            Console.WriteLine($"MEDIA = { MEDIA.ToString("f5", CultureInfo.InvariantCulture)}");
            Console.ReadLine();

        }

    }
}
