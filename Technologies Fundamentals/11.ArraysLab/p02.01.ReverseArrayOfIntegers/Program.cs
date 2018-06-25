using System;

namespace p02ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
        
            string[] currentNum = new string[number];

            for (int i = 0; i < number; i++)
            {
                string num = Console.ReadLine();

                currentNum[i] = num;
            }
            
            Array.Reverse(currentNum);

            Console.WriteLine(string.Join(" ", currentNum));
        }
    }
}
