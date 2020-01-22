using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayA = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] arrayB = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            int counterEqual = 0;
            int firstDifference = 0;
            bool findDifference = false;
            for (int i = 0; i < arrayA.Length; i++)
            {
                int currentA = arrayA[i];
                int currentB = arrayB[i];
                if (currentA == currentB)
                {
                    sum += currentA;
                    counterEqual++;
                }
                else if (currentA != currentB && findDifference == false)
                {
                    firstDifference = i;
                    findDifference = true;
                }
            }
            if (counterEqual == arrayA.Length)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {firstDifference} index");
            }
        }
    }
}
