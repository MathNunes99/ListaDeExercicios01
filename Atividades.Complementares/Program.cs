using System;

namespace Atividades.Complementares
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escreva as dimensões do terreno");
            Console.WriteLine("Escreva a largura");
            string strL1 = Console.ReadLine();
            Console.WriteLine("Escreva o comprimento");
            string strL2 = Console.ReadLine();

            double L1 = Convert.ToDouble(strL1);
            double L2 = Convert.ToDouble(strL2);
            double area = 0;

            area = (L1 * L2);
            Console.WriteLine("A area do terreno é de " + area + " m2");
            Console.ReadLine();
            Console.Clear();

        }
    }
}
