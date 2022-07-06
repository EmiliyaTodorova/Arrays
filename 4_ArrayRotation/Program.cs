using System;
using System.Linq;

namespace _4_ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotationCount = int.Parse(Console.ReadLine());
            for(int i = 0; i < rotationCount; i++)
            {
                int firstElement = arr[0];
                for(int j = 0; j <= arr.Length-2; j++)
                {
                    arr[j] = arr[j+1];
                }
                arr[arr.Length-1] = firstElement;   
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
