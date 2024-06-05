using System;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number.");
            int userInput = int.Parse(Console.ReadLine());

            int digitsSum = 0;

            if (userInput >= 10)
            {
                userInput = 9;
            }

            for (int i = 1; i <= userInput; i++)
            {
                digitsSum += i;
            }

            Console.WriteLine($"Sum of digits is {digitsSum}");
        }
    }
}
