using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cel, fahr;

            Console.WriteLine("Quer descobrir a temperatura em Fahrenheit?");
            Console.WriteLine("Digite a temperatura em Celsius");
            string strCel = Console.ReadLine();
            cel = Convert.ToDouble(strCel);

            fahr = (cel * 1.8 + 32);
            Console.WriteLine("A temperatura em Fahrenheit é de: " + fahr);
            Console.ReadLine();
            Console.Clear();

        }
    }
}
