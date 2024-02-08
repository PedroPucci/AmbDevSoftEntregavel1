using System;

namespace Questao4
{
    public class Program : MediaNumbersController
    {
        /*
         *  Máximo divisor comum: O máximo divisor comum (mdc) de dois inteiros a, b é o maior número inteiro que divide a e b.
         */

        public static void Main(string[] args)
        {
            int numberFirst, numberSecond, mdc;
            bool checkNumberNotDouble;

            Console.Write("Digite o primeiro número inteiro: ");
            numberFirst = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro: ");
            numberSecond = Convert.ToInt32(Console.ReadLine());

            mdc = CalculateMdc(numberFirst, numberSecond);

            Console.WriteLine("O MDC de "+numberFirst+" e "+numberSecond+" é: "+mdc+" ");

            Console.ReadKey();
        }
    }
}