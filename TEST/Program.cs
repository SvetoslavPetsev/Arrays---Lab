using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
           
            int[] newarray = new int[3];

            for (int i = 0; i < newarray.Length -1; i++)
            {
                newarray[i] = numbers[i];
            }
            Console.WriteLine(newarray[]);

        }

    }
}
