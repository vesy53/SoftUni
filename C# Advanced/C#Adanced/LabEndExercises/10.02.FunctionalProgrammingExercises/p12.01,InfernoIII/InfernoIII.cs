namespace p12._01.InfernoIII
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class InfernoIII
    {
        static void Main(string[] args)
        {
            Action<List<int>> print = p =>
                        Console.WriteLine(string.Join(" ", p));

            List<int> numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            List<Filter> filters = new List<Filter>();

            while (input.Equals("Forge") == false)
            {
                string[] tokens = input
                    .Split(';');

                string command = tokens[0];
                string type = tokens[1];
                int parameter = int.Parse(tokens[2]);

                Filter currFilter = new Filter(type, parameter);

                if (command == "Exclude")
                {
                    filters.Add(currFilter);
                }
                else if (command == "Reverse")
                {
                    filters.RemoveAll(f => f.Type == type &&
                                           f.Parameter == parameter);
                }

                input = Console.ReadLine();
            }

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                bool isValid = false;

                foreach (Filter filter in filters)
                {
                    string type = filter.Type;
                    int parameter = filter.Parameter;

                    Func<int, int, bool> function = TakeFunction(numbers, type);

                    if (function(i, parameter))
                    {
                        isValid = true;
                    }
                }

                if (isValid == false)
                {
                    result.Add(numbers[i]);
                }
            }

            print(result);
        }

        static Func<int, int, bool> TakeFunction(
            List<int> numbers,
            string type)
        {
            if (type == "Sum Left")
            {
                return (i, targetSum) => i == 0 ?
                        numbers[i] == targetSum :
                        numbers[i] + numbers[i - 1] == targetSum;
            }
            else if (type == "Sum Right")
            {
                return (i, targetSum) => i == numbers.Count - 1 ?
                        numbers[i] == targetSum :
                        numbers[i] + numbers[i + 1] == targetSum;
            }
            else if (type == "Sum Left Right")
            {
                return (i, targetSum) => numbers.Count == 1 ? numbers[i] == targetSum :
                        i == numbers.Count - 1 ? numbers[i - 1] + numbers[i] == targetSum :  //if i = lastPosition ? sum = numbers to left
                        i == 0 ? numbers[i] + numbers[i + 1] == targetSum :
                        numbers[i - 1] + numbers[i] + numbers[i + 1] == targetSum;
            }

            return null;
        }
    }

    class Filter
    {
        public Filter(string type, int parameter)
        {
            this.Type = type;
            this.Parameter = parameter;
        }

        public string Type { get; set; }

        public int Parameter { get; set; }
    }
}
