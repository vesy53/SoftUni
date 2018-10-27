using System;

namespace p13DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            string findWord = "";

            for (int i = 1; i <= num; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                int sum = letter + key;
                char newSum = Convert.ToChar(sum);
                findWord += newSum;
            }

            Console.WriteLine(findWord);
        }
    }
}
