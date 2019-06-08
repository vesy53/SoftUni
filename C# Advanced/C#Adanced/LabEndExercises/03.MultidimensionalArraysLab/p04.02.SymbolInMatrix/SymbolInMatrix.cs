namespace p04._02.SymbolInMatrix
{
    using System;
    using System.Linq;

    class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[][] jaggedArr = new char[size][];

            FillInTheMatrix(jaggedArr);

            char searchElement = char.Parse(Console.ReadLine());

            bool isMatch = false;

            for (int row = 0; row < jaggedArr.Length; row++)
            {
                if (jaggedArr[row].Contains(searchElement))
                {
                    isMatch = true;
                    int columnIndex = Array
                        .IndexOf(jaggedArr[row], searchElement);

                    Console.WriteLine($"({row}, {columnIndex})");
                    break;
                }
            }

            if (isMatch == false)
            {
                Console.WriteLine(
                    $"{searchElement} does not occur in the matrix");
            }
        }

        private static void FillInTheMatrix(char[][] jaggedArr)
        {
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                char[] chars = Console.ReadLine()
                    .ToCharArray();

                jaggedArr[row] = chars;
            }
        }
    }
}
