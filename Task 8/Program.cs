namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number.");
            int userFirstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Write a second number.");
            int userSecondNumber = int.Parse(Console.ReadLine());



            for (int i = userFirstNumber; i < userSecondNumber + 1; i++)
            {
                bool isPrime = false;
                if (i == 0 || i == 1)
                {
                    isPrime = false;
                }
                else if (i == 2)
                {
                    isPrime = true;
                }
                else
                {
                    for (int j = 2; j < i; j++)
                    {

                        if (i % j > 0)
                        {
                            isPrime = true;
                        }
                        else
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                

                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
