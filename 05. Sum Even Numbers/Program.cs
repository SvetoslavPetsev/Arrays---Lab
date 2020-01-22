using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int numberCheck = numbers[i];
                if (numberCheck % 2 == 0)
                {
                    sum += numberCheck;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
