using System;

namespace Questao5
{
    public class QuicksortController
    {
        /// <summary>
        /// Method to print the sequency
        /// </summary>
        /// <param name="array"></param>
        public static void PrintArray(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }


        /// <summary>
        /// Using recursion and order numbers
        /// </summary>
        /// <param name="array"></param>
        /// <param name="numberLittle"></param>
        /// <param name="numberBig"></param>
        public static void Sort(int[] array, int numberLittle, int numberBig)
        {
            if (numberLittle < numberBig)
            {
                int pivotIndex = Partition(array, numberLittle, numberBig);

                Sort(array, numberLittle, pivotIndex - 1);
                Sort(array, pivotIndex + 1, numberBig);
            }
        }

        /// <summary>
        /// Separate numbers 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="numberLittle"></param>
        /// <param name="numberBig"></param>
        /// <returns></returns>
        public static int Partition(int[] array, int numberLittle, int numberBig)
        {
            int pivot = array[numberBig];
            int i = numberLittle - 1;

            for (int j = numberLittle; j < numberBig; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }

            Swap(ref array[i + 1], ref array[numberBig]);
            return i + 1;
        }


        /// <summary>
        /// Method to trade numbers each other
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}