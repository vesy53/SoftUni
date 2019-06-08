namespace p06._01.GenericCountMethodDouble
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Box<double> elements = new Box<double>();

            for (int i = 0; i < number; i++)
            {
                double input = double.Parse(Console.ReadLine());

                elements.Add(input);
            }

            double comparisonByValue = double.Parse(Console.ReadLine());

            int count = CompareElement(elements.Lists, comparisonByValue);

            Console.WriteLine(count);
        }

        private static int CompareElement<T>
            (List<T> lists,
            double comparisonByValue)
        {
            int count = 0;

            foreach (var item in lists)
            {
                if (comparisonByValue.CompareTo(item) < 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
