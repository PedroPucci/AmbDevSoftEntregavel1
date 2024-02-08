namespace Questao3
{
    public class FibonacciController
    {
        /// <summary>
        /// Method to check numbers to condition Fibonacci
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int FibonacciRecursivo(int number)
        {
            if (number <= 1)
                return number;
            else
                return FibonacciRecursivo(number - 1) + FibonacciRecursivo(number - 2);
        }
    }
}