using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double idade;

            Console.WriteLine("Exercicio 3");

            Console.WriteLine("Escreva seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Escreva sua idade:");
            string strIdade = Console.ReadLine();
            idade = Convert.ToDouble(strIdade);

            idade = 365 * idade;
            Console.WriteLine(nome + ", VOCE VIVEU " + idade + " DIAS.");

            Console.ReadLine();
            Console.Clear();
        }
    }
}
