namespace Questao4
{
    public class MediaNumbersController
    {
        /// <summary>
        /// Method to calculate the MDC
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int CalculateMdc(int a, int b)
        {
            while (b != 0)
            {
                int resto = a % b;
                a = b;
                b = resto;
            }
            return a;
        }
    }
}