using System;
using System.Linq;

namespace p06SumReversedNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                //използвамме .ToString() за да можем да използваме .Reverse()
                string currentStrNum = currentNum.ToString();
                char[] reversedNumArray = currentStrNum
                    .Reverse()
                    .ToArray();
                //тук char[] го превръщаме в string
                string reversedNum = new string(reversedNumArray);

                arr[i] = int.Parse(reversedNum);
            }

            Console.WriteLine(arr.Sum());
        }
    }
}
