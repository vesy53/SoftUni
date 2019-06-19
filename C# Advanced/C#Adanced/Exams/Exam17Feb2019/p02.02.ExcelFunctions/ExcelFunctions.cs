namespace p02._02.ExcelFunctions
{
    using System;
    using System.Linq;

    class ExcelFunctions
    {
        private static string[][] matrix;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            matrix = new string[size][];

            FullTheMatrix();

            string[] tokens = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions
                    .RemoveEmptyEntries);

            string command = tokens[0];
            string header = tokens[1];

            int searchColumn = TakeIndexColumn(header);

            if (command.Equals("hide"))
            {
                string[][] newMatrix = new string[size][];

                for (int row = 0; row < matrix.Length; row++)
                {
                    int length = matrix[row].Length - 1;
                    newMatrix[row] = new string[length];

                    for (int col = 0, index = 0; col < matrix[row].Length; col++)
                    {
                        if (col != searchColumn)
                        {
                            newMatrix[row][index++] = matrix[row][col];
                        }
                    }
                }

                PrintTheMatrix(newMatrix);
            }
            else if (command.Equals("sort"))
            {
                PrintFirstRow();

                foreach (string[] row in matrix
                    .Skip(1)
                    .OrderBy(r => r[searchColumn]))
                {
                    Console.WriteLine(string.Join(" | ", row));
                }
            }
            else if (command.Equals("filter"))
            {
                string value = tokens[2];

                PrintFirstRow();

                for (int row = 1; row < matrix.Length; row++)
                {
                    if (matrix[row][searchColumn].Contains(value))
                    {
                        Console.WriteLine(
                            string.Join(" | ", matrix[row]));
                    }
                }
            }
        }


        private static void PrintTheMatrix(string[][] newMatrix)
        {
            for (int row = 0; row < newMatrix.Length; row++)
            {
                Console.WriteLine(
                    string.Join(" | ", newMatrix[row]));
            }
        }

        private static void PrintFirstRow()
        {
            Console.WriteLine(string.Join(" | ", matrix[0]));
        }

        private static int TakeIndexColumn(string header)
        {
            int column = 0;

            for (int row = 0; row < 1; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == header)
                    {
                        column = col;
                        break;
                    }
                }
            }

            return column;
        }

        private static void FullTheMatrix()
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                string[] elements = Console.ReadLine()
                    .Split(", ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                matrix[row] = new string[elements.Length];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = elements[col];
                }
            }
        }
    }
}
