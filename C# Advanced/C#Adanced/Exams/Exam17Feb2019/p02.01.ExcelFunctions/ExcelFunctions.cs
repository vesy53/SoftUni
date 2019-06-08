namespace p02._01.ExcelFunctions
{
    using System;
    using System.Linq;

    class ExcelFunctions
    {
        static string[][] jaggedArr;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            jaggedArr = new string[size][];

            FullTheMatrix(jaggedArr);

            string[] input = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string command = input[0];
            string header = input[1];

            int colIndex = TakeNeededColumnIndex(header);

            if (command == "hide")
            {
                string[][] newDelColMatrix = new string[size][];

                for (int row = 0; row < jaggedArr.Length; row++)
                {
                    int length = jaggedArr[row].Length - 1;

                    newDelColMatrix[row] = new string[length];

                    for (int col = 0, newCol = 0; col < jaggedArr[row].Length; col++)
                    {
                        if (col == colIndex)
                        {
                            continue;
                        }

                        newDelColMatrix[row][newCol] = jaggedArr[row][col];
                        newCol++;
                    }
                }

                PrintHideResult(newDelColMatrix);
            }
            else if (command == "sort")
            {
                PrintFirstRow();

                string[][] newMatrix = new string[size - 1][];

                for (int row = 1; row < jaggedArr.Length; row++)
                {
                    int length = jaggedArr[row].Length;

                    newMatrix[row - 1] = new string[length];

                    for (int col = 0; col < jaggedArr[row].Length; col++)
                    {
                        newMatrix[row - 1][col] = jaggedArr[row][col];
                    }
                }

                IOrderedEnumerable<string[]> result = newMatrix
                    .OrderBy(row => row[colIndex]);

                PrintSortResult(result);
            }
            else if (command == "filter")
            {
                string value = input[2];

                PrintFirstRow();

                for (int row = 0; row < jaggedArr.Length; row++)
                {
                    if (jaggedArr[row][colIndex].Contains(value))
                    {
                        Console.WriteLine(string.Join(" | ", jaggedArr[row]));
                    }
                }
            }
        }

        private static void PrintSortResult(
            IOrderedEnumerable<string[]> result)
        {
            foreach (string[] row in result)
            {
                PrintRow(row);
            }
        }

        private static void PrintHideResult(
            string[][] newDelColMatrix)
        {
            foreach (string[] row in newDelColMatrix)
            {
                PrintRow(row);
            }
        }

        private static void PrintRow(string[] row)
        {
            Console.WriteLine(string.Join(" | ", row));
        }

        private static void PrintFirstRow()
        {
            Console.WriteLine(string.Join(" | ", jaggedArr[0]));
        }

        private static int TakeNeededColumnIndex(string header)
        {
            int colIndex = 0;

            for (int col = 0; col < jaggedArr[0].Length; col++)
            {
                string searchHeader = jaggedArr[0][col];

                if (searchHeader == header)
                {
                    colIndex = col;
                }
            }

            return colIndex;
        }

        private static void FullTheMatrix(string[][] jaggedArr)
        {
            for (int row = 0; row < jaggedArr.Length; row++)
            {
                string[] elements = Console.ReadLine()
                    .Split(", ",
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .ToArray();

                jaggedArr[row] = elements;
            }
        }
    }
}
