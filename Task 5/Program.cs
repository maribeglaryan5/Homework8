namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name");
            string userInput = Console.ReadLine();
            
            int vowelCount = 0;

            for (int i = 0; i < userInput.Length; i++)
            {
                char inputLetter = userInput[i];
                if (inputLetter == 'a')
                {
                    vowelCount++;
                }
                if(inputLetter == 'e')
                {
                    vowelCount++;
                }
                if(inputLetter == 'i')
                {
                    vowelCount++;
                }
                if(inputLetter == 'o')
                {
                    vowelCount++;
                }
                if (inputLetter == 'u')
                {
                    vowelCount++;
                }
            }

            Console.WriteLine($"vowel count is {vowelCount}");
        }
    }
}
