namespace p03._01.TargetMultiplier
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class TargetMultiplier
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[][] matrix = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                int[] line = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                matrix[i] = line;
            }

            int[] targetCell = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int targetRow = targetCell[0];
            int targetCol = targetCell[1];

            int neighborsCellsSum = matrix[targetRow][targetCol - 1] +
                matrix[targetRow][targetCol + 1] +
                matrix[targetRow + 1][targetCol] +
                matrix[targetRow + 1][targetCol - 1] +
                matrix[targetRow + 1][targetCol + 1] +
                matrix[targetRow - 1][targetCol] +
                matrix[targetRow - 1][targetCol - 1] +
                matrix[targetRow - 1][targetCol + 1];

            ////update old value in neighbours cells 

            matrix[targetRow][targetCol - 1] *= matrix[targetRow][targetCol];
            matrix[targetRow][targetCol + 1] *= matrix[targetRow][targetCol];
            matrix[targetRow + 1][targetCol] *= matrix[targetRow][targetCol];
            matrix[targetRow + 1][targetCol - 1] *= matrix[targetRow][targetCol];
            matrix[targetRow + 1][targetCol + 1] *= matrix[targetRow][targetCol];
            matrix[targetRow - 1][targetCol] *= matrix[targetRow][targetCol];
            matrix[targetRow - 1][targetCol - 1] *= matrix[targetRow][targetCol];
            matrix[targetRow - 1][targetCol + 1] *= matrix[targetRow][targetCol];

            //// update matget sell value

            matrix[targetRow][targetCol] *= neighborsCellsSum;

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
    }
}
