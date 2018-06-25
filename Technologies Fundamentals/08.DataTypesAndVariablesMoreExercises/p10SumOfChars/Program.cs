using System;

namespace p10SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                sum += Convert.ToChar(letter);
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
