using System;
using System.Collections.Generic;

class ShootListElements
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();

        List<int> numbers = new List<int>();
        int lastRemoved = 0;

        while (command != "stop")
        {
            int currentNum;
            bool isDigit = int.TryParse(command, out currentNum);

            if (isDigit)
            {               
                numbers.Insert(0, currentNum);
            }
            else 
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine(
                        $"nobody left to shoot! last one was {lastRemoved}");
                    return;
                }

                int average = FindAverageValueOfTheElements(numbers);

                for (int i = 0; i < numbers.Count; i++)
                {
                    int currentDigit = numbers[i];

                    if (average >= currentDigit)
                    {
                        numbers.Remove(currentDigit);
                        lastRemoved = currentDigit;
                        Console.WriteLine($"shot {currentDigit}");
                        break;
                    }
                }

                DecrementElements(numbers);
            }

            command = Console.ReadLine();
        }

        if (numbers.Count >= 1)
        {
            Console.WriteLine(
                "survivors: " + string.Join(" ", numbers));
        }
        else
        {
            Console.WriteLine(
                $"you shot them all. last one was {lastRemoved}");
        }
    }

    static int FindAverageValueOfTheElements(List<int> numbers)
    {
        int sum = 0;

        foreach (var num in numbers)
        {
            sum += num;
        }

        int average = sum / numbers.Count;

        return average;
    }

    static List<int> DecrementElements(List<int> numbers)
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            numbers[i]--;
        }

        return numbers;
    }
}

