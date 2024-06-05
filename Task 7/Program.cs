namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number.");
            int userInput = int.Parse(Console.ReadLine());

            int fibonacciNumber = 1;
            int previousNumber = 0;

            Console.Write("0,1,");
            for (int i = 1; i < userInput; i++)
            {
                int sum = previousNumber + fibonacciNumber;
                previousNumber = fibonacciNumber;
                fibonacciNumber = sum;
                Console.Write(fibonacciNumber + ",");
            }
        }
    }
}
