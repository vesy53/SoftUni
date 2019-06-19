namespace p01._03.ReverseArray
{
    using System;
    using System.Linq;

    class ReverseArray
    {
        static int[] numbers;

        static void Main(string[] args)
        {
            numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = 0;
            ReverseArrayWithForLoopRecursion(index);
            
            Console.WriteLine(string.Join(" ", numbers));
        }

        public static void ReverseArrayWithForLoopRecursion(int index)
        {
            if (index > (numbers.Length / 2 - 1))
            {
                return;
            }

            int first = numbers[index];
            int temp = numbers[numbers.Length - index - 1];

            numbers[index] = temp;
            numbers[numbers.Length - index - 1] = first;

            ReverseArrayWithForLoopRecursion(++index);
        }

        /*public static void ReverseArrayWithWhile(
            int start,
            int end)
        {
            int temp;

            while (start < end)
            {
                temp = numbers[start];
                numbers[start] = numbers[end];
                numbers[end] = temp;
                start++;
                end--;
            }
        }*/
    }
}
