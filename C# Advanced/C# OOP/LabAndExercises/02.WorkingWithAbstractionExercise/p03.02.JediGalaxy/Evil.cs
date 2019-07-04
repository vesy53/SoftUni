namespace p03._02.JediGalaxy
{
    using System;
    using System.Linq;

    public class Evil
    {
        private int Row { get; set; }

        private int Col { get; set; }

        public void SetCoordinates(string evilCoordinates)
        {
            int[] coordinates = evilCoordinates
                .Split(new string[] { " " },
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            this.Row = coordinates[0];
            this.Col = coordinates[1];
        }

        public void DestroyedStars(int[,] matrix)
        {
            while (this.Row >= 0 && 
                   this.Col >= 0)
            {
                if (IsInTheRange(matrix))
                {
                    matrix[this.Row, this.Col] = 0;
                }

                this.Row--;
                this.Col--;
            }
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
