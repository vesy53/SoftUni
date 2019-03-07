using System;

namespace p02ReverseArrayOfIntegers3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] array = new int[number];

            for (int i = 0; i < number; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                array[i] = currentNum;
            }

           
        }
    }
}
