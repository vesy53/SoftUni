namespace p05._01.GenericCountMethodString
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Box<string> elements = new Box<string>();

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();

                elements.Add(input);
            }

            string comparisonByValue = Console.ReadLine();  

            int count = CompareElement(elements.Lists, comparisonByValue);

            Console.WriteLine(count);
        }

        private static int CompareElement<T>
            (List<T> lists, 
            string comparisonByValue)
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
