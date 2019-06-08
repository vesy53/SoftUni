namespace p12._02.InfernoIII
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
            var filters = new Dictionary<string, Dictionary<int, Func<int, int, bool>>>();

            List<int> numbers = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("Forge") == false)
            {
                string[] tokens = input
                    .Split(';');

                string command = tokens[0];
                string funcName = tokens[1];
                int value = int.Parse(tokens[2]);

                Func<int, int, bool> sumFunc = TakeFunction(numbers, funcName);

                if (command == "Exclude")
                {
                    if (!filters.ContainsKey(funcName))
                    {
                        filters.Add(funcName, new Dictionary<int, Func<int, int, bool>>());
                    }

                    if (!filters[funcName].ContainsKey(value))
                    {
                        filters[funcName].Add(value, sumFunc);
                    }
                }
                else if (command == "Reverse")
                {
                    if (filters.ContainsKey(funcName))
                    {
                        filters[funcName].Remove(value);
                    }
                }

                input = Console.ReadLine();
            }

            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                bool isValid = true;

                foreach (var filter in filters)
                {
                    Dictionary<int, Func<int, int, bool>> values = filter.Value;

                    foreach (var kvp in values)
                    {
                        int currSum = kvp.Key;
                        Func<int, int, bool> dataFunction = kvp.Value;

                        if (dataFunction(i, currSum))
                        {
                            isValid = false;
                            break;
                        }
                    }
                }

                if (isValid)
                {
                    result.Add(numbers[i]);
                }
            }

            print(result);
        }

        static Func<int, int, bool> TakeFunction(
            List<int> numbers,
            string funcName)
        {
            if (funcName == "Sum Left")
            {
                return (i, targetSum) => i == 0 ?
                        numbers[i] == targetSum :
                        numbers[i] + numbers[i - 1] == targetSum;
            }
            else if (funcName == "Sum Right")
            {
                return (i, targetSum) => i == numbers.Count - 1 ?
                        numbers[i] == targetSum :
                        numbers[i] + numbers[i + 1] == targetSum;
            }
            else if (funcName == "Sum Left Right")
            {
                return (i, targetSum) => numbers.Count == 1 ? numbers[i] == targetSum :
                        i == numbers.Count - 1 ? numbers[i - 1] + numbers[i] == targetSum :  //if i = lastPosition ? sum = numbers to left
                        i == 0 ? numbers[i] + numbers[i + 1] == targetSum :
                        numbers[i - 1] + numbers[i] + numbers[i + 1] == targetSum;
            }

            return null;
        }
    }
}
