namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number.");
            int userInput = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= userInput; i++)
            {
                factorial*= i;
            }

            Console.WriteLine($"factorial is {factorial}");
        }
    }
}
