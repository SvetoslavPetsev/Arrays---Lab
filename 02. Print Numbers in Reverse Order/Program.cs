using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int[] numbers = new int[numberInput];
            for (int i = 0; i < numberInput; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int j = numberInput - 1; j >= 0; j--)
            {
                Console.Write(numbers[j] + " ");
            }
        }
    }
}
