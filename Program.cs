

using System;

namespace aprendendo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";
            
            
            Console.WriteLine("qual o seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("muito prazer " + "," + nome);
            Console.WriteLine("vamos fazer uma conta?");
            Console.WriteLine("me informe o valor de venda: ");
            int valordevenda= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("me informe a porcentagem referente a esse valor:");
            int porcvenda= Convert.ToInt32(Console.ReadLine());
            int valor= valordevenda * 100 / porcvenda;
            Console.WriteLine("o valor total é: "+valor);
            Console.WriteLine("me informe a porcentagem do lucro");
            int lucro = Convert.ToInt32(Console.ReadLine());
            int resultado = lucro * valor / 100;
            int ventatotal = resultado + valor;
            Console.WriteLine("ele tem que vender pelo valor de " + ventatotal + " para ter um lucro de " + lucro);
            Console.ReadLine();
        }
    }
}
