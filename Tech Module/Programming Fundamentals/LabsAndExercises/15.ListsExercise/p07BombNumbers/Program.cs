using System;
using System.Collections.Generic;
using System.Linq;

namespace p07BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int bombNum = arr[0];
            int power = arr[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNum = numbers[i];

                if (currentNum == bombNum)
                {
                    //колко скачаме на ляво, като правим проверка 
                    //дали не излизаме извън лявата граница на List-a
                    int leftIndex = Math.Max(i - power, 0);
                    //аналогично и за дясната част - извън дясната граница
                    int rightIndex = Math.Min(i + power, numbers.Count - 1);

                    var removeCount = rightIndex - leftIndex + 1;

                    numbers.RemoveRange(leftIndex, removeCount);
                    i = -1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
