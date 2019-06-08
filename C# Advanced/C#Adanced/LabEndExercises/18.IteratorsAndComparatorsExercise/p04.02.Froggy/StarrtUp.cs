namespace p04._02.Froggy
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int[] jumpingNums = Console.ReadLine()
                .Split(new char[] { ',', ' ' },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(jumpingNums);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
