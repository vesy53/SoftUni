using System;

namespace p07ResizableArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            
            long?[] arr = new long?[4];

            int index = 0;
            int overflow = 3;

            while (input[0] != "end")
            {
                string command = input[0];

                if (command.Equals("push"))
                {
                    long number = long.Parse(input[1]);
                    arr[index] = number;
                    index++;
                }
                else if (command.Equals("pop"))
                {
                    arr[index - 1] = null;
                    index--;
                }
                else if (command.Equals("removeAt"))
                {
                    int removeIndex = int.Parse(input[1]);
                    arr[removeIndex] = null;

                    for (int i = removeIndex; i < index; i++)
                    {
                        //Тук преместваме елементите от премахнатата стойност от дясно на ляво
                        arr[i] = arr[i + 1];
                        arr[i + 1] = null;
                    }

                    index--;
                }
                else if (command.Equals("clear"))
                {
                    for (int i = 0; i <= index; i++)
                    {
                        arr[i] = null;
                    }

                    index = 0;
                }


                if (index == overflow)
                {
                    long?[] newArr = new long?[overflow + 1];
                    Array.Copy(arr, newArr, overflow + 1);
                    overflow += 4;
                    arr = new long?[overflow + 1];
                    Array.Copy(newArr, arr, overflow - 3);
                }

                input = Console.ReadLine().Split();
            }

            if (index <= 0)
            {
                Console.Write("empty array");
            }
            else
            {
                for (int i = 0; i <= index; i++)
                {
                    Console.Write($"{arr[i]} ");
                }
                // another method for print
                //Console.WriteLine(string.Join(" ", arr));
            }

            Console.WriteLine();
        }
    }
}
