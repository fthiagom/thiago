using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[]args)
        {
            string nome = "";
            Console.WriteLine("Oi, tudo bem? ");
            Console.WriteLine("antes de tudo, gostaria de saber o seu nome? ");
            nome = Console.ReadLine();
            Console.WriteLine("muito prazer," + nome + " esse é um projeto iniciante para fixar o conhecimento." + " O intuito é fazer uma calculadora ultilizando o C#.");
            Console.WriteLine("vamos começar.");
            Console.WriteLine("Digite (1) para fazer uma conta de somar. digite (2) para fazer im subtração. digite (3) para fazer uma multiplicação. digite (4) para fazer uma divisão. aperte (0) para sair do programa: ");
            int soma = int.Parse(Console.ReadLine());
            if (1 == soma)
            {
                Console.WriteLine("me informe o primeiro numero que deseja fazer a soma: ");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("muito bem, agora me informe o segundo numero: ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("voce gostaria de acrescentar o terceriro numero: diga sim ou não ");
                string ass = Console.ReadLine();
                string asss = "sim";
                string assss = "Sim";
                if (ass == asss || asss == assss)
                {

                    Console.WriteLine("ok. me informe o terceiro numero da soma: ");
                    float c = float.Parse(Console.ReadLine());
                    float resultado1 = (a + b);
                    float resultado3 = (resultado1 + c);
                    Console.WriteLine("o resultado dos numero escolhidos são: " + resultado3);
                    Console.ReadLine();

                }
                else
                {
                    float resultado2 = a + b;
                    Console.WriteLine("o resultado dos numero escolhidos são: " + resultado2);
                    Console.ReadLine();
                }
            }
            else if (2 == soma)
            {
                Console.WriteLine("me informe o primeiro numero que deseja fazer a subtração: ");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("muito bem, agora me informe o segundo numero: ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("voce gostaria de acrescentar o terceriro numero: diga sim ou não ");
                string ass = Console.ReadLine();
                string asss = "sim";
                string assss = "Sim";
                if (ass == asss || ass == assss)
                {

                    Console.WriteLine("ok. me informe o terceiro numero da subtração: ");
                    float c = float.Parse(Console.ReadLine());
                    float resultado1 = (a - b);
                    float resultado3 = (resultado1 - c);
                    Console.WriteLine("o resultado dos numero escolhidos são: " + resultado3);
                    Console.ReadLine();

                }
                else
                {
                    float resultado2 = a - b;
                    Console.WriteLine("o resultado dos numero escolhidos são: " + resultado2);
                    Console.ReadLine();
                }
            }
            else if (3 == soma)
            {
                Console.WriteLine("me informe o primeiro numero que deseja fazer a multiplicação: ");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("muito bem, agora me informe o segundo numero: ");
                float b = float.Parse(Console.ReadLine());
                Console.WriteLine("voce gostaria de acrescentar o terceriro numero: diga sim ou não ");
                string ass = Console.ReadLine();
                string asss = "sim";
                string assss = "Sim";
                if (ass == asss || ass == assss)
                {

                    Console.WriteLine("ok. me informe o terceiro numero da multiplicação: ");
                    float c = float.Parse(Console.ReadLine());
                    float resultado1 = (a * b);
                    float resultado3 = (resultado1 * c);
                    Console.WriteLine("o resultado dos numero escolhidos são: " + resultado3);
                    Console.ReadLine();

                }
                else
                {
                    float resultado2 = a * b;
                    Console.WriteLine("o resultado dos numero escolhidos são: " + resultado2);
                    Console.ReadLine();
                }
            }
            else if (4 == soma)
            {
                Console.WriteLine("me informe o primeiro numero que deseja fazer a divisão: ");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("muito bem, agora me informe o segundo numero: ");
                float b = float.Parse(Console.ReadLine());
                float resultado2 = a / b;
                Console.WriteLine("o resultado dos numero escolhidos são: " + resultado2);
                Console.ReadLine();
            }
            else if(0 == soma)
            {
                Console.WriteLine("muito obrigado espero que você tenha gostado. ate logo. bay bay");
                Console.ReadLine();
            }
        }
    }
}
     
 
                    