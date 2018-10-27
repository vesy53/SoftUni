using System;
using System.Collections.Generic;
using System.Linq;

class IncreasingCrisis
{  //80/100
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());

        List<int> newListOfNums = new List<int>();

        for (int i = 0; i < num; i++)
        {
            int[] currentArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (i == 0)
            {
                newListOfNums.InsertRange(0, currentArr);
                continue;
            }
            else
            {
                for (int j = 0; j < newListOfNums.Count; j++)
                {
                    if (newListOfNums[j] > currentArr[0])
                    {
                        newListOfNums.InsertRange(j, currentArr);
                        break;
                    }

                    if ((j + 1) == newListOfNums.Count && newListOfNums[j] <= currentArr[0])
                    {
                        newListOfNums.AddRange(currentArr);
                        break;
                    }
                }
             
                for (int r = 1; r < newListOfNums.Count; r++)
                {
                    if (newListOfNums[r - 1] > newListOfNums[r])
                    {
                        for (int k = r; k  < newListOfNums.Count; k ++)
                        {
                            newListOfNums.RemoveAt(k);
                            k--;
                        }

                        break;
                    }
                }
            }    
        }

        Console.WriteLine(string.Join(" ", newListOfNums));
    }
}

