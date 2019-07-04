namespace p03._02.JediGalaxy
{
    public class Board
    {
        private int[,] matrix;

        public Board(int rows, int cols)
        {
            this.Matrix = new int[rows, cols];

            this.InitializeMatrix();
        }

        public int[,] Matrix
        {
            get => matrix;
            set => matrix = value;
        }

        private void InitializeMatrix()
        {
            int value = 0;

            for (int row = 0; row < this.Matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.Matrix.GetLength(1); col++)
                {
                    matrix[row, col] = value++;
                }
            }
        }
    }
}
