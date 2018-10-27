using System;
using System.Linq;

namespace p06PowerPlants1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int day = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    arr[i]++;
                }

                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] != 0)
                    {
                        arr[j]--;
                    }
                }

                day++;
                int sum = 0;

                for (int j = 0; j < arr.Length; j++)
                {
                    sum += arr[j];
                }

                if (sum > 0)
                {
                    if (i == arr.Length - 1)
                    {
                        for (int k = 0; k < arr.Length; k++)
                        {
                            if (arr[k] > 0)
                            {
                                arr[k]++;
                            }
                        }

                        i = -1;
                    }

                    continue;
                }
                else
                {
                    int season = day / arr.Length;
                    string result = $"survived {day + 1} days ({season} ";

                    if (season == 1)
                    {
                        result += "season)";
                    }
                    else
                    {
                        result += "seasons)";
                    }

                    Console.WriteLine(result);
                    break;
                }
            }
        }
    }
}
