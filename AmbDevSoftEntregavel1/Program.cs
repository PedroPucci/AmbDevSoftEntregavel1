using System;

namespace Questao1
{
    public class Program : PrimeNumberController
    {
        public static void Main(string[] args)
        {
            /* 
             * Número é primo: um número inteiro positivo N é primo se for divisível apenas por 1 e por N.
             */

            int number;
            bool checkNumberPositive, checkPrimeNumer;

            Console.WriteLine("Digite um número positivo: ");
            number = Convert.ToInt32(Console.ReadLine());

            checkNumberPositive = CheckNumberPositive(number);
            if (!checkNumberPositive)
                Console.WriteLine("O número não é positivo.");

            if (checkNumberPositive == true)
            {
                checkPrimeNumer = CheckPrimeNumer(number);
                if (!checkPrimeNumer)
                {
                    Console.WriteLine("O número digitado não é primo.");
                }
                else
                {
                    Console.WriteLine("O número é primo");
                }
            }

            Console.ReadKey();
        }
    }
}