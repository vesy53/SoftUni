using System;
using System.Linq;

namespace p04TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool isTriple = false;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int sum = arr[i] + arr[j];

                    if (arr.Contains(sum))
                    {                                                 
                        isTriple = true;
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {sum}");                            
                    }   
                }
            }

            if (isTriple == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
