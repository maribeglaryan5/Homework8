using System.Diagnostics.CodeAnalysis;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number");
            int userInput = int.Parse(Console.ReadLine());

            int outputNumber = 1;

            for (int i = 0; i < userInput; i++)
            {
                int sum = outputNumber + i;
                outputNumber = sum;
            }

            Console.WriteLine($"Sum of natural numbers is {outputNumber}");
        }
    }
}
