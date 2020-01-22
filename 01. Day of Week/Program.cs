using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayWeek = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday","Saturday", "Sunday"};
            int dayNumber = int.Parse(Console.ReadLine());
            if (dayNumber <= 0 || dayNumber > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(dayWeek[dayNumber - 1]);
            }
        }
    }
}
