﻿namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    int multiplication = i * j;
                    Console.WriteLine($"{i} * {j} = {multiplication}");
                }
                Console.WriteLine();
            }
        }
    }
}

