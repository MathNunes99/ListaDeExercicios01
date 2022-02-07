using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, salf, salaum;
            string strSal;

            Console.WriteLine("Salario");
            Console.WriteLine("Escreva o salario: ");
            strSal = Console.ReadLine();
            sal = Convert.ToDouble(strSal);

            Console.WriteLine(sal + " R$ - salario base");
            salaum = (sal * 1.15);
            Console.WriteLine(salaum + " R$ - com o aumento 15%");
            salf = (salaum * 0.92);
            Console.WriteLine(salf + " R$ - descontado imposto 8%");

            Console.ReadLine();
            Console.Clear();

        }
    }
}
