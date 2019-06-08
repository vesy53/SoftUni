namespace p05._05.FilterByAge
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
            string format = Console.ReadLine();

            Func<int, bool> conditionFunc = ConditionFunc(condition, searchAge);

            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);

            PrintResult(data, conditionFunc, printer);
        }

        private static void PrintResult(
            Dictionary<string, int> data, 
            Func<int, bool> conditionFunc, 
            Action<KeyValuePair<string, int>> printer)
        {
            foreach (var itemData in data)
            {
                int age = itemData.Value;

                if (conditionFunc(age))
                {
                    printer(itemData);
                }
            }
        }

        private static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            if (format == "name")
            {
                return x => Console.WriteLine(x.Key);
            }
            else if (format == "age")
            {
                return x => Console.WriteLine(x.Value);
            }
            else if (format == "name age")
            {
                return x => Console.WriteLine($"{x.Key} - {x.Value}");
            }

            return null;
        }

        private static Func<int, bool> ConditionFunc(
            string condition,
            int searchAge)
        {
            if (condition == "younger")
            {
                return x => x < searchAge;
            }
            else if (condition == "older")
            {
                return x => x >= searchAge;
            }

            return null;
        }
    }
}
