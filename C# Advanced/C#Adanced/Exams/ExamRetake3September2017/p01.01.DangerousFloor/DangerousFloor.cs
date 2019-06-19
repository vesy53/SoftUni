namespace p01._01.DangerousFloor
{
    using System;
    using System.Linq;

    class DangerousFloor
    {
        static char[][] matrix;

        static void Main(string[] args)
        {
            matrix = new char[8][];

            FullTheMatrix(matrix);

            while (true)
            {
                string input = Console.ReadLine();

                if (input.Equals("END"))
                {
                    break;
                }

                char chessFigure = input[0];
                int startRow = int.Parse(input[1].ToString());
                int startCol = int.Parse(input[2].ToString());
                int targetRow = int.Parse(input[4].ToString());
                int targetCol = int.Parse(input[5].ToString());

                if (matrix[startRow][startCol] != chessFigure)
                {
                    Console.WriteLine($"There is no such a piece!");
                    continue;
                }

                if (!CanMove(chessFigure, startRow, startCol, targetRow, targetCol))
                {
                    Console.WriteLine("Invalid move!");
                    continue;
                }

                if (!OutOfBoard(targetRow, targetCol))
                {
                    Console.WriteLine("Move go out of board!");
                    continue;
                }

                matrix[startRow][startCol] = 'x';
                matrix[targetRow][targetCol] = chessFigure;
            }
        }

        static bool OutOfBoard(int targetRow, int targetCol)
        {
            bool isInsideOfBoard = targetRow >= 0 &&
                targetRow < matrix.Length &&
                targetCol >= 0 &&
                targetCol < matrix[targetRow].Length;

            return isInsideOfBoard;
        }

        static bool CanMove(
            char chessFigure,
            int startRow,
            int startCol,
            int targetRow,
            int targetCol)
        {
            switch (chessFigure)
            {
                case 'P':
                    return MovePown(startRow, startCol, targetRow, targetCol);
                case 'R':
                    return MoveRook(startRow, startCol, targetRow, targetCol);
                case 'B':
                    return MoveBishop(startRow, startCol, targetRow, targetCol);
                case 'Q':
                    return MoveQueen(startRow, startCol, targetRow, targetCol);
                case 'K':
                    return MoveKing(startRow, startCol, targetRow, targetCol);
                default:
                    return false;
            }
        }

        static bool MoveKing(
            int startRow,
            int startCol,
            int targetRow,
            int targetCol)
        {
            bool isSameRow = Math.Abs(startRow - targetRow) == 0 &&
                Math.Abs(startCol - targetCol) == 1;
            bool isSameCol = Math.Abs(startCol - targetCol) == 0 &&
                Math.Abs(startRow - targetRow) == 1;
            bool isValidDiagonal = Math.Abs(startRow - targetRow) == 1 &&
                Math.Abs(startCol - targetCol) == 1;

            return isSameRow || isSameCol || isValidDiagonal;
        }

        static bool MoveQueen(
            int startRow,
            int startCol,
            int targetRow,
            int targetCol)
        {
            bool isValid = MoveRook(startRow, startCol, targetRow, targetCol) ||
                MoveBishop(startRow, startCol, targetRow, targetCol);

            return isValid;
        }

        static bool MoveBishop(
            int startRow,
            int startCol,
            int targetRow,
            int targetCol)
        {
            bool isValidMove =
                Math.Abs(startRow - targetRow) == Math.Abs(startCol - targetCol);

            return isValidMove;
        }

        static bool MoveRook(
            int startRow,
            int startCol,
            int targetRow,
            int targetCol)
        {
            bool isVolidRow = startRow == targetRow;
            bool isValidCol = startCol == targetCol;

            return isVolidRow || isValidCol;
        }

        static bool MovePown(
            int startRow,
            int startCol,
            int targetRow,
            int targetCol)
        {
            bool isValidRow = startRow - 1 == targetRow;
            bool isValidCol = startCol == targetCol;

            return isValidRow && isValidCol;
        }

        static void FullTheMatrix(char[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(',',
                        StringSplitOptions
                        .RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();
            }
        }
    }
}
