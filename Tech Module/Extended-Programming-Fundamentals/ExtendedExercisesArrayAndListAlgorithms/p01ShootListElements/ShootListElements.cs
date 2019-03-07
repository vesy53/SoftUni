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
            if(command.Contains("bang") == false)
            {
                int currentNum = int.Parse(command);
                numbers.Insert(0, currentNum);
            }
            else if (command.Contains("bang"))
            {
                if (numbers.Count == 0)
                {
                    Console.WriteLine(
                        $"nobody left to shoot! last one was {lastRemoved}");
                    return;
                }

                int count = 0;
                int sum = 0;

                foreach (var num in numbers)
                {
                    sum += num;
                    count++;
                }

                int average = sum / count;

                for (int i = 0; i < numbers.Count; i++)
                {
                    int currentNum = numbers[i];

                    if (average >= currentNum)
                    {
                        numbers.Remove(currentNum);
                        lastRemoved = currentNum;
                        Console.WriteLine($"shot {currentNum}");
                        break;
                    }
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    numbers[i]--;
                }
               
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
}

