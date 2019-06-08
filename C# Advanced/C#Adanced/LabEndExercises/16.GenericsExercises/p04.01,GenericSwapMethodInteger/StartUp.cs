namespace p04._01_GenericSwapMethodInteger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Box<int> elements = new Box<int>();

            for (int i = 0; i < number; i++)
            {
                int input = int.Parse(Console.ReadLine());

                elements.Add(input);
            }

            int[] indexes = Console.ReadLine()
                .Split(' ',
                   StringSplitOptions
                   .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int firstIndex = indexes[0];
            int secondIndex = indexes[1];

            Swap(elements.Lists, firstIndex, secondIndex);

            foreach (int element in elements.Lists)
            {
                Console.WriteLine(
                    $"{element.GetType()}: {element.ToString()}");
            }
        }

        private static void Swap<T>(
            List<T> elements,
            int firstIndex,
            int secondIndex)
        {
            var temp = elements[firstIndex];
            elements[firstIndex] = elements[secondIndex];
            elements[secondIndex] = temp;
        }
    }
}
