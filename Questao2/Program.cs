using System;
using System.Collections.Generic;

public class Program
{
    /*
     * Somatório: Soma de um conjunto de números.
     */
    public static void Main(string[] args)
    {
        int totalNumber, valueTotal = 0, newNumber;
        List<int> numbers = new List<int>();

        Console.WriteLine("Digite quantos números deseja somar?");
        totalNumber = int.Parse(Console.ReadLine());

        for (int i = 0; i < totalNumber; i++)
        {
            Console.WriteLine("Digite o número:");
            newNumber = Convert.ToInt32(Console.ReadLine());

            numbers.Add(newNumber);
        }

        for (int i = 0; i < numbers.Count; i++)
        {
            valueTotal += numbers[i];
        }

        Console.WriteLine("A Soma do conjunto de números é: " + valueTotal + "");
        Console.ReadKey();
    }
}