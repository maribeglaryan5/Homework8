namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name");
            string userInput = Console.ReadLine();
            string reversedName = "";

            for (int i = 0; i < userInput.Length; i++)
            {
                char lastElement = userInput[userInput.Length - (i + 1)];
                reversedName += lastElement;
            }

            Console.WriteLine(reversedName);
        }
    }
}
