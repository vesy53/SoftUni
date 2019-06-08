namespace p04._01.Froggy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] stoneNums = Console.ReadLine()
                .Split(new char[] { ',', ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake<int> jumpingFrog = new Lake<int>(stoneNums);

            Console.WriteLine(string.Join(", ", jumpingFrog));
        }
    }
}
