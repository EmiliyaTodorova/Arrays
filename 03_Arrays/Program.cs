using System;
using System.Linq;

namespace _03_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[n];
            int[] arr2 = new int[n];

            for(int i = 1; i <= n; i++)
            {
                int[] currentRowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int firstNumber = currentRowData[0];
                int secondNumber = currentRowData[1];
                if (i % 2 != 0)
                {
                    arr1[i - 1] = firstNumber;
                    arr2[i - 1] = secondNumber;
                } else
                {
                    arr1[i - 1] = secondNumber;
                    arr2[i - 1] = firstNumber;
                }
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));

        }
    }
}
