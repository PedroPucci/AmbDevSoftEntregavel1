using System;

namespace Questao6
{
    public class Program : CheckNumbersController
    {
        /*
         * Contagem: Dado um valor de N números de entrada em um conjunto de dados, conte quantos valores inteiros existem, 
         * neste conjunto de dados, entre o primeiro dado (inclusive) e N (inclusive).
         */

        public static void Main(string[] args)
        {
            int numberStart, numberFirst, cont = 0;

            Console.WriteLine("Digite o valor de N:");
            numberStart = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro dado:");
            numberFirst = int.Parse(Console.ReadLine());

            for (int i = numberFirst; i <= numberStart; i++)
            {
                if (CheckInt(i))
                {
                    cont++;
                }
            }

            Console.WriteLine("No total existem " + cont + " números inteiros entre " + numberStart +" e " + numberFirst + " ");      
            
            Console.ReadKey();
        }
    }
}