using System;

namespace Questao3
{
    public class Program : FibonacciController
    {
        /*
         * Fibonacci: onde N > 1. Os primeiros termos são: 0, 1, 1, 2, 3, 5, 8, 13 …. 
         * Cada termo, além dos dois primeiros, é derivado da soma de seus dois antecessores mais próximos.
         */

        public static void Main(string[] args)
        {
            int number;

            Console.Write("Digite a quantidade de números que deseja mostrar: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Segue a sequência de Fibonacci:");
            for (int i = 0; i < number; i++)
            {
                Console.Write(FibonacciRecursivo(i) + " ");
            }

            Console.ReadKey();
        }
    }
}