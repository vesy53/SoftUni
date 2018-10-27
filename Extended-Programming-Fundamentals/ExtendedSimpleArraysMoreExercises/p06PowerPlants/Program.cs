using System;
using System.Linq;

namespace p06PowerPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int season = 0;
            int days = 0;
            int count = 0;

            while(true)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (j == k)
                        {
                            continue;
                        } 
                        
                        if (arr[k] > 0)
                        {
                            arr[k]--;
                        }                     
                    }

                    days++;
                    count = 0;

                    for (int d = 0; d < arr.Length; d++)
                    {
                        if (arr[d] == 0)
                        {
                            count++;   
                            
                             if (count == arr.Length)
                             {
                                 break;
                             }
                        }

                    }

                    if (count == arr.Length)
                    {
                        break;
                    }
                }

                if (count == arr.Length)
                {
                    break;
                }

                for (int a = 0; a < arr.Length; a++)
                {
                    if (arr[a] > 0)
                    {
                        arr[a]++;
                    }
                }

                season++;
            }

            string result = $"survived {days} days ({season} ";

            if (season == 1)
            {
                result += "season)";
            }
            else
            {
                result += "seasons)";
            }

            Console.WriteLine(result);
        }
    }
}
