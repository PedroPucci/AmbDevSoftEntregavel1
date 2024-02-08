using System;

namespace Questao5
{
    public class Program : QuicksortController
    {
        /*
         * Ordenação: Ordenar um array usando o método Quicksort 
         */

        public static void Main(string[] args)
        {
            int[] array = { 7, 2, 1, 6, 8, 5, 3, 4 };
            Console.WriteLine("Array original:");
            PrintArray(array);

            Sort(array, 0, array.Length - 1);

            Console.WriteLine("\nArray ordenado:");
            PrintArray(array);

            Console.ReadKey();
        }
    }
}