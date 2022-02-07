using System;

namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pao = 0.12;
            double broa = 1.50;
            double tpao, tbroa, tot;


            Console.WriteLine("Bem-vindo a padaria HOTPão");
            Console.WriteLine("Quantos pães foram vendidos?");
            string strPao = Console.ReadLine();
            Console.WriteLine("Quantas broas foram venvidas?");
            string strbroa = Console.ReadLine();

            tpao = Convert.ToDouble(strPao);
            tbroa = Convert.ToDouble(strbroa);

            tot = ((tpao * pao) + (tbroa * broa));

            Console.WriteLine("o total de lucros no dia foi de: " + tot);
            Console.WriteLine("O valor a ser depositado é de:" + (tot * 0.1));
            Console.ReadLine();
            Console.Clear();

        }
    }
}
