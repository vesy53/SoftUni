using System;
using System.Collections.Generic;
using System.Linq;

class IncreasingCrisis2
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        List<int> input = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        List<int> numbers = new List<int>();

        num--;
        input.Sort();
        numbers = input;

        while (num > 0)
        {
            input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if (numbers[i] <= input[0])
                {
                    i++;
                    numbers.Insert(i, input[0]);

                    for (int k = 1; k < input.Count; k++)
                    {
                        if (input[k] >= input[k - 1])
                        {
                            i++;
                            numbers.Insert(i, input[k]);

                            if (i != numbers.Count - 1 && numbers[i] > numbers[i + 1])
                            {
                                for (int p = i + 1; p < numbers.Count; p++)
                                {
                                    numbers.RemoveAt(p);
                                    p--;
                                }
                                break;
                            }

                        }
                        else
                        {
                            for (int p = i + 1; p < numbers.Count; p++)
                            {
                                numbers.RemoveAt(p);
                                p--;
                            }
                            break;
                        }
                    }
                    break;
                }
            }

            num--;
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}
        
                            

