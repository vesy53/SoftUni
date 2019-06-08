namespace p05._01.FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FilterByAge
    {
        static void Main(string[] args)
        {
            var data = new Dictionary<string, int>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ");

                string name = input[0];
                int age = int.Parse(input[1]);

                if (!data.Any(d => d.Key == name))
                {
                    data.Add(name, 0);
                }

                data[name] = age;
            }

            string condition = Console.ReadLine();
            int searchAge = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            if (condition == "older")
            {
                var olderData = data
                    .Where(d => d.Value >= searchAge)
                    .ToDictionary(d => d.Key, d => d.Value);

                if (format.Length == 2)
                {
                    PrintNameAndAge(olderData);
                }
                else
                {
                    string formatParam = format[0];

                    switch (formatParam)
                    {
                        case "name":
                            PrintName(olderData);
                            break;
                        case "age":
                            PrintAge(olderData);
                            break;
                    }
                }
            }
            else if (condition == "younger")
            {
                var youngerData = data
                    .Where(d => d.Value < searchAge)
                    .ToDictionary(d => d.Key, d => d.Value);

                if (format.Length == 2)
                {
                    PrintNameAndAge(youngerData);
                }
                else
                {
                    string formatParam = format[0];

                    switch (formatParam)
                    {
                        case "name":
                            PrintName(youngerData);
                            break;
                        case "age":
                            PrintAge(youngerData);
                            break;
                    }
                }
            }
        }

        private static void PrintAge(Dictionary<string, int> newData)
        {
            foreach (var itemData in newData)
            {
                int age = itemData.Value;

                Console.WriteLine($"{age}");
            }
        }

        private static void PrintName(Dictionary<string, int> newData)
        {
            foreach (var itemData in newData)
            {
                string name = itemData.Key;

                Console.WriteLine($"{name}");
            }
        }

        private static void PrintNameAndAge(Dictionary<string, int> newData)
        {
            foreach (var itemData in newData)
            {
                string name = itemData.Key;
                int age = itemData.Value;

                Console.WriteLine($"{name} - {age}");
            }
        }
    }
}
