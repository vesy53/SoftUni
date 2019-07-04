namespace p03._02.JediGalaxy
{
    using System;
    using System.Linq;

    public class Player
    {
        private int Row { get; set; }

        private int Col { get; set; }

        public long SumStars { get; set; } = 0;

        public void SetCoordinates(string playerCoordinates)
        {
            int[] coordinates = playerCoordinates
                .Split(new string[] { " " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            this.Row = coordinates[0];
            this.Col = coordinates[1];
        }

        public long CalculateStars(int[,] matrix)
        {
            while (this.Row >= 0 && 
                   this.Col < matrix.GetLength(1))
            {
                if (IsInTheRange(matrix))
                {
                    this.SumStars += matrix[this.Row, this.Col];
                }

                this.Row--;
                this.Col++;
            }

            return this.SumStars;
        }

        private bool IsInTheRange(int[,] matrix)
        {
            return this.Row >= 0 &&
                   this.Row < matrix.GetLength(0) &&
                   this.Col >= 0 &&
                   this.Col < matrix.GetLength(1);
        }
    }
}