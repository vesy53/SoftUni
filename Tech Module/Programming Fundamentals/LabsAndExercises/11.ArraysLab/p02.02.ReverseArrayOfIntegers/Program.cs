using System;

namespace p02ReverseArrayOfIntegers1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] array = new int[number];

            for (int i = number - 1; i >= 0; i--)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
