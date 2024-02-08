namespace Questao6
{
    public class CheckNumbersController
    {
        /// <summary>
        /// Method to check if number is integer
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static bool CheckInt(int number)
        {
            return number % 1 == 0;
        }
    }
}