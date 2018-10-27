using System;
using System.Collections.Generic;
using System.Linq;

class TearListInHalf
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> rightSide = new List<int>();
        List<int> leftSide = new List<int>();

        for (int i = 0; i < numbers.Count / 2; i++)
        {
            leftSide.Add(numbers[i]);
        }

        for (int i = numbers.Count / 2; i < numbers.Count; i++)
        {
            rightSide.Add(numbers[i]);           
        }

        List<int> divideNum = new List<int>();

        for (int i = 0; i < rightSide.Count; i++)
        {
            int currentNum = rightSide[i];
            int lastDigit = currentNum % 10;
            currentNum /= 10;
            int firstDigit = currentNum % 10;

            divideNum.Add(firstDigit);
            divideNum.Add(lastDigit);
        }

         for (int i = 1; i < divideNum.Count; i += 3)
         {
            int takeNum = 0;

             for (int j = 0; j < leftSide.Count; j++)
             {
                takeNum = leftSide[j];
                leftSide.Remove(leftSide[j]);
                break;
             }

             divideNum.Insert(i, takeNum);
         }

         Console.WriteLine(string.Join(" ", divideNum));
    }
}

